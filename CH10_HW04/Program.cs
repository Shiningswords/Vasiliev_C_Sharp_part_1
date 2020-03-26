/*
 Напишите программу, в которой на основе базового класса создается производный класс, а на основе этого производного класса создается
 ещё один производный класс (цепочка наследования из трех классов). В первом базовом классе есть открытое целочисленное поле, метод с
 одним аргументом для присваивания значения полю и конструктор с одним аргументом. Во втором классе появляется открытое символьное поле,
 метод с двумя аргументами для присваивания значения полям (перегрузка метода из базового класса) и конструктор с двумя аргументами.
 В третьем классе появляется открытое текстовое поле, метод с тремя аргументами для присваивания значений полям (перегрузка метода из базового класса)
 и конструктор с тремя аргументами. Для каждого класса определите метод ToString() так, чтобы он возвращал строку с названием класса и значениями всех полей объекта.
 */
using System;
class Base
{
    public int num;
    public Base(int num)
    {
        this.num = num;
    }
    public void set(int num)
    {
        this.num = num;
    }
    public override string ToString()
    {
        string t = "| " + num + " |";
        return t;
    }
}
class SubBase : Base
{
    public char symb;
    public SubBase(int num, char symb) : base(num)
    {
        this.symb = symb;
    }
    public void set(int num, char symb)
    {
        this.num = num;
        this.symb = symb;
    }
    public override string ToString()
    {
        string t = "| " + num + " | " + symb + " |";
        return t;
    }
}
class SubSubBase : SubBase
{
    public string txt;
    public SubSubBase(int num, char symb, string txt) : base(num, symb)
    {
        this.txt = txt;
    }
    public void set(int num, char symb, string txt)
    {
        this.num = num;
        this.symb = symb;
        this.txt = txt;
    }
    public override string ToString()
    {
        string t = "| " + num + " | " + symb + " | " + txt + " |";
        return t;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base(76);
        Console.WriteLine(A);
        A.set(1);
        Console.WriteLine(A);
        SubBase B = new SubBase(8, 'j');
        Console.WriteLine(B);
        B.set(99, '!');
        SubSubBase C = new SubSubBase(100, 'A', "Yo!");
        Console.WriteLine(C);
        C.set(777, '+', "YOYOYOYOYOYO!");
        Console.WriteLine(C);
        Console.ReadKey();
    }
}