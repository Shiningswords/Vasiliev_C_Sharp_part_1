/*
 Напишите программу со статическим методом, аргументом которому передается целочисленный массив, 
 а результатом возвращается среднее значение для элементов массива (сумма значений элементов, 
 деленная на количество элементов в массиве)
 */
using System;
class Program
{
    static int Median(int[] arr)
    {
        int med = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            med += arr[i];
        }
        med /= arr.Length;
        return med;
    }
    static void Main(string[] args)
    {
        int[] arr = { 1, 55, 69, 2, 54, 74, 12, 36, 5 };
        int med = Median(arr);
        Console.WriteLine(med);
        Console.ReadKey();
    }
}