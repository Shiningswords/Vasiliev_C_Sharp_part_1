/*
 Напишите программу, в которой есть класс с целочисленным полем. Перегрузите операторы &, |, true и false так,
 чтобы с объектами класса можно было использовать операторы && и ||. Перегрузку следует реализовать так,
 чтобы объект считался "истинным", если значение его числового поля равно 2, 3, 5 или 7. Объект должен рассматриваться как
 "ложный", если значение его числового поля меньше 1 или больше 10.
 */
using System;

class MyClass
{
    public int num;
    public MyClass(int num)
    {
        this.num = num;
    }
    public static bool operator true(MyClass obj)
    {
        switch (obj.num)
        {
            case 2:
            case 3:
            case 5:
            case 7:
                return true;
            default:
                return false;
        }
    }
    public static bool operator false(MyClass obj)
    {
        if (obj) return obj.num == 7;
        else return true;
    }
    public static MyClass operator &(MyClass a, MyClass b)
    {
        if (a) return b;
        else return a;
    }
    public static MyClass operator |(MyClass a, MyClass b)
    {
        if (a) return b;
        else return a;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(5);
        MyClass B = new MyClass(77);
        if (A && B)
            Console.WriteLine("Yeah!");
        else
            Console.WriteLine("Nope!");
        if (A || B)
            Console.WriteLine("Yeah!");
        else
            Console.WriteLine("Nope!");
        Console.ReadKey();
    }
}