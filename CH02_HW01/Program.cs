/*
 Напишите программу, которая проверяет, делится ли введенное пользователем число на 3.
 */
using System;

namespace HW01_DelitNa3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число и узнаете делится ли оно на 3: ");
                int num = Int32.Parse(Console.ReadLine());
                string txt = "Число " + (num % 3 == 0 ? "делится" : "не делится") + " на 3";
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
}