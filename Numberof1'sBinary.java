import java.util.Scanner;

public class Main
{
    public static int findNumOf1s(int N)
    {
        if (N == 0)
        {
            return 0;
        }
        else if (N == 1)
        {
            return 1;
        }
        else if ((N % 2) == 1)
        {
            return findNumOf1s(N/2) + 1;
        }
        else
        {
            return findNumOf1s(N/2);
        }
    }
    public static void main(String[] args)
    {
        Scanner input = new Scanner(System.in);
        System.out.print("Enter a Number: ");
        int N = input.nextInt();
        System.out.print("Number of 1’s in the Binary Representation of " + N + " is " + findNumOf1s(N) + ".");
    }
}
