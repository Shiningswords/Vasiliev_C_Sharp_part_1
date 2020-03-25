/*
 Напишите программу со статическим методом, которым вычисляется сумма квадратов натуральных чисел
 1^2+2^2+3^2+...+n^2. Число n передается аргументом методу. Предложите версию метода с рекурсией и без рекурсии.
 Для проверки результата можете использовать формулу n(n+1)(2n+1)/6
 */
using System;

class Program
{
    //Не рекурсивная функция подсчета суммы квадратов
    static int sqrSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += (i * i);
        }
        return sum;
    }

    //Рекурсивная функция подсчета суммы квадратов
    static int sqrSumRec(int n)
    {
        if (n <= 1) return 1;
        else return (n * n) + sqrSumRec(n - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(sqrSum(6));
        Console.WriteLine(sqrSumRec(6));
        Console.WriteLine(6 * (6 + 1) * (2 * 6 + 1) / 6);
        Console.ReadKey();
    }
}