/*
 Напишите программу со статическим методом для сравнения текстовых строк.
 Строки на предмет совпадения сравниваются посимвольно. Правило сравнения такое:
 два символа считаются одинаковыми, если их коды отличаются не больше чем на единицу.
 Текстовые строки совпадают, если у них совпадают символы (в указанном выше смысле)
 */
using System;
class Program
{
    static bool Compare(string txt1, string txt2)
    {
        if (txt1.Length != txt2.Length) return false;
        else
        {
            for (int i = 0; i < txt1.Length; i++)
            {
                if (((int)txt1[i] > (int)txt2[i]))
                {
                    if (((int)txt1[i] - (int)txt2[i]) > 1 || ((int)txt1[i] - (int)txt2[i]) < -1) return false;
                    else continue;
                }
                else
                {
                    if (((int)txt2[i] - (int)txt1[i]) > 1 || ((int)txt2[i] - (int)txt1[i]) < -1) return false;
                    else continue;
                }
            }
            return true;
        }
    }
    static void Main(string[] args)
    {
        string txt1 = "текст1", txt2 = "текст2", txt3 = "текст3", txt4 = "текст4";
        Console.WriteLine(txt1 + " и " + txt2 + " = " + Compare(txt1, txt2));
        Console.WriteLine(txt2 + " и " + txt3 + " = " + Compare(txt2, txt3));
        Console.WriteLine(txt4 + " и " + txt1 + " = " + Compare(txt4, txt1));
        Console.WriteLine(txt3 + " и " + txt2 + " = " + Compare(txt3, txt2));
        Console.ReadKey();
    }
}