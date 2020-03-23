/*
Напишите программу, в которой пользователь вводит имя и возраст.
Программа выводит сообщение об имени и возрасте.
Консольная версия.
 */
using System;

class HW1_CH1_Console
{
    static void Main()
    {
        string name;
        string age;

        Console.Title = "Фамилия и возраст";
        Console.Write("Введите Ваше имя: ");
        name = Console.ReadLine();

        Console.Write("Введите Ваш возраст: ");
        age = Console.ReadLine();

        string txt = "Тебя зовут " + name + " и тебе " + age + " лет.";
        Console.WriteLine(txt);
        Console.ReadKey();
    }

}