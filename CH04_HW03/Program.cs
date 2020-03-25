/*
 Напишите программу, в которой создается одномерный символьный массив из 10 элементов.
 Массив заполняется буквами "через одну", начиная с буквы 'a': то есть массив заполняется буквами 'a','c','e','g' и т.д.
 Отобразите массив в консольном окне в прямом и обратном порядке.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] symbs = new char[10];
        char s = 'a';
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = s;
            s = (char)((int)s + 2);
        }
        foreach (char c in symbs)
        {
            Console.Write(c + " ");
        }
        Console.WriteLine();
        for (int i = symbs.Length - 1; i >= 0; i--)
        {
            Console.Write(symbs[i] + " ");
        }
        Console.ReadKey();
    }
}