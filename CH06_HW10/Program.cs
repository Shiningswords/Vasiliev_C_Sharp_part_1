/*
 Напишите программу со статическими методами для вычисления косинуса,
 гиперболического косинуса и гиперболичекого синуса.
 */
using System;

class MyMath
{
    static public double Fact(double x)
    {
        if (x == 1)
            return 1;
        else
            return x * Fact(x - 1);
    }

    public static double cos(double x)
    {
        double sum = 0;
        for (int i = 1; i < 100; i++)
        {
            sum += ((Math.Pow(-1, i) * Math.Pow(x, 2 * i)) / Fact(2 * i));
        }
        sum += 1;
        return sum;
    }

    public static double cosh(double x)
    {
        double sum = 0;
        for (int i = 1; i < 100; i++)
        {
            sum += (Math.Pow(x, 2 * i)) / Fact(2 * i);
        }
        sum += 1;
        return sum;
    }

    public static double sinh(double x)
    {
        double sum = 0;
        for (int i = 1; i < 100; i++)
        {
            sum += (Math.Pow(x, 2 * i + 1)) / Fact(2 * i + 1);
        }
        sum += x;
        return sum;
    }
}
class Program
{
    static void Main(string[] args)
    {
        double cos = MyMath.cos(2.23658);
        Console.WriteLine(cos);
        Console.WriteLine($"Контрольное значение: {Math.Cos(2.23658)}");

        double cosh = MyMath.cosh(2.23658);
        Console.WriteLine(cosh);
        Console.WriteLine($"Контрольное значение: {Math.Cosh(2.23658)}");

        double sinh = MyMath.sinh(2.23658);
        Console.WriteLine(sinh);
        Console.WriteLine($"Контрольное значение: {Math.Sinh(2.23658)}");

        Console.ReadKey();
    }
}