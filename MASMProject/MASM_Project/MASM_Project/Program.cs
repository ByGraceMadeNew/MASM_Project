using System;
class Fibonacci
{
    static int FibonacciRecursive(int n, int[] fibArray)
    {
        if (n == 0)
        {
            fibArray[0] = 0;
            return 0;
        }
        else if (n == 1)
        {
            fibArray[0] = 0;
            fibArray[1] = 1;
            return 1;
        }
        else if (n>2)
        {
            fibArray[n] = FibonacciRecursive(n-2, int[] fibArray) + FibonacciRecursive(n-1, int[] fibArray);
            return fibArray[n];
        }
        else
        {
            
        }
    }
    static void Main()
    {
        int n = 10; // Example input
        int[] fibArray = new int[n + 1];
        Console.WriteLine(" Fibonacci of " + n + " is: " +
        FibonacciRecursive(n, fibArray));
        Console.WriteLine(" Fibonacci Series up to " + n + ": ");
        for (int i = 0; i <= n; i++)
        {
            Console.Write(fibArray[i] + " ␣ ");
        }
    }
}
