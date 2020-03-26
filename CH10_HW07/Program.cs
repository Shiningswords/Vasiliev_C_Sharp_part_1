/*
 Напишите программу, в которой есть базовый класс с открытым текстовым полем. На его основе создается производный класс с
 дополнительным открытым символьным полем. Опишите в базовом классе виртуальный метод, который при вызове создает и возвращает
 результатом объект производного класса. Переопределите в производном классе этот метод так, чтобы он создавал и возвращал копию объекта, из которого вызывается.
 */
using System;
class Base
{
    public string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public virtual SubBase Make()
    {
        SubBase tmp = new SubBase("Default", 'A');
        return tmp;
    }
}
class SubBase : Base
{
    public char symb;
    public SubBase(string txt, char symb) : base(txt)
    {
        this.symb = symb;
    }
    public override SubBase Make()
    {
        SubBase tmp = new SubBase(this.txt, this.symb);
        return tmp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("First");
        SubBase B = A.Make();
        Console.WriteLine(B.txt + "|" + B.symb);
        SubBase C = B.Make();
        Console.WriteLine(C.txt + "|" + C.symb);
        Console.ReadKey();
    }
}