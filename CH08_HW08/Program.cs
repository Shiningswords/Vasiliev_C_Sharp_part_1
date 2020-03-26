/*
 Напишите программу, в которой есть класс с полем, являющимся ссылкой на целочисленный массив. Опишите в классе
 операторные методы для приведения типов. Необходимо реализовать следующие правила приведения типов.
 При преобразовании объекта в текст возвращается текстовая строка со значениями элементов массива.
 При преобразовании объекта в число возвращается сумма элементов массива. При преобразовании числа в объект
 результатом является новый объект, размер массива в котором определяется преобразуемым числом.
 Массив в объекте должен быть заполнен нулями.
 */
using System;
class MyClass
{
    public int[] nums;
    public MyClass(int[] nums)
    {
        this.nums = nums;
    }
    public static explicit operator string(MyClass A)
    {
        string txt = "";
        for (int i = 0; i < A.nums.Length; i++)
        {
            txt += A.nums[i] + " ";
        }
        return txt;
    }
    public static explicit operator int(MyClass A)
    {
        int sum = 0;
        for (int i = 0; i < A.nums.Length; i++)
        {
            sum += A.nums[i];
        }
        return sum;
    }
    public static explicit operator MyClass(int num)
    {
        int[] arr = new int[num];

        return new MyClass(arr);
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 5, 3, 6, 8, 4 };
        MyClass A = new MyClass(arr);
        Console.WriteLine((string)A);
        Console.WriteLine((int)A);
        MyClass B = (MyClass)8;
        Console.WriteLine((string)B);
        Console.ReadKey();
    }
}