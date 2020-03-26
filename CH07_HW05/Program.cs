/*
 Напишите программу со статическим методом, определяющим позиции, на которых в тексте находится
 определенный символ. Аргументами методу передаются текст и символ.  Результатом метод возвращает
 целочисленный массив, значения элементов которого - это индексы позиций, на которых символ (второй аргумент)
 находится в тексте (первый аргумент). Если символ в тексте не встречается, то метод результатом возвращает
 массив из одного элемента, значение которого равно -1.
 */
using System;
class Program
{
    static int[] IndexOf(string txt, char symb)
    {
        if (txt.Contains(symb.ToString()))
        {
            string arrtxt = "";
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == symb) arrtxt += i.ToString() + " ";
            }
            arrtxt = arrtxt.Trim();
            string[] arr = arrtxt.Split();
            int[] arrInt = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrInt[i] = Int32.Parse(arr[i]);
            }
            return arrInt;
        }
        else
        {
            int[] arrInt = new int[1];
            arrInt[0] = -1;
            return arrInt;
        }
    }
    static void Main(string[] args)
    {
        int[] arr = IndexOf("bbbbababababbbbabababababba", 'a');
        Console.WriteLine("Индексы символа \'а\' в строке \"bbbbababababbbbabababababba\":");
        foreach (int i in arr)
        {
            Console.Write(i + " ");
        }
        Console.ReadKey();
    }
}