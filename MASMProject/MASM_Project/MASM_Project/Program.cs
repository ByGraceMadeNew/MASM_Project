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
        else if (n >= 2)
        {
            fibArray[n-1] = FibonacciRecursive(n - 1, fibArray);
            fibArray[n] = fibArray[n - 2] + fibArray[n - 1];
            return fibArray[n];
        }
        else
        {
            throw new Exception("The Fibonacci sequence does not work below the 0th number");
        }
    }
    static void Main()
    {
        int n = 10; // Example input
        int[] fibArray = new int[n + 1];
        try
        {
            Console.WriteLine(" Fibonacci of " + n + " is: " + FibonacciRecursive(n, fibArray));
            Console.WriteLine(" Fibonacci Series up to " + n + ": ");
            for (int i = 0; i <= n; i++)
            {
                Console.Write(fibArray[i] + ", ");
            }
        }
        catch
        {
            Console.WriteLine("This sequence cannot be computed.");
        }
    }
}

