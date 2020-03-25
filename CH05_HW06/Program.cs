/*
 Напишите программу со статическим методом, аргументом которому передается
 двумерный целочисленный массив. У метода, кроме аргумента-массива, есть два неинициализированных аргумента.
 Результатом метод возвращает значение наибольшего элемента в массиве.
 Неинициализированным аргументам присваиваются значения индексов этого элемента.
 */
using System;

class Program
{
    static int Max(int[,] arr, out int Y, out int X)
    {
        int max = arr[0, 0];
        Y = 0;
        X = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 1; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    Y = i;
                    X = j;
                }
            }
        }
        return max;
    }
    static void Main(string[] args)
    {
        int[,] arr = { { 3, 5, 8, 9, 6 }, { 1, 4, 7, 8, 5 } };
        int X;
        int Y;
        int max = Max(arr, out Y, out X);
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Max: {max}");
        Console.WriteLine($"Y: {Y}");
        Console.WriteLine($"X: {X}");
        Console.ReadKey();
    }
}