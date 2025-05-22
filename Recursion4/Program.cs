using System;

class Program
{
    static int ClimbStairsHead(int n)
    {
        if (n <= 1) return 1;
        return ClimbStairsHead(n - 1) + ClimbStairsHead(n - 2);
    }

    static int ClimbStairsTail(int n, int a = 1, int b = 1, int i = 2)
    {
        if (n == 0 || n == 1) return 1;
        if (i > n) return b;
        return ClimbStairsTail(n, b, a + b, i + 1);
    }

    static void Main()
    {
        Console.Write("Введіть кількість сходинок: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Головна рекурсія: " + ClimbStairsHead(n));
        Console.WriteLine("Хвостова рекурсія: " + ClimbStairsTail(n));
    }

}
