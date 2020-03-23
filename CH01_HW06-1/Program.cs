/*
Напишите программу в которой пользователь вводит имя и год рождения, а программа отображает сообщение,
содержащее имя пользователя и его возраст.
Консольная версия.
 */
using System;

namespace HW6_NameAge_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Введите год Вашего рождения: ");
                int year = Convert.ToInt32(Console.ReadLine());
                int age = 2019 - year;
                Console.WriteLine("Введите Ваше имя: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Вас зовут {name} и Вам примерно {age} лет!");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Вы неверно ввели данные!");
                Console.ReadKey();

            }
        }
    }
}