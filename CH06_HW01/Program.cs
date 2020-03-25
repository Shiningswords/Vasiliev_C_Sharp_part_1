/*
 Напишите программу, с классом, в котором есть закрытое символьное поле и три открытых метода.
 Один из методов позволяет присвоить значение полю. Еще один метод при вызове возвращает результатом код символа.
 Третий метод позволяет вывести в консольное окно символ (значение поля) и его код.
 */
using System;

class Symbs
{
    private char symb;
    public void set(char symb)
    {
        this.symb = symb;
    }
    public int code(char symb)
    {
        return (int)symb;
    }
    public void show()
    {
        Console.WriteLine($"Символ: {symb}, его код: {this.code(symb)}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Symbs A = new Symbs();
        A.set('Z');
        A.show();
        Console.ReadKey();
    }
}