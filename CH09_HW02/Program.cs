/*
Напишите программу, в которой есть класс с целочисленным массивом и целочисленным свойством.
При считывании значения свойства оно последовательно и циклически возвращает значения элементов массива.
При присваивании значения свойству изменяется значение того элемента, который в данный момент 
интерпретируется как значение свойства.
 */
using System;
class MyClass
{
    private int[] nums;
    public MyClass(int size)
    {
        nums = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(10);
        }
    }
    private int num = 0;
    private int index = 0;
    public int Prop
    {
        get
        {
            num = nums[index];
            index++;
            if (index > nums.Length - 1) index = 0;
            return num;
        }
        set
        {
            nums[index] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(3);
        Console.Write(A.Prop + " ");
        Console.Write(A.Prop + " ");
        Console.WriteLine(A.Prop);
        A.Prop = 50;
        Console.Write(A.Prop + " ");
        A.Prop = 100;
        Console.Write(A.Prop + " ");
        A.Prop = 150;
        Console.WriteLine(A.Prop);
        Console.ReadKey();
    }
}