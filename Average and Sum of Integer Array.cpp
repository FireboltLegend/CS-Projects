#include <iostream>

int main()
{
    std::cout << "Enter Positive Integer: ";
    //prompts user to eneter positive integer
    int num;
    //declares integer variable num
    std::cin >> num;
    //stores input in num
    int* arr = new int[num];
    //declares pointer to array of integers
    long long sum = 0;
    //declares long long variable sum
    for (int i = 0; i < num; i++)
    {
        arr[i] = rand();
        //sets each value in array to random number
        sum += arr[i];
        //adds the random number into sum
    }
    std::cout << "Average: " << sum/num << std::endl << "Sum: " << sum;
    //outputs the average and sum of the values in the array
    delete[] arr;
    //deletes the array
    return 0;
}