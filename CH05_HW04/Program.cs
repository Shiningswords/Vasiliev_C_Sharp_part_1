/*
 Напишите программу со статическим методом, аргументом которому передается символьный массив, 
 а результатом возвращается ссылка на целочисленный массив, состоящий из кодов символов из 
 массива-аргумента.
 */
using System;
class Program
{
    static int[] charToInt(char[] arr)
    {
        int[] arrInt = new int[arr.Length];
        for (int i = 0; i < arrInt.Length; i++)
        {
            arrInt[i] = (int)arr[i];
        }
        return arrInt;
    }
    static void Main(string[] args)
    {
        char[] arr = { 'A', 'B', 'C', 'D', 'x', 'y', 'z' };
        int[] arrInt = charToInt(arr);

        for (int i = 0; i < arrInt.Length; i++)
        {
            Console.Write(arrInt[i] + " ");
        }
        Console.ReadKey();
    }
}
