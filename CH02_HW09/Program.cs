/*
 Напишите программу, в которой для введенного пользователем числа в бинарном
 представлении четвертый бит устанавливается равным нулю.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число, программа выдаст число в двоичном представлении и заменит четвертый бит на 0:");
            int number = Int32.Parse(Console.ReadLine());
            string binar = Convert.ToString(number, 2);
            Console.WriteLine("Бинарное представление числа: " + binar);
            int num = number ^ 8;
            Console.WriteLine("Число с замененным четвертым битом на ноль " + num);
            Console.WriteLine("Бинарное представление: " + Convert.ToString(num, 2));
            Console.ReadKey();
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}