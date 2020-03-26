/*
 Напишите программу с классом, у которого есть текстовое поле. Значение текстовому полю
 присваивается при создании объекта класса. Также в классе должен быть метод, позволяющий вставить
 подстроку в текст из текстового поля. Аргументами методу передается подстрока для вставки в текст,
 а также индекс позиции, начиная с которой выполняется вставка. переопределить в классе метод ToString()
 так, чтобы он возвращал значением текст из текстового поля.
 */
using System;
class MyClass
{
    public string txt;
    public MyClass(string txt)
    {
        this.txt = txt;
    }

    public void MyInsert(string txt, int start)
    {
        this.txt = this.txt.Insert(start, txt);
    }

    public override string ToString()
    {
        return this.txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("Вставить сюда-><-");
        Console.WriteLine(A.txt);
        A.MyInsert("Вставил!", 15);
        Console.WriteLine(A.ToString());
        Console.ReadKey();
    }
}