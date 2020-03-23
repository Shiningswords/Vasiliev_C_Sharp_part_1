/*
 Напишите программу для вычисления суммы двух чисел. Оба числа вводятся пользователем.
 Консольная версия
 */
using System;

namespace HW8_Sum_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int num2 = Int32.Parse(Console.ReadLine());
                Console.Write($"Сумма числа {num1} и числа {num2} равна: {num1 + num2} ");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}