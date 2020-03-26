/*
 Напишите программу, в которой есть класс с целочисленным полем и символьным полем.
 Перегрузите операторы true и false так, чтобы "истинным" считался объект, у которого разность значения
 целочисленного поля и кода символа из символьного поля не превышает величину 10.
 Используйте объект данного класса (в качестве условия в условном операторе) для того, чтобы 
 отобразить последовательность символов в консольном окне.
 */
using System;

class MyClass
{
    public int num;
    public char symb;
    public MyClass(int num, char symb)
    {
        this.num = num;
        this.symb = symb;
    }
    public static bool operator true(MyClass obj)
    {
        if (obj.num - (int)obj.symb <= 10) return true;
        else return false;
    }
    public static bool operator false(MyClass obj)
    {
        if (obj) return false;
        else return true;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(70, 'A');
        if (A)
        {
            Console.WriteLine("Pravda");
        }
        else
        {
            Console.WriteLine("NE PRAVDA");
        }
        MyClass B = new MyClass(7000, 'A');
        if (B)
        {
            Console.WriteLine(B);
        }
        else
        {
            Console.WriteLine("NE PRAVDA");
        }
        Console.ReadKey();
    }
}