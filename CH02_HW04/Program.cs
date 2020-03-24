/*
 Напишите программу, которая проверяет, попадает ли введенное пользователем значение
 в диапазон от 5 до 10 включительно
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число и узнаете входит ли оно в диапазон от 5 до 10:");
            int num = Int32.Parse(Console.ReadLine());
            string txt = (num >= 5 && num <= 10 ? "Число входит в диапазон от 5 до 10" : "Число не входит в диапазон от 5 до 10");
            Console.WriteLine(txt);
            Console.ReadKey();
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}

