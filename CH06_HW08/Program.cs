/*
 Напишите программу с классом, в котором есть закрытое статическое целочисленное поле
 с начальным нулевым значением. В классе должен быть описан статический метод, при вызове
 которого отображается текущее значение статического поля, после чего значение поля увеличивается на единицу.
 */
using System;

class StaticClass
{
    private static int num = 0;
    public static void show()
    {
        Console.WriteLine(num);
        num++;
    }
}

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            StaticClass.show();
        }
        Console.ReadKey();
    }
}