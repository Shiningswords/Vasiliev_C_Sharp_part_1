/*
 Напишите программу со статическим методом, которому передается текст и произвольное количество символьных аргументов
 Результатом возвращается текст, который получается добавлением в конец исходного текста (первый аргумент метода)
 символьных значений, переданных аргументами значений.
 */
using System;

class Program
{
    static string TxtMtd(string txt, params char[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            txt += arr[i];
        }
        return txt;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(TxtMtd("Text", ' ', 'Y', 'e', 'a', 'h', '!'));
        Console.ReadKey();
    }
}