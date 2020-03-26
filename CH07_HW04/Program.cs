/*
 Напишите программу со статическим методом, который выполняет сравнение текстовых строк.
 Текстовые строки сравниваются следующим образом: для каждого текстового значения определяется набор
 разных букв, входящих в текст (при этом количество вхождений буквы в текст значения не имеет).
 Текстовые строки считаются равными, если они содержат одинаковые наборы букв
 */
using System;
class Program
{
    static bool Comparer(string txt1, string txt2)
    {
        string newtxt1 = "", newtxt2 = "";
        foreach (char c in txt1)
        {
            if (newtxt1.Contains(c.ToString())) continue;
            else newtxt1 += c;
        }
        foreach (char c in txt2)
        {
            if (newtxt2.Contains(c.ToString())) continue;
            else newtxt2 += c;
        }
        char[] arr1 = newtxt1.ToCharArray();
        char[] arr2 = newtxt2.ToCharArray();
        Array.Sort(arr1);
        Array.Sort(arr2);
        newtxt1 = "";
        newtxt2 = "";
        foreach (char c in arr1)
        {
            newtxt1 += c;
        }
        foreach (char c in arr2)
        {
            newtxt2 += c;
        }
        bool flag = Equals(newtxt1, newtxt2);
        return flag;
    }
    static void Main(string[] args)
    {
        string txt1 = "abccdcdegh", txt2 = "ebggggcdddgggggghdggggggdehhhha";
        Console.WriteLine(txt1 + " и " + txt2 + " = " + Comparer(txt1, txt2));
        Console.ReadKey();
    }
}