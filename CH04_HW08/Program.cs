/*
 Напишите программу, в которой создается двумерный целочисленный массив.
 Он заполняется случайными числами. Затем в этом массиве строки и столбцы меняются местами:
 первая строка становится вторым столбцом и так далее.
 Например, если исходный массив состоял из 3 строк и 5 столбцов, то в итоге получаем массив из 5 строк и 3 столбцов.
 */
using System;
class Program
{
    static void Main(string[] args)
    {
        int[,] nums = new int[3, 5];
        Random rnd = new Random();
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = rnd.Next(1, 101);
                Console.Write(nums[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("-------------------------");
        int[,] nums2 = new int[nums.GetLength(1), nums.GetLength(0)];

        for (int i = 0; i < nums.GetLength(1); i++)
        {
            for (int j = 0; j < nums.GetLength(0); j++)
            {
                nums2[i, j] = nums[j, i];
            }
        }

        for (int i = 0; i < nums2.GetLength(0); i++)
        {
            for (int j = 0; j < nums2.GetLength(1); j++)
            {
                Console.Write(nums2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}

