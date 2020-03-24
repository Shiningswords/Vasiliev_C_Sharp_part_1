/*
 Напишите программу, в которой пользователю предлагается ввести название дня недели. 
 По введенному названию программа определяет порядковый номер дня в неделе. Если пользователь вводит
 неправильное название, программа выводит сообщение о том, что такого дня нет.
 Предложите версию на основе вложенных условных операторов и оператора выбора switch.
 */
using System;

class Program
{
    static void Main()
    {
        #region
        //Console.Write("Введите название дня недели и узнаете какой у него порядковый номер: ");
        //string day = Console.ReadLine();
        //if (day.ToLower() == "понедельник") Console.WriteLine("Понедельник имеет порядковый  номер 1!");
        //else if (day.ToLower() == "вторник") Console.WriteLine("Вторник имеет порядковый  номер 2!");
        //else if (day.ToLower() == "среда") Console.WriteLine("Среда имеет порядковый  номер 3!");
        //else if (day.ToLower() == "четверг") Console.WriteLine("Четверг имеет порядковый  номер 4!");
        //else if (day.ToLower() == "пятница") Console.WriteLine("Пятница имеет порядковый  номер 5!");
        //else if (day.ToLower() == "суббота") Console.WriteLine("Суббота имеет порядковый  номер 6!");
        //else if (day.ToLower() == "воскресенье") Console.WriteLine("Воскресенье имеет порядковый  номер 7!");
        //else Console.WriteLine("Такого дня недели не существует!");
        //Console.ReadKey();
        #endregion

        Console.Write("Введите название дня недели и узнаете какой у него порядковый номер: ");
        string day = Console.ReadLine();
        day = day.ToLower();
        switch (day)
        {
            case "понедельник":
                Console.WriteLine("Понедельник имеет порядковый  номер 1!");
                break;
            case "вторник":
                Console.WriteLine("Вторник имеет порядковый  номер 2!");
                break;
            case "среда":
                Console.WriteLine("Среда имеет порядковый  номер 3!");
                break;
            case "четверг":
                Console.WriteLine("Четверг имеет порядковый  номер 4!");
                break;
            case "пятница":
                Console.WriteLine("Пятница имеет порядковый  номер 5!");
                break;
            case "суббота":
                Console.WriteLine("Суббота имеет порядковый  номер 6!");
                break;
            case "воскресенье":
                Console.WriteLine("Воскресенье имеет порядковый  номер 7!");
                break;
            default:
                Console.WriteLine("Такого дня недели не существует!");
                break;
        }
        Console.ReadKey();
    }
}

