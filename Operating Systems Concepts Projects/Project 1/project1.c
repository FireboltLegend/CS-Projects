#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <time.h>
#include <ctype.h>

#define TRUE 1
#define FALSE 0

int main(int argc, char *argv[])
{
    FILE *file = fopen(argv[1], "r");
    char line[100];
    int count = 0;
    int cpuToMemory[2];
    int memoryToCpu[2];
    if (pipe(cpuToMemory) < 0 || pipe(memoryToCpu))
    {
        exit(1);
    }
    int memory[2000];
    while(fgets(line, sizeof(line), file) != NULL)
    {
        if (line[0] == '.')
        {
            int jumpPoint = atoi(line + 1);
            count = jumpPoint;
            continue;
        }
        // else if (line[0] == '\n')
        // {
        //     continue;
        // }
        // else if (line[0] == " ")
        // {
        //     continue;
        // }
        // else if (line[0] == "\t")
        // {
        //     continue;
        // }
        else if (!isdigit(line[0]))
        {
            continue;
        }
        else
        {
            memory[count] = atoi(line);
        }
        // printf("Memory Address: %d, Value: %d\n", count, memory[count]);
        count++;
    }
    fclose(file);
    pid_t childPid = fork();
    switch(childPid)
    {
        case -1:
            perror("fork");
            exit(EXIT_FAILURE);
            break;
        case 0:
        {
            int address = 0;
            int data;
            while(TRUE)
            {
                // Read from the pipe and store it in address
                read(cpuToMemory[0], &address, sizeof(address));
                if(address == -1)
                {
                    read(cpuToMemory[0], &address, sizeof(address));
                    read(cpuToMemory[0], &data, sizeof(data));
                    memory[address] = data;
                    continue;
                }
                // Write to pipe the value stored in memory at the address
                write(memoryToCpu[1], &memory[address], sizeof(memory[address]));
                if(memory[address] == 50)
                {
                    exit(EXIT_SUCCESS);
                }
            }
            break;
        }
        default:
        {
            // Declares Variables PC, SP, IR, AC, X, Y and Initialize them to 0
            int PC, IR, AC, X, Y, temp;
            int SP;
            int writeFlag;
            int interrupt;
            int kernalMode = FALSE;
            int systemStack;
            int timeCounter;
            timeCounter = 0;
            int timer;
            timer = atoi(argv[2]);
            interrupt = FALSE;
            PC, IR, AC, X, Y, temp = 0;
            SP = 999;
            systemStack = 1999;
            writeFlag = -1;
            while(TRUE)
            {
                if(timeCounter >= timer && interrupt == FALSE)
                {
                    timeCounter = 0;
                    kernalMode = TRUE;
                    interrupt = TRUE;
                    write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                    write(cpuToMemory[1], &systemStack, sizeof(systemStack));
                    write(cpuToMemory[1], &SP, sizeof(SP));
                    SP = systemStack;
                    SP--;
                    write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                    write(cpuToMemory[1], &SP, sizeof(SP));
                    write(cpuToMemory[1], &PC, sizeof(PC));
                    SP--;
                    PC = 1000;
                }
                if (PC >= 1000 && kernalMode == FALSE)
                {
                    printf("Memory violation: accessing system address 1000 in user mode\n");
                    return 0;
                }
                write(cpuToMemory[1], &PC, sizeof(PC));
                read(memoryToCpu[0], &IR, sizeof(IR));
                // printf("\nBefore Executing Instruction | PC: %d, IR: %d, AC: %d, X: %d, Y: %d, SP: %d\n", PC, IR, AC, X, Y, SP);
                switch(IR)
                {
                    case 1:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 2:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        if (IR >= 1000 && kernalMode == FALSE)
                        {
                            printf("Memory violation: accessing system address 1000 in user mode\n");
                        }
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 3:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 4:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        IR += X;
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 5:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        IR += Y;
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 6:
                        temp = SP + X + 1;
                        write(cpuToMemory[1], &(temp), sizeof(temp));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        break;
                    case 7:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &IR, sizeof(IR));
                        write(cpuToMemory[1], &AC, sizeof(AC));
                        break;
                    case 8:
                        AC = rand() % 100 + 1;
                        break;
                    case 9:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        if(IR == 1)
                        {
                            printf("%d", AC);
                        }
                        if(IR == 2)
                        {
                            printf("%c", AC);
                        }
                        break;
                    case 10:
                        AC += X;
                        break;
                    case 11:
                        AC += Y;
                        break;
                    case 12:
                        AC -= X;
                        break;
                    case 13:
                        AC -= Y;
                        break;
                    case 14:
                        X = AC;
                        break;
                    case 15:
                        AC = X;
                        break;
                    case 16:
                        Y = AC;
                        break;
                    case 17:
                        AC = Y;
                        break;
                    case 18:
                        SP = AC;
                        break;
                    case 19:
                        AC = SP;
                        break;
                    case 20:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        PC = IR - 1;
                        break;
                    case 21:
                        PC++;
                        if(AC == 0)
                        {
                            write(cpuToMemory[1], &PC, sizeof(PC));
                            read(memoryToCpu[0], &IR, sizeof(IR));
                            PC = IR - 1;
                        }
                        break;
                    case 22:
                        PC++;
                        if(AC != 0)
                        {
                            write(cpuToMemory[1], &PC, sizeof(PC));
                            read(memoryToCpu[0], &IR, sizeof(IR));
                            PC = IR - 1;
                        }
                        break;
                    case 23:
                        PC++;
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        read(memoryToCpu[0], &IR, sizeof(IR));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        write(cpuToMemory[1], &PC, sizeof(PC));
                        SP--;
                        PC = IR - 1;
                        break;
                    case 24:
                        temp = NULL;
                        SP++;
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        read(memoryToCpu[0], &PC, sizeof(PC));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        write(cpuToMemory[1], &(temp), sizeof(temp));
                        break;
                    case 25:
                        X += 1;
                        break;
                    case 26:
                        X -= 1;
                        break;
                    case 27:
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        write(cpuToMemory[1], &AC, sizeof(AC));
                        SP--;
                        break;
                    case 28:
                        temp = NULL;
                        SP++;
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        read(memoryToCpu[0], &AC, sizeof(AC));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        write(cpuToMemory[1], &(temp), sizeof(temp));
                        break;
                    case 29:
                        if(interrupt == FALSE)
                        {
                            kernalMode = TRUE;
                            interrupt = TRUE;
                            write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                            write(cpuToMemory[1], &systemStack, sizeof(systemStack));
                            write(cpuToMemory[1], &SP, sizeof(SP));
                            SP = systemStack;
                            SP--;
                            PC++;
                            write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                            write(cpuToMemory[1], &SP, sizeof(SP));
                            write(cpuToMemory[1], &PC, sizeof(PC));
                            SP--;
                            PC = 1499;
                        }
                        break;
                    case 30:
                        kernalMode = FALSE;
                        interrupt = FALSE;
                        temp = NULL;
                        SP++;
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        read(memoryToCpu[0], &PC, sizeof(PC));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        write(cpuToMemory[1], &(temp), sizeof(temp));
                        SP++;
                        write(cpuToMemory[1], &SP, sizeof(SP));
                        read(memoryToCpu[0], &SP, sizeof(SP));
                        write(cpuToMemory[1], &writeFlag, sizeof(writeFlag));
                        write(cpuToMemory[1], &systemStack, sizeof(systemStack));
                        write(cpuToMemory[1], &(temp), sizeof(temp));
                        PC--;
                        break;
                    case 50:
                        return 0;
                        break;
                    default:
                        break;
                }
                // printf("\nAfter Executing Instruction | PC: %d, IR: %d, AC: %d, X: %d, Y: %d, SP: %d\n", PC, IR, AC, X, Y, SP);
                if (PC >= 1000 && kernalMode == FALSE)
                {
                    printf("Memory violation: accessing system address 1000 in user mode\n");
                    return 0;
                }
                timeCounter++;
                PC++;
            }
        }
    }
}