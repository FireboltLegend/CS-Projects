#include <iostream>
#include <cmath>

int main()
{
    int num;
    //declares integer num
    bool check = true;
    //declares boolean check and sets it to true
    std::cout << "Enter Number:" << std::endl;
    //prompts use to enter number
    std::cin >> num;
    //stores user input into num
    if (num == 1 || num == 0 || num % 2 == 0 && num != 2 || num % 5 == 0 && num != 5)
    //checks if num is equal to 0 or 1 or if num modulo 2 or 5 equals 0 as this would indicate num is not prime
    {
        check = false;
        //check becomes false
    }
    else
    {
        for (int i = 2; i <= num/2; i++)
        //iterates through a loop half of num times
        {
            if (num % i == 0 && num != 2)
            //checks if num modulo loop counter variable i equals 0 as this would indicate num is not prime
            {
                check = false;
                //check becomes false
                break;
                //exits for loop because num is confirmed not prime
            }
        }
    }
    if (check)
    //if num is prime
    {
        std::cout << num << " is a prime number" << std::endl;
        //outputs num is prime
    }
    else
    //if num is not prime
    {
        std::cout << num << " is not a prime number" << std::endl;
        //outputs num is not prime
    }
    return 0;
}