/*
 Напишите программу с классом, в котором есть статические методы, которым можно передавать произвольное количество
 целочисленных аргументов (или целочисленный массив). Методы, на основании переданных аргументов или массива, позволяют вычислить:
 наибольшее значение, наименьшее значение, а также среднее значение из набора чисел.
 */
using System;

class StaticMtds
{
    public static int Max(params int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    public static int Min(params int[] arr)
    {
        int min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }

    public static int Middle(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        sum /= arr.Length;
        return sum;
    }

}

class Program
{
    static void Main(string[] args)
    {
        int max = StaticMtds.Max(10, 20, 30, 58, 47, 25, 69);
        Console.WriteLine($"Max: {max}");
        int min = StaticMtds.Min(10, 20, 30, 58, 47, 25, 69);
        Console.WriteLine($"Min: {min}");
        int[] arr = { 10, 20, 30, 58, 47, 25, 69 };
        int middle = StaticMtds.Middle(arr);
        Console.WriteLine($"Middle: {middle}");

        Console.ReadKey();
    }
}