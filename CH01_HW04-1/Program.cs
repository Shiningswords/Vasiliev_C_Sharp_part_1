/*
Напишите программу, в которой пользователю предлагается ввести название месяца и кол-во дней в этом месяце.
Программа выводит сообщение о том, что соответствующий месяц содержит указанное количество дней.
Консольная версия.
 */
using System;

class HW1_CH1_Console
{
    static void Main()
    {
        string month, days, txt;

        Console.Title = "Месяц";
        Console.Write("Введите название месяца: ");
        month = Console.ReadLine();

        Console.Write("Введите количество дней в месяце {0}: ", month);
        try
        {
            days = Console.ReadLine();
            if (Int32.Parse(days) == 31) txt = "В месяце " + month + " " + days + " день.";
            else txt = "В месяце " + month + " " + days + " дней.";
            Console.WriteLine(txt);
        }
        catch(Exception e)
        {
            Console.WriteLine("Неверно введено количество дней");
        }
        Console.ReadKey();
    }
}