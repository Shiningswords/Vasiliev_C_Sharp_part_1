/*
 Напишите программу, в которой пользователь вводит число, а программой отображается последовательность
 из трех чисел: число, на единицу меньше введеного, введеное число и число, на единицу больше введеного.
 Консольная версия.
 */
using System;

namespace HW9_Nums_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите число: ");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"{num - 1} {num} {num + 1}");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
