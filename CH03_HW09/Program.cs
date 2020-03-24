/*
 Напишите программу, в которой пользователем вводится два целых числа.
 Программа выводит все целые числа - начиная с наименьшего (из двух введенных чисел).
 Предложите разные версии программы (с использованием разных операторов цикла), а также
 механизм обработки исключений этой программы.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите первое целое число: ");
        try
        {
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе целое число: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 < num2)
            {
                while (num1 <= num2)
                {
                    Console.Write($"{num1} ");
                    num1++;
                }
            }
            else
            {
                while (num2 <= num1)
                {
                    Console.Write($"{num2} ");
                    num2++;
                }
            }
        }
        catch
        {
            Console.WriteLine("Вы ввели не целое число");
        }
        Console.ReadLine();
    }
}
