/*
 Напишите программу со статическим методом, аргументом которому передается произвольное
 количество целочисленных аргументов. Результатом метод возвращает массив из двух элементов:
 это значения наибольшего и наименьшего значений среди аргументов, переданных методу.
 */
using System;

class Program
{
    static int[] MinMax(params int[] a)
    {
        int[] arr = { a[0], a[0] };

        for (int k = 0; k < a.Length; k++)
        {
            if (a[k] > arr[1])
                arr[1] = a[k];
        }
        for (int k = 0; k < a.Length; k++)
        {
            if (a[k] < arr[0])
                arr[0] = a[k];
        }
        return arr;
    }
    static void Main(string[] args)
    {
        int[] arr = MinMax(3, 54, 1, 65, 43, 11, 4, 6, 150, 8);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}