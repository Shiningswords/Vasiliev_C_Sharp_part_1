/*
Напишите программу, в которой пользователь последовательно вводит название текущего дня недели, название месяца и дату.
Программа выводит сообщение о сегодняшней дате(день недели, дата, месяц).
Консольная версия.
*/
using System;

class HW1_CH1_Console
{
    static void Main()
    {
        string DayOfWeek, month, date;

        Console.Title = "Дата";
        Console.Write("Введите наименование дня недели: ");
        DayOfWeek = Console.ReadLine();

        Console.Write("Введите наименование месяца: ");
        month = Console.ReadLine();

        Console.Write("Введите дату: ");
        date = Console.ReadLine();

        string txt = "Сегодня: " + DayOfWeek + ", Дата: " + date + ", Месяц: " + month;
        Console.WriteLine(txt);
        Console.ReadKey();
    }

}