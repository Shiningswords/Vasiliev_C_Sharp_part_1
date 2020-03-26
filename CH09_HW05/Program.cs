/*
 Напишите программу, в которой есть класс со статическим свойством. При считывании значения свойства
 возвращается нечетное число, каждый раз новое: при первом считывании свойства получаем значение 1,
 затем 3, затем 5 и так далее. При присваивании значения свойству определяется порядковый номер числа в последовательности нечетных чисел, начиная
 с которого будут возвращаться числа. Например, если присвоить свойству значение 5, то при считывании значения свойства получаем 9 (пятое по порядку
 нечетное число), затем число 11, затем 13 и т.д.
 */
using System;
class MyClass
{
    private static int num = -1;
    private static int index = -1;

    public static int Prop
    {
        get
        {
            num += 2;
            index++;
            return num;
        }
        set
        {
            index = value;
            num = -1;
            for (int i = 0; i < index - 1; i++)
            {
                num += 2;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        Console.WriteLine(MyClass.Prop);
        Console.WriteLine(MyClass.Prop);
        Console.WriteLine(MyClass.Prop);

        MyClass.Prop = 5;
        Console.WriteLine(MyClass.Prop);
        Console.WriteLine(MyClass.Prop);
        Console.WriteLine(MyClass.Prop);
        Console.ReadKey();
    }
}