/*
 Напишите программу, которая выводит последовательность чисел Фибоначчи.
 Количество чисел в последовательности вводится пользователем.
 Предложите версии программы, использующие разные операторы цикла.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //For
            #region
            Console.Write("Введите сколько чисел последовательности Фибоначчи вывести: ");
            decimal count = decimal.Parse(Console.ReadLine());
            decimal num1 = 1;
            decimal num2 = 1;
            decimal temp;
            Console.Write($"{num1} {num1} ");
            for (decimal i = 1; i < count - 1; i++)
            {
                temp = num1 + num2;
                Console.Write($"{temp} ");
                num1 = num2;
                num2 = temp;
            }
            Console.ReadKey();
            #endregion

            //For 2
            #region
            //Console.Write("Введите конец диапазона от 1 до : ");
            //long end = long.Parse(Console.ReadLine());
            //long j = 1;
            //for (long i = 1; i <= end; i += j)
            //{
            //    Console.Write("{0} ", i);
            //    j = i - j;
            //}
            //Console.ReadKey();
            #endregion
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}
