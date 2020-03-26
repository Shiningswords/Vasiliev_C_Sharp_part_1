/*
 Напишите программу, в которой есть класс с текстовым полем. Опишите в классе операторные методы для выполнения приведения типов.
 Неоходимо определить следующие способы преобразований. При преобразовании объекта в целое число результатом возвращается количество
 символов в значении текстового поля. При преобразовании объекта в символ результатом является первый символ в тексте.
 При преобразовании числа в объект создается (и возвращается результатом соответствующего операторного метода) объект, текстовое поле которого
 содержит текстовую строку из символов 'A'. Количество символов в тексте определяется преобразуемым числом.
 */
using System;
class MyClass
{
    public string txt;
    public MyClass(string txt)
    {
        this.txt = txt;
    }
    public static explicit operator int(MyClass obj)
    {

        return obj.txt.Length;
    }
    public static explicit operator char(MyClass obj)
    {

        return obj.txt[0];
    }
    public static explicit operator MyClass(int num)
    {
        string txt = "";
        for (int i = 0; i < num; i++)
        {
            txt += "A";
        }
        return new MyClass(txt);
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass("Yeah!");
        Console.WriteLine((int)A);
        Console.WriteLine((char)A);
        MyClass B = (MyClass)7;
        Console.WriteLine(B.txt);
        Console.ReadKey();
    }
}