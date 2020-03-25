/*
 Напишите программу, в которой создается символьный массив из 10 элементов.
 Массив заполнить большими (прописными) буквами английского алфавита.
 Буквы берутся подряд но только согласные.
 Отобразить массив в консольном окне.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] symbs = new char[10];
        char s = 'A';
        for (int i = 0; i < symbs.Length; i++)
        {
            s++;
            if (s == 'E' || s == 'I' || s == 'O' || s == 'U' || s == 'Y')
            { symbs[i] = ++s; }
            else
            {
                symbs[i] = s;
            }

        }
        foreach (char c in symbs)
        {
            Console.Write(c + " ");
        }
        Console.ReadKey();
    }
}