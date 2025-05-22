using System;

class Program
{
    static int FibonacciHead(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return FibonacciHead(n - 1) + FibonacciHead(n - 2); // рекурсія вглиб перед обчисленням
    }

    static int FibonacciTail(int n, int a = 0, int b = 1)
    {
        if (n == 0) return a;
        if (n == 1) return b;
        return FibonacciTail(n - 1, b, a + b); // результат передається далі
    }

    static void Main()
    {
        int n = 4;

        int resultHead = FibonacciHead(n);
        Console.WriteLine("Head recursion: " + resultHead);  // Output: 3

        int resultTail = FibonacciTail(n);
        Console.WriteLine("Tail recursion: " + resultTail);  // Output: 3
    }
}
