/*
 Напишите программу, в которой создается двумерный числовой массив и этот массив заполняется "змейкой":
 сначала первая строка(слева направо), затем последний столбец (сверху вниз), последняя строка (справа налево),
 первый столбец(снизу вверх), вторая строка (слева направо) и т.д.
 */
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[,] nums = new int[4, 4];
        Random rnd = new Random();
        int j = 0;
        int t = nums.GetLength(0);
        Thread A = new Thread(() => 
        {
            while (true)
            {
                for (int i = 0; i < nums.GetLength(0); i++)
                {
                    for (int k = 0; k < nums.GetLength(1); k++)
                    {
                        if (nums[i, k] == 0)
                        {
                            Console.Write(" " + "\t");
                            continue;
                        }
                        Console.Write(nums[i, k] + "\t");
                    }
                    Console.WriteLine();
                }
                Thread.Sleep(50);
                Console.Clear();
            }
        });
        A.Start();
        //первая строка
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            nums[0, i] = rnd.Next(1, 100);
            Thread.Sleep(1000);
        }
        // последний столбец
        --t;
        for (int i = 0 + ++j; i < nums.GetLength(1); i++)
        {
            nums[i, t] = rnd.Next(100);
            Thread.Sleep(1000);
        }
        //последняя строка
        for (int i = nums.GetLength(1) - 2; i >= 0; i--)
        {
            nums[t, i] = rnd.Next(100);
            Thread.Sleep(1000);
        }

        //первый столбец
        for (int i = nums.GetLength(1) - 2; i > 0; i--)
        {
            nums[i, 0] = rnd.Next(100);
            Thread.Sleep(1000);

        }
        //вторая строка
        for (int i = 1; i <= nums.GetLength(0) - 2; i++)
        {
            nums[j, i] = rnd.Next(100);
            Thread.Sleep(1000);
        }
        j++;
        //третья строка
        for (int i = nums.GetLength(1) - 2; i >= 1; i--)
        {
            nums[j, i] = rnd.Next(100);
            Thread.Sleep(1000);
        }
        Console.ReadKey();
    }
}

