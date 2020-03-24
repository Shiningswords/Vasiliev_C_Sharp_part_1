/*
 Напишите программу, которая проверяет, удовлетворяет ли введенное пользователем число следующим критериям:
 при делении на 5 в остатке получается 2, а при делении на 7 в остатке получается 1.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число и узнаете проходит ли оно по критериям:\n" +
                "при делении на 5 в остатке получается 2, а при делении на 7 в остатке получается 1");
            int num = Int32.Parse(Console.ReadLine());
            bool first = num % 5 == 2 ? true : false;
            bool second = num % 7 == 1 ? true : false;
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