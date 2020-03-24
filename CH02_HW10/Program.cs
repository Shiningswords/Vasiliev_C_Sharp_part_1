/*
 Напишите программу, в которой для введенного пользователем числа в бинарном
 представлении значение второго бита меняется на противоположное (исходное нулевое значение бита
 меняется на единичное а исходное единичное значение бита меняется на нулевое).
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число, программа выдаст число в двоичном представлении и заменит второй бит:");
            int number = Int32.Parse(Console.ReadLine());
            string binar = Convert.ToString(number, 2);
            Console.WriteLine("Бинарное представление числа: " + binar);
            int num;
            if (binar.Length > 3)
            {
                num = binar[binar.Length - 2] == 0 ? number ^ 8 : number ^ 2;
            }
            else
            {
                num = binar[binar.Length - 1] == 0 ? number | 8 : number ^ 2;
            }
            Console.WriteLine("Число с замененным вторым битом: " + num);
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

