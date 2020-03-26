/*
 Напишите программу, в которой есть класс с целочисленным массивом и с индексатором. при считывании значения выражения
 с проиндексированным объектом результатом возвращается значение элемента массива. При присваивании значения выражению
 с проиндексированным объектом значение присваивается элементу массива. Необходимо описать индексатор так, чтобы при
 индексировании объекта первый индекс отличался от нуля. Числовые значения, определяющие диапазон изменения индекса (и,
 соответственно, размер целочисленного массива) при индексировании объекта, передаются аргументами конструктору класса.
 */
using System;
class MyClass
{
    private int[] nums;
    public MyClass(int size)
    {
        nums = new int[size];
    }
    public override string ToString()
    {
        string txt = "";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += nums[i] + " ";
        }
        txt += "\n";
        return txt;
    }
    public int this[int n]
    {
        get
        {
            return nums[n];
        }
        set
        {
            if (n >= 1 && n < nums.Length) nums[n] = value;
            else Console.WriteLine("Вне диапазона массива!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(5);
        Console.WriteLine(A);
        A[1] = 23;
        Console.WriteLine(A);
        A[0] = 6;
        A[4] = 76;
        Console.WriteLine(A);
        Console.WriteLine(A[4]);
        Console.ReadKey();
    }
}