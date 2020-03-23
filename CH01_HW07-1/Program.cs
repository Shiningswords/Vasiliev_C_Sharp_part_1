/*
 Напишите программу, в которой по возрасту определяется год рождения.
 Консольная версия.
 */
using System;

namespace HW7_YearAge_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Сколько Вам лет?");
                int age = Int32.Parse(Console.ReadLine());
                int year = 2019 - age;
                Console.WriteLine($"Вы родились примерно в {year - 1}-{year} годах!");
                Console.ReadKey();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
