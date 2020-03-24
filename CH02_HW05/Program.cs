/*
 Напишите программу, которая проверяет, сколько тысяч во введенном пользователем числе
 (определяется четвертая цифра справа в десятичном представлении числа).
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число и узнаете сколько в нем тысяч (4 цифра справа):");
            int num = Int32.Parse(Console.ReadLine());
            int thousands = num / 1000 % 10;
            Console.WriteLine("В числе " + num + " следующее кол-во тысяч: " + thousands);
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}