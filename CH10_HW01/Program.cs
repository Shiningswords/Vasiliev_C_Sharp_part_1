/*
 напишите программу, в которой есть базовый класс с защищенным текстовым  полем, конструктором с текстовым аргументом и где
 переопределен метод ToString(). На основе базового класса путем наследования создается производный класс.
 У него появляется ещё одно защищенное текстовое поле. Также производный класс должен иметь версии конструктора с одним и двумя
 текстовыми аргументами, а ещё а ещё в нём должен быть переопределен метод ToString(). В обоих классах метод ToString() 
 переопределяется так, что он возвращает строку с названием класса и значение текстового поля или текстовых полей.
 */
using System;
class Base
{
    protected string text;
    public Base(string text)
    {
        this.text = text;
    }
    public override string ToString()
    {
        string tmp = "Класс Base и его текстовое поле: " + this.text;
        return tmp;
    }
}
class myClass : Base
{
    protected string text2;
    public myClass(string text) : base(text)
    {
        text2 = text;
    }
    public myClass(string text, string text2) : base(text)
    {
        this.text2 = text2;
    }
    public override string ToString()
    {
        string tmp = $"Класс MyClass и его поля: {text} и {text2}";
        return tmp;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("Yo Yo!");
        Console.WriteLine(A);
        myClass B = new myClass("Yo Yo");
        Console.WriteLine(B);
        myClass C = new myClass("Yo Yo", "Yoshi Yoshi");
        Console.WriteLine(C);
        Console.ReadKey();
    }
}