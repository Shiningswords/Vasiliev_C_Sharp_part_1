/*
Напишите программу, в которой пользователь вводит сначала имя, а затем фамилию.
Программа выводит информацию об имени и фамилии пользователя.
Консольная версия.
*/
using System;

class HW1_CH1_Console
{
    static void Main()
    {
        string FirstName;
        string LastName;

        Console.Title = "Фамилия и Имя";
        Console.Write("Введите Ваше имя: ");
        FirstName = Console.ReadLine();

        Console.Write("Введите Вашу фамилию: ");
        LastName = Console.ReadLine();

        string txt = "Тебя зовут: " + FirstName + " и твоя фамилия: " + LastName;
        Console.WriteLine(txt);
        Console.ReadKey();
    }

}