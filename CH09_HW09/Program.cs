/*
 Напишите программу с классом, в котором есть двумерный числовой массив. Опишите два индексатора для класса.
 Двумерный индексатор с двумя целочисленными индексами позволяет прочитать и изменить значения элемента в двумерном массиве, 
 а индексатор с одним целочисленным индексом возвращает результатом значение наибольшего элемента в строке двумерного массива.
 Присваивание значения выражению на основе объекта с одним индексом означает присваивание значения тому элементу в строке,
 который на данный момент имеет наибольшее значение. Строка определяется индексом, указанным при индексировании объекта.
 Если в строке несколько элементов с наибольшим значением, то используется первый такой элемент.
 */
using System;
class MyClass
{
    private int[,] nums;
    public MyClass(int col, int str)
    {
        nums = new int[col, str];
    }
    public override string ToString()
    {
        string txt = "";
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                txt += nums[i, j] + " ";
            }
            txt += "\n";
        }
        return txt;
    }
    public int this[int a, int b]
    {
        get
        {
            return nums[a, b];
        }
        set
        {
            nums[a, b] = value;
        }
    }
    public int this[int a]
    {
        get
        {
            int n = nums[a, 0];
            for (int i = 0; i < nums.GetLength(1); i++)
            {
                if (nums[a, i] > n) n = nums[a, i];
            }
            return n;
        }
        set
        {
            int max = nums[a, 0];
            int index = 0;
            for (int i = 0; i < nums.GetLength(1); i++)
            {
                if (nums[a, i] > max)
                {
                    max = nums[a, i];
                    index = i;
                }
            }
            nums[a, index] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(4, 3);
        Console.WriteLine(A);
        A[1, 1] = 5;
        Console.WriteLine(A[1, 1]);
        Console.WriteLine(A);
        Console.WriteLine(A[1]);
        A[1] = 9;
        Console.WriteLine(A);
        Console.ReadKey();
    }
}