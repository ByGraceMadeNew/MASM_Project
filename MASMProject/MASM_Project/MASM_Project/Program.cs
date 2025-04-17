using System;
class Fibonacci
{
    static int FibonacciRecursive(int n, int[] fibArray)
    {
        // logic goes here
    }
    static void Main()
    {
        int n = 10; // Example input
        int[] fibArray = new int[n + 1];
        Console.WriteLine(" Fibonacci ␣ of ␣ " + n + " ␣ is : ␣ " +
        FibonacciRecursive(n, fibArray));
        Console.WriteLine(" Fibonacci ␣ Series ␣ up ␣ to ␣ " + n + " : ␣ ");
        for (int i = 0; i <= n; i++)
        {
            Console.Write(fibArray[i] + " ␣ ");
        }
    }
}
