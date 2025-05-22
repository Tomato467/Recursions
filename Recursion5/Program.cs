using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Результат (головна рекурсія): " + PowHead(x, n));
        Console.WriteLine("Результат (хвостова рекурсія): " + PowTail(x, n));
    }

    static double PowHead(double x, int n)
    {
        if (n == 0) return 1;
        if (n < 0) return 1 / PowHead(x, -n);
        return x * PowHead(x, n - 1);
    }

    static double PowTail(double x, int n, double result = 1)
    {
        if (n == 0) return result;
        if (n < 0) return PowTail(1 / x, -n, 1);
        return PowTail(x, n - 1, result * x);
    }
}
