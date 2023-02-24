#include <stdio.h>
#include <iostream>
#include <string>

int main()
{
    std::string pwd;
    //declare string variable pwd
    bool isup = false;
    //declare boolean variable isup and set it to false
    bool num = false;
    //declare boolean variable num and set it to false
    bool spec = false;
    //declare boolean variable spec and set it to false
    std::cout << "Enter Password:" << std::endl;
    //prompts user to enter password
    std::cin >> pwd;
    //stores user input in pwd
    for (int i = 0; i < pwd.length() && !(isup && num && spec); i++)
    //loop iterates based on the length of the pwd or ends loop if all conditions are satisfied
    {
        isup = (isup || isupper(pwd[i]));
        //checks if the character at pwd[i] is uppercase and stores that boolean value or the current value of isup if isup is true
        num = (num || isdigit(pwd[i]));
        //checks if the character at pwd[i] is a digit and stores that boolean value or the current value of num if num is true
        spec = (spec || ispunct(pwd[i]));
        //checks if the character at pwd[i] is a punctuation character and stores that boolean value or the current value of spec if spec is true
    }
    if (pwd.length() >= 8 && isup && num && spec)
    //checks if all conditions including the length of the password being at least 8 characters are satisfied
    {
        std::cout << "Password Conforms to Organization's Password Policy!" << std::endl;
        //outputs that the password is valid
    }
    else
    {
        std::cout << "Password Does Not Conform to Organization's Password Policy!" << std::endl;
        //outputs that the password is invalid
    }
    return 0;
}