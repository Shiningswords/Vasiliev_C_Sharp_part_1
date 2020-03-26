/*
 напишите программу, в которой есть класс с символьным полем и перегрузкой операторов + и -. Операторы должны быть перегружены так,
 чтобы применение оператора + к объектам класса давало результатом текст, получающийся объединением значений символьных полей суммируемых объектов.
 При применении оператора - к объектам класса результатом должно возвращатся целое число (разность кодов символов из вычитаемых объектов).
 Предложите такие способы перегрузки операторов приведения типа, чтобы с объектами класса можно было использовать операторы += и -=.
 */
using System;
class MyClass
{
    public char symb;
    public MyClass(char symb)
    {
        this.symb = symb;
    }
    public static string operator +(MyClass a, MyClass b)
    {
        string txt = "" + a.symb + b.symb;
        return txt;
    }
    public static int operator -(MyClass a, MyClass b)
    {
        int code = a.symb - b.symb;
        return code;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass('A');
        MyClass B = new MyClass('B');
        Console.WriteLine(A + B);
        Console.WriteLine(B - A);
        Console.ReadKey();
    }
}