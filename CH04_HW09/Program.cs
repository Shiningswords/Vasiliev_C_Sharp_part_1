/*
 Напишите программу, в которой создается и инициализируется двумерный числовой массив.
 Затем из этого массива удаляется строка и столбец (создается новый массив, в котором по сравнению
 с иходным удалена одна строка и один столбец). Индекс удаляемой строки и индекс удаляемого столбца
 определяется с помощью генератора случайных чисел.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] nums = new int[5, 5];
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

        int row = rnd.Next(0, 5);
        int col = rnd.Next(0, 5);
        Console.WriteLine("Удаляем ряд " + row + " и столбец " + col);
        Console.WriteLine("-------------------------");

        int[,] nums2 = new int[nums.GetLength(0) - 1, nums.GetLength(1) - 1];

        for (int i = 0, j = 0; i < nums.GetLength(0); i++)
        {
            if (i == row)
                continue;

            for (int k = 0, u = 0; k < nums.GetLength(1); k++)
            {
                if (k == col)
                    continue;

                nums2[j, u] = nums[i, k];
                Console.Write(nums2[j, u] + "\t");
                u++;
            }
            j++;
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}