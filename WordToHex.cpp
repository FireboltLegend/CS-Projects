#include <stdio.h>
#include <iostream>
#include <string>

int main()
{
    std::cout << "Enter Word:" << std::endl;
    //prompts user to enter word
    std::string word;
    //declares string variable word
    std::cin >> word;
    //stores user input in string variable word
    int i = 0;
    //declares integer variable i to provide index for each character of string variable word
    while (word[i] != '\0')
    //runs through loop until character in string variable word is the null character
    {
        char ln = (word[i] & 15) + 48;
        /*declare char variable ln and set it equal to the lower bits of the current character
        by performing a bitwise and operation with 15 and adding 48 to bring the character into the digit range
        */
        char un = ((word[i] >> 4) & 15) + 48;
        /*declare char variable un and set it equal to the upper bits of the current character
        by performing a bit shift by 4 and then performing a bitwise and operation with 15 and adding 48 to bring
        the character into the digit range
        */
        if (ln > '9')
        //checks if lower bound chracter is greater than the chracter '9'
        {
            ln += 7;
            //adds 7 to the lower nibble to bring the character to be printed into the alphabet range
        }
        if (un > '9')
        //checks if upper bound chracter is greater than the chracter '9'
        {
            un += 7;
            //adds 7 to the upper nibble to bring the character to be printed into the alphabet range
        }
        std::cout << un << ln;
        //outputs the upper and lower nibbles
        i++;
        //adds 1 to i
    }
}