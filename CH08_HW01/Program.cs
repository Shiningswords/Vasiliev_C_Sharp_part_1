/*
 Напишите программу, в которой есть класс с символьным полем и следующими перегруженными операторами:
 оператором инкремента ++ и декремента --, бинарным оператором "плюс" + и бинарным оператором "минус"-.
 Правила перегрузки операторов такие. Применение оператора инкремента к объекту приводит к тому, что
 поле значением получает следующий (по отношению к текущему значению) символ в кодовой таблице.
 Применение оператора декремента приводит к тому, что поле получает значением предыдущий (по отношению к текущему) символ в кодовой таблице.
 Значением выражения на основе оператора инкремента/декремента является ссылка на объект-операнд.
 Бинарный оператор "плюс" можно применять для вычисления суммы объекта и целого числа, а также суммы целого числа и объекта.
 В обоих случаях результатом возвращается новый объект, значение символьного поля которого определяется прибавлением целого числа (один из операндов)
 к коду символа из объекта-операнда. С помощью бинарного оператора "минус" можно вычислять разность двух объектов.
 Результатом является целое число - разность кодов символов из объектов-операндов.
 */
using System;
class MyClass
{
    public char symb;
    public MyClass(char symb)
    {
        this.symb = symb;
    }
    public static MyClass operator ++(MyClass a)
    {
        MyClass t = new MyClass((char)((int)a.symb + 1));
        return t;
    }
    public static MyClass operator --(MyClass a)
    {
        MyClass t = new MyClass((char)((int)a.symb - 1));
        return t;
    }
    public static MyClass operator +(MyClass a, int n)
    {
        int temp = (int)a.symb + n;
        MyClass t = new MyClass((char)temp);
        return t;
    }
    public static MyClass operator +(int n, MyClass a)
    {
        int temp = (int)a.symb + n;
        MyClass t = new MyClass((char)temp);
        return t;
    }
    public static int operator -(MyClass a, MyClass b)
    {
        int res = a.symb - b.symb;
        return res;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass('A');
        Console.WriteLine(A.symb);
        A = ++A;
        Console.WriteLine(A.symb);
        A = --A;
        Console.WriteLine(A.symb);
        A = A + 11;
        Console.WriteLine(A.symb);
        MyClass B = 11 + A;
        Console.WriteLine(B.symb);
        int num = B - A;
        Console.WriteLine(num);
        Console.ReadKey();
    }
}