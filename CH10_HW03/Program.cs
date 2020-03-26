/*
 Напишите программу, в которой есть базовый класс с открытым полем, являющимся ссылкой на целочисленный массив. Конструктору класса
 при создании передается ссылка на массив, в результате чего создается копия копия этого массива и ссылка на него записывается в поле объекта.
 Метод ToString() переопределен так, что возвращает текстовую строку со значениями элементов массива. На основе базового класса создается производный класс.
 В производном классе появляется ещё одно открытое поле, являющееся ссылкой на символьный массив. Конструктору производного класса передаются две ссылки:
 на целочисленный массив и на символьный массив. В результате должны создаваться копии этих массивов, а ссылки на созданные массивы записываются в поля объекта.
 Метод ToString() должен возвращать текстовую строку с содержимым обоих массивов.
 */
using System;
class Base
{
    public int[] nums;
    public Base(int[] nums)
    {
        this.nums = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            this.nums[i] = nums[i];
        }
    }
    public override string ToString()
    {
        string txt = "|";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += nums[i] + " | ";
        }
        return txt;
    }
}
class MyClass : Base
{
    public char[] symbs;
    public MyClass(int[] nums, char[] symbs) : base(nums)
    {
        this.symbs = new char[symbs.Length];
        for (int i = 0; i < symbs.Length; i++)
        {
            this.symbs[i] = symbs[i];
        }
    }
    public override string ToString()
    {
        string txt = "|";
        for (int i = 0; i < nums.Length; i++)
        {
            txt += nums[i] + " | ";
        }
        for (int i = 0; i < symbs.Length; i++)
        {
            txt += symbs[i] + " | ";
        }
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] n = { 1, 2, 3, 3, 5, 4, 8 };
        char[] s = { 'y', 'o', 'y', 'o', 'y', 'o' };
        Base A = new Base(n);
        Console.WriteLine(A);
        MyClass B = new MyClass(n, s);
        Console.WriteLine(B);
        Console.ReadKey();
    }
}