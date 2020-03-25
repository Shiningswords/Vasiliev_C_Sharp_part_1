/*
 напишите программу, в которой создается одномерный числовой массив и заполняется числами, 
 которые при делении на 5 дают в остатке 2 (2,7,12,17). Размер массива вводится пользователем. 
 Предусмотреть обработку ошибки, связанной с вводом некорректного значения
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите длину массива с числами которые при делении на 5 в остатке дают 2:");
        try
        {
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное значение числа до которого будут производиться вычисления:");
            int max = int.Parse(Console.ReadLine());
            int[] nums = new int[length];
            int a = 0;

            for (int i = 0; i < max; i++)
            {
                if (i % 5 == 2 && a < nums.Length)
                {
                    nums[a] = i;
                    a++;
                }

            }
            foreach (int c in nums)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
        catch
        {
            Console.WriteLine("Вы ввели не число");
            Console.ReadKey();

        }
    }
}


