/*
 Напишите программу с классом, в котором есть текстовый массив. Опишите в классе одномерный и двумерный индексаторы.
 Одномерный индексатор позволяет прочитать элемент текстового массива и присвоить новое значение элементу текстового массива.
 Двумерный индексатор позволяет прочитать символ в элементе текстового массива (первый индекс определяет элемент в текстовом массиве,
 а второй индекс определяет символ в тексте). Предусмотрите циклическую перестановку индексов в случае, если они выходят за верхнюю допустимую границу.
 */
using System;
class MyClass
{
    private string[] txts;
    public MyClass(params string[] args)
    {
        txts = new string[args.Length];
        for (int i = 0; i < txts.Length; i++)
        {
            txts[i] = args[i];
        }
    }
    public string this[int n]
    {
        get
        {
            return txts[n];
        }
        set
        {
            txts[n] = value;
        }
    }
    public string this[int a, int b]
    {
        get
        {
            string t = txts[a];
            string res = "" + t[b];
            return res;
        }
    }
    public override string ToString()
    {
        string txt = "";
        for (int i = 0; i < txts.Length; i++)
        {
            txt += txts[i] + " ";
        }
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("Ohayo", "Sekai", "Good", "Morning", "World");
        Console.WriteLine(A);
        Console.WriteLine(A[1]);
        A[1] = "Yo";
        Console.WriteLine(A[1]);
        Console.WriteLine(A[1, 0]);
        Console.ReadKey();
    }
}