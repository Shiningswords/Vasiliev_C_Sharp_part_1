/*
 Напишите программу со статическим методом, которому аргументом передается целочисленный массив
 и целое число. Результатом метод возвращает ссылку на новый массив, который получается из исходного
 массива (переданного первым аргументом методу), если в нем взять несколько начальных элементов.
 Количество элементов, которые нужно взять из исходного массива, определяются вторым аргументом метода.
 Если второй аргумент метода больше длины массива, переданного первым аргументом, то методом создается копия 
 исходного массива и возвращается ссылка на эту копию.
 */
using System;

class Program
{
    static int[] pickArr(int[] a, int n)
    {
        if (n > a.Length)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }
        else
        {
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = a[i];
            }
            return arr;
        }
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int[] arr2 = pickArr(arr, 155);
        int[] arr3 = pickArr(arr, 5);

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        arr[0] = 2555555;

        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < arr3.Length; i++)
        {
            Console.Write(arr3[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}