/*
 Напишите программу, в которой создается целочисленный массив,
 заполняется случайными числами и после этого значения элементов 
 в массиве сортируются в порядке убывания значений.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(1, 101);
        }
        foreach (int c in nums)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        int temp;

        //Сортировка элементов в массиве:
        for (int i = 1; i < nums.Length; i++)
        {
            //Перебор элементов:
            for (int j = 0; j < nums.Length - 1; j++)
            {
                //Если значение элемента слева больше значения элемента справа:
                if (nums[j] < nums[j + 1])
                {
                    temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                }
            }
        }
        foreach (int c in nums)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        Console.ReadKey();
    }
}