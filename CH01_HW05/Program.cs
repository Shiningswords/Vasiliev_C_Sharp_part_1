/*
 Напишите программу, в которой по году рождения определяется возраст пользователя.
 Используйте консольный ввод и вывод данных.
 */
using System;

namespace HW5_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год Вашего рождения: ");
            try
            {
                int year = Convert.ToInt32(Console.ReadLine());
                int age = DateTime.Now.Year - year;
                Console.WriteLine($"Вам примерно {age} лет!");
                Console.ReadKey();
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}
