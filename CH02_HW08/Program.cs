/*
 Напишите программу, в которой для введенного пользователем числа в бинарном
 представлении третий бит устанавливается равным единице.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите целое число, программа выдаст число в двоичном представлении и заменит третий бит на 1:");
            int number = Int32.Parse(Console.ReadLine());
            string binar = Convert.ToString(number, 2);
            Console.WriteLine("Бинарное представление числа: " + binar);
            int num = number | 4;
            Console.WriteLine("Число с замененным третьим битом на единицу " + num);
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

