/*
 Напишите программу, которая проверяет вторую справа цифру в восьмеричном представлении числа,
 введенного пользователем. Число вводится в десятичном (обычном) представлении.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("введите число,а я вычислю вторую справа цифру в восмеричном представлении");
            string i = Convert.ToString(Convert.ToInt32(Console.ReadLine()), 8);
            Console.WriteLine(i);
            int c = Convert.ToInt32(i);
            int b = c / 10 % 10;
            Console.WriteLine("В восьмеричной системе вторая цифра справа: " + b);
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}

