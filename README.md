# This Repository is a Compilation of my CS Projects for my classes at The University of Texas at Dallas
A key project to look at is Project 1 in the Operating Systems Concepts Project Folder. This Project required implementing a CPU and memory system with a custom ISA. This has 5 test examples to use to see this CPU and memory system in action. Users can create their own test programs using this ISA:

## Instruction Set
1 = Load value              (Load the value into the AC)

2 = Load addr               (Load the value at the address into the AC)

3 = LoadInd addr            (Load the value from the address found in the given address into the AC (for example, if LoadInd 500, and 500 contains 100, then load from 100))

4 = LoadIdxX addr           (Load the value at (address+X) into the AC (for example, if LoadIdxX 500, and X contains 10, then load from 510))

5 = LoadIdxY addr           (Load the value at (address+Y) into the AC)

6 = LoadSpX                 (Load from (Sp+X) into the AC (if SP is 990, and X is 1, load from 991)

7 = Store addr              (Store the value in the AC into the address)

8 = Get                     (Gets a random int from 1 to 100 into the AC)

9 = Put port                (If port=1, writes AC as an int to the screen; If port=2, writes AC as a char to the screen)

10 = AddX                   (Add the value in X to the AC)

11 = AddY                   (Add the value in Y to the AC)

12 = SubX                   (Subtract the value in X from the AC)

13 = SubY                   (Subtract the value in Y from the AC)

14 = CopyToX                (Copy the value in the AC to X)

15 = CopyFromX              (Copy the value in X to the AC)

16 = CopyToY                (Copy the value in the AC to Y)

17 = CopyFromY              (Copy the value in Y to the AC)

18 = CopyToSp               (Copy the value in AC to the SP)

19 = CopyFromSp             (Copy the value in SP to the AC)

20 = Jump addr              (Jump to the address)

21 = JumpIfEqual addr       (Jump to the address only if the value in the AC is zero)

22 = JumpIfNotEqual addr    (Jump to the address only if the value in the AC is not zero)

23 = Call addr              (Push return address onto stack, jump to the address)

24 = Ret                    (Pop return address from the stack, jump to the address)

25 = IncX                   (Increment the value in X)

26 = DecX                   (Decrement the value in X)

27 = Push                   (Push AC onto stack)

28 = Pop                    (Pop from stack into AC)

29 = Int                    (Perform system call)

30 = IRet                   (Return from system call)

50 = End                    (End execution)

## Input File Format
- Each instruction is on a separate line, with its operand (if any) on the following line.
- The instruction or operand may be followed by a comment which the loader will ignore.
- Anything following an integer is a comment, whether or not it begins with //.
- A line may be blank in which case the loader will skip it without advancing the load address.
- A line may begin by a period followed by a number which causes the loader to change the load address to the number after the period.

## Compilation
C/C++:

compile:    gcc project1.c -o project1

run:        project1 [Program Name].txt [Number of Executions Before Timer System Call]
