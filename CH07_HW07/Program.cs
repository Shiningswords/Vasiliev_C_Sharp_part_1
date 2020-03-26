/*
 Напишите программу со статическим методом, который эмулирует работу метода Substring().
 Аргументами статическому методу передается текст и два целочисленных аргумента.
 Результатом метод возвращает текстовую строку, которая состоит из символов текста (первый аргумент),
 начиная с позиции с индексом, определяемым вторым аргументом метода. Третий аргумент статического
 метода определяет количество символов, которые включаются в подстроку.
 */
using System;
class Program
{
    static string MySubstring(string txt, int start, int count)
    {
        string res = "";
        for (int i = start; i <= (start + count - 1); i++)
        {
            res += txt[i];
        }
        return res;
    }
    static void Main(string[] args)
    {
        string txt = "охайо!";
        int start = 1, count = 3;
        string res = MySubstring(txt, start, count);
        Console.WriteLine("Исходный текст: " + txt);
        Console.WriteLine($"Стартовый индекс подстроки: {start};\n" +
            $"Количество символов для новой подстроки: {count}\n" +
            $"Результат: {res}");
        Console.ReadKey();
    }
}