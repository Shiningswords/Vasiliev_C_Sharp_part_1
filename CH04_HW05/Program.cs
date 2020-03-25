/*
 Напишите программу, в которой создается массив и заполняется случайными числами. Массив отображается в конс. окне.
 В этом массиве необходимо определить элемент с минимальным значением.
 В частности, программа должна вывести значение элемента с минимальным значением и индекс этого элемента.
 Если минимальных значений несколько, должны быть выведены индексы всех элементов.
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
            nums[i] = rnd.Next(1, 11);
        }
        foreach (int c in nums)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();

        int min = nums[0];
        int index = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < min)
            {
                min = nums[i];
                index = i;
            }

        }
        Console.WriteLine($"Наименьший элемент: {min}, с индексом {index}");
        for (int i = index + 1; i < nums.Length; i++)
        {
            if (nums[i] == min)
            {
                Console.WriteLine($"Наименьший элемент: {nums[i]}, с индексом {i}");
            }
        }
        Console.ReadKey();
    }
}