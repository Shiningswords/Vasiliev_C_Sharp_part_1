/*
 * Напишите программу, в которой есть статичесий метод, возвращающий результатом текстовое значение и
 * получающий аргументом текст. Результат метода - это переданный аргументом текст, в котором слова следуют в обратном порядке.
 * Словами считать блоки текста разделенные пробелами.
 */
using System;

class Program
{
    static string Reverse(string txt)
    {
        String[] words;
        string newtxt = "";
        words = txt.Split();
        for (int i = words.Length - 1; i >= 0; i--)
        {
            newtxt += words[i] + " ";
        }
        return newtxt;
    }
    static void Main(string[] args)
    {
        string txt = "Excuse me, what the duck?";
        Console.WriteLine(txt);
        txt = Reverse(txt);
        Console.WriteLine(txt);
        Console.ReadKey();
    }
}