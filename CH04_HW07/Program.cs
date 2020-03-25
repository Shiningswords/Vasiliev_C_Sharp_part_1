/*
 Напишите программу, в которой создается символьный массив, 
 а затем порядок элементов в массиве меняется на обратный
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        char[] symbs = { 'f', 'h', 'f', 'h', 'f', 'h', 't' };
     
        foreach (char c in symbs)
        { Console.Write(c + " "); }
        Console.WriteLine();

        Array.Reverse(symbs);

        foreach (char c in symbs)
        { Console.Write(c + " "); }
        Console.WriteLine();

        Console.ReadKey();
    }
}