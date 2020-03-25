/*
 Напишите программу, в которой создается массив из 11 целочисленных элементов.
 Массив заполняется степенями двойки 1,2,4,8,16....1024.
 При заполнении массива учесть, что начальный элемент равен 1, а каждый следующий больше предыдущего в 2 раза.
 Отобразить массив в консольном окне в прямом и обратном порядке. Размер массива задется переменной
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        int size = 11;
        int[] nums = new int[size];
        int a = 1;
        for (int i = 0; i < size; i++)
        {

            nums[i] = a;
            a *= 2;
        }
        foreach (int c in nums)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        for (int i = size - 1; i >= 0; i--)
        {
            Console.Write(nums[i] + " ");
        }
        Console.ReadKey();
    }
}