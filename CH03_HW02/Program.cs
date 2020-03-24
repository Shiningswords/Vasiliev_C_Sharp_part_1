/*
 Напишите программу, в которой пользователь последовательно вводит два целых числа. Программа определяет,
 какое из чисел больше или они равны, и выводит сообщение в диалоговом окне. Используйте обработку исключений.
 */
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2) Console.WriteLine($"Число {num1} больше числа {num2}!");
            else if (num1 == num2) Console.WriteLine($"Число {num2} равняется числу {num1}!");
            else Console.WriteLine($"Число {num2} больше числа {num1}!");
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Вы ввели не число!");
            Console.ReadKey();
        }
    }
}

