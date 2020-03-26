/*
 Напишите программу, в которой использована цепочка наследования из трех классов. В первом классе есть открытое символьное поле.
 Во втором классе появляется открытое текстовое поле. В третьем классе появляется открытое целочисленное поле. В каждом из классов должен быть конструктор, 
 позволяющий создавать объект на основе значений полей, переданных аргументами конструктору, а также конструктор создания копий
 */
using System;
class Base
{
    public char symb;
    public Base() { }
    public Base(char symb)
    {
        this.symb = symb;
    }
    public Base(Base obj)
    {
        this.symb = obj.symb;
    }
}
class SubBase : Base
{
    public string txt;
    public SubBase() { }
    public SubBase(char symb, string txt) : base(symb)
    {
        this.txt = txt;
    }
    public SubBase(SubBase obj)
    {
        this.symb = obj.symb;
        this.txt = obj.txt;
    }
}
class SubSubBase : SubBase
{
    public int num;
    public SubSubBase(char symb, string txt, int num) : base(symb, txt)
    {
        this.num = num;
    }
    public SubSubBase(SubSubBase obj)
    {
        this.symb = obj.symb;
        this.txt = obj.txt;
        this.num = obj.num;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base('h');
        Console.WriteLine(A.symb);
        SubBase B = new SubBase('H', "Yoshi!");
        Console.WriteLine(B.symb + " " + B.txt);
        SubSubBase C = new SubSubBase('F', "YOYOY", 52);
        Console.WriteLine(C.symb + " " + C.txt + " " + C.num);

        Base A2 = new Base(A);
        Console.WriteLine(A2.symb);
        SubBase B2 = new SubBase(B);
        Console.WriteLine(B2.symb + " " + B2.txt);
        SubSubBase C2 = new SubSubBase(C);
        Console.WriteLine(C2.symb + " " + C2.txt + " " + C2.num);
        Console.ReadKey();
    }
}