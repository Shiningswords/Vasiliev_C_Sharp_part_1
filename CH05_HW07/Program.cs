/*
 Напишите программу со статическим методом, аргументом которому передается одномерный символьный массив.
 В результате вызова метода элементы массива попарно меняются местами: первый - с последним,
 второй - с предпоследним и так далее.
 */
using System;
class Program
{
    static void charSwap(char[] arr)
    {
        char tmp;
        int i = 0;
        int j = arr.Length - 1;
        for (; i < arr.Length / 2; i++, j--)
        {
            tmp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = tmp;
        }
    }
    static void Main(string[] args)
    {
        char[] arr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'R' };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        charSwap(arr);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}