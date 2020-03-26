/*
 Напишите программу со статическим методом, аргументом которому передается текст, а результатом
 возвращается символьный массив, состоящий из букв (без учета пробелов и знаков препинания), из которых
 состоит текст. Если буква несколько раз встречается в тексте, в массиве она представлена одним элементом.
 Буквы в массиве-результате должны быть отсортированы в алфавитном порядке.
 */
using System;
class Program
{
    static char[] SymbsArr(string txt)
    {
        string newtxt = "";
        foreach (char c in txt)
        {
            if (c != ',' && c != '.' && c != '!' && c != '?' && c != ';' && c != ':' && c != ' ' && !newtxt.Contains(c.ToString()))
            {
                newtxt += c.ToString();
            }
        }
        char[] arr = newtxt.ToCharArray();
        Array.Sort(arr);
        return arr;
    }
    static void Main(string[] args)
    {
        string txt = "text of, texts!";
        char[] arr = SymbsArr(txt);
        Console.WriteLine(txt);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.ReadKey();
    }
}