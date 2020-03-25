/*
 Напишите программу с перегруженным статическим методом. Если аргументом методу передается
 два целых числа, то результатом возвращается ссылка на целочисленный массив, состоящий из натуральных чисел,
 а первое и последнее число в массиве определяется аргументами метода. Например, если передать аргументами числа 2 и 4,
 то результатом будет массив из чисел 2, 3 и 4. Если аргументами методу передаются два символьных значения, то результатом
 возвращается ссылка на массив, состоящий из последовательности символов, а первый и последний символы
 определяются аргументами метода. Например, если передать аргументами методу символы 'B', 'D', то в результате получим массив
 из символов 'B,'C' и 'D'.
 */
using System;

class Program
{
    static int[] OverloadMtd(int x, int y)
    {

        if (x < y)
        {
            int[] arr = new int[(y - x) + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x;
                x++;
            }
            return arr;
        }
        else
        {
            int[] arr = new int[(x - y) + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = y;
                y++;
            }
            return arr;
        }
    }
    static char[] OverloadMtd(char x, char y)
    {
        if ((int)x < (int)y)
        {
            char[] arr = new char[((int)y - ((int)x) + 1)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = x;
                x++;
            }
            return arr;
        }
        else
        {
            char[] arr = new char[(((int)x - ((int)y) + 1))];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = y;
                y++;
            }
            return arr;
        }
    }
    static void Main(string[] args)
    {
        int[] arr = OverloadMtd(22, 8);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
        char[] arr1 = OverloadMtd('Z', 'G');
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i] + " ");
        }
        Console.ReadKey();
    }
}