/*
 Напишите программу, в которой описан статический метод для вычисления двойного факториала числа,
 переданного аргументом методу. По определению, двойной факториал числа n (n!!) - это произведение
 через одно всех чисел, не больших числа n. То есть n!! = n * (n - 2) * (n - 4) * ... (последний 
 множитель равен 1 для нечетного n и равен 2 для четного n). Например 6!! = 6 * 4 * 2 = 48
 5!!= 5 * 3 * 1 = 15
 Предложите версию без рекурсии и с рекурсией.
 */
using System;


class Program
{
    //Метод вычисления двойного факториала не рекурсивно
    static int dblFact(int n)
    {
        int res = n;
        for (int i = 0; i < n; i++)
        {
            n -= 2;
            res *= n;

        }
        return res;
    }

    //Рекурсивный метод вычисления двойного факториала
    static int dblFactRec(int n)
    {
        if (n <= 1) return 1;
        else return n * dblFactRec(n - 2);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(dblFact(6));
        Console.WriteLine(dblFact(5));
        Console.WriteLine(dblFactRec(6));
        Console.WriteLine(dblFactRec(5));
        Console.ReadKey();
    }
}