/*
 Напишите программу с классом, у которого есть два символьных поля и метод.
 Он не возвращает результат, и у него нет аргументов. При вызове метод выводит
 в конс. окно все символы из кодовой таблицы, которые находятся "между" символами,
 являющимися значениями полей объекта (из которого вызывается метод). Например,
 если полям объекта присвоены значения 'A' и 'D', то при вызове метода в консольное окно
 должны выводиться все символы от 'A' до 'D' включительно.
 */
using System;

class Symbs
{
    public char symb1;
    public char symb2;
    public Symbs(char symb1, char symb2)
    {
        this.symb1 = symb1;
        this.symb2 = symb2;
    }
    public void show()
    {
        for (int i = (int)symb1; i <= (int)symb2; i++)
        {
            Console.Write((char)i + " ");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Symbs A = new Symbs('A', 'Z');
        A.show();
        Console.ReadKey();
    }
}
