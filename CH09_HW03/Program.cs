/*
 Напишите программу, в которой есть класс с целчисленным массивом.
 Опишите в классе свойство, доступное только для считывания значения.
 Значением свойства является сумма элементов массива.
 */
using System;
class MyClass
{
    public int[] nums;
    public MyClass(int size)
    {
        nums = new int[size];
        Random rnd = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(10);
        }
    }
    public int Sum
    {
        get
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(3);
        for (int i = 0; i < A.nums.Length; i++)
        {
            Console.Write(A.nums[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(A.Sum);
        Console.ReadKey();
    }
}