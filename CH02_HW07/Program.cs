/*
 Напишите программу, которая вычисляет третий бит справа в двоичном представлении числа, введенного пользователем.
 Число вводится в десятичном (обычном) представлении. В программе используйте оператор побитового сдвига.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число, программа выдаст число в двоичном представлении и скажет третий справа бит:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Третий бит справа: " + ((number >> 2) % 2));
            Console.WriteLine("Число в двоичном представлении: " + Convert.ToString(number, 2));
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}