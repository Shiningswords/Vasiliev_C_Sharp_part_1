/*
 Напишите программу, в которой есть статический метод. Аргументом методу передается текстовое значение.
 Результатом метод возвращает текст, в котором, по сравнению с текстом-аргументом между символами вставлены пробелы.
 */
using System;
class Program
{
    static string Space(string txt)
    {
        string newTxt = "";
        for (int i = 0; i < txt.Length; i++)
        {
            newTxt += txt[i] + " ";
        }
        return newTxt;
    }
    static void Main(string[] args)
    {
        string txt = "Excusemewhattheduck?";
        Console.WriteLine(txt);
        txt = Space(txt);
        Console.WriteLine(txt);
        Console.ReadKey();
    }
}