#include <iostream>

int main()
{
    std::cout << "Enter Number:" << std::endl;
    int num;
    std::string blank = "";
    std::cin >> num;
    for (int i = 0; i < num; i++)
    {
        for (int k = num - i - 1; k > 0; k--)
        {
            blank = blank + " ";
        }
        std::cout << blank;
        blank = "";
        for (int j = 0; j < i+1; j++)
        {
            std::cout << "*";
        }
        std::cout << std::endl;
    }
    return 0;
}