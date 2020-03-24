/*
 Напишите программу, в которой вычисляется сумма четных чисел.
 Для проверки результатап воспользуйтесь тем, что 2 + 4 + 6 + ... + 2n = n(n + 1)
 Предложите версии программы использующие разные операторы цикла
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        //Цикл For
        #region
        //Console.Write("Введите целое число и узнаете сумму всех четных чисел до него: ");
        //int n = int.Parse(Console.ReadLine());
        //int s = 0;
        //Console.Write("Сумма четных чисел до {0} равна: ", n);

        //for (int k = 1; k <= n; k++)
        //{
        //    if (k%2 == 0) s += k;
        //}
        //Console.WriteLine(s);
        //Console.ReadKey();
        #endregion

        //Цикл While
        int k = 1, n = 10, s = 0;
        Console.Write($"Сумма 2 + 4 + 6 + ... + {2 * n} = ");

        while (k <= n * 2)
        {
            if (k % 2 == 0) s += k;
            k++;
        }
        Console.WriteLine(s);
        Console.ReadKey();
    }
}