/*
 Напишите программу, которая проверяет, удовлетворяет ли введенное пользователем число следующим критериям:
 число делится на 4 и при этом оно не меньше 10.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число и узнаете проходит ли оно по критериям:\n" +
                "число делится на 4 и при этом оно не меньше 10");
            int num = Int32.Parse(Console.ReadLine());
            bool first = num % 4 == 0 ? true : false;
            bool second = num >= 10 ? true : false;
            string txt = "Число " + (first && second ? "удовлетворяет" : "не удовлетворяет") + " условиям";
            Console.WriteLine(txt);
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}

