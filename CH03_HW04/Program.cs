/*
 Напишите программу, в которой пользователю предлагается ввести целое число в диапазоне от 1 до 7,
 а программа определяет по этому числу день недели. Если введенное пользователем число выходит за допустимый диапазон,
 выводится сообщение о том, что введено некорректное значение.
 Используйте оператор switch. Предложите механизм обработки ошибки, связанной с вводом нечислового значения.
 */
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Введите целое число от 1 до 7 и узнаете какой это день недели: ");
        try
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine($"{num} это понедельник");
                    break;
                case 2:
                    Console.WriteLine($"{num} это вторник");
                    break;
                case 3:
                    Console.WriteLine($"{num} это среда");
                    break;
                case 4:
                    Console.WriteLine($"{num} это четверг");
                    break;
                case 5:
                    Console.WriteLine($"{num} это пятница");
                    break;
                case 6:
                    Console.WriteLine($"{num} это суббота");
                    break;
                case 7:
                    Console.WriteLine($"{num} это воскресенье");
                    break;
                default:
                    Console.WriteLine("Вы ввели числе вне диапазона от 1 до 7");
                    break;
            }
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Вы ввели не число!");
            Console.ReadKey();
        }
    }
}

