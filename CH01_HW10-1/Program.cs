/*
 Напишите программу, в которой пользователь вводит два числа, а программой вычисляется
 и отображается сумма и разность этих чисел.
 Консольная версия.
 */
using System;

namespace HW10_Calc_Console
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

                Console.WriteLine($"Сумма {num1 + num2}, Разность {num1 - num2}");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
