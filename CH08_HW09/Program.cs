/*
 Напишите программу, в которой есть класс с целочисленным полем и перегрузкой операторов +, - и *.
 Предложите такой способ перегрузки этих операторов, чтобы с объектами класса можно было использовать операторы +=, -+ и *=.
 */
using System;

class MyClass
{
    public int num;
    public MyClass(int num)
    {
        this.num = num;
    }
    public static MyClass operator +(MyClass a, MyClass b)
    {
        return new MyClass(a.num + b.num);
    }
    public static MyClass operator -(MyClass a, MyClass b)
    {
        return new MyClass(a.num - b.num);
    }
    public static MyClass operator *(MyClass a, MyClass b)
    {
        return new MyClass(a.num * b.num);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(7);
        MyClass B = new MyClass(9);
        A += B;
        Console.WriteLine(A.num);
        A -= B;
        Console.WriteLine(A.num);
        A *= B;
        Console.WriteLine(A.num);
        Console.ReadKey();
    }
}