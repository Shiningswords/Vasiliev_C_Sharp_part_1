/*
 Напишите программу, в которой есть класс с символьным свойством. Опишите аксессоры так,
 чтобы значение свойства попадало в диапазон символов от 'A' до 'Z' включительно.
 */
using System;
class MyClass
{
    private char symb;
    public char symbProp
    {
        get
        {
            return this.symb;
        }
        set
        {
            if (value >= 'A' && value <= 'Z') this.symb = value;
            else Console.WriteLine("Вне диапазона!");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        A.symbProp = 'A';
        Console.WriteLine(A.symbProp);
        A.symbProp = 'а';
        A.symbProp = '0';
        A.symbProp = 'H';
        Console.WriteLine(A.symbProp);
        Console.ReadKey();
    }
}