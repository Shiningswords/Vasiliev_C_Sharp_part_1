/*
 Напишите программу с классом, у которого есть два целочисленных поля.
 В классе должны быть описаны конструкторы, позволяющие создавать объекты без передачи
 аргументов, с передачей аргумента и с передачей двух аргументов.
 */
using System;
class Nums
{
    public int num1;
    public int num2;
    public Nums()
    {
        num1 = 1;
        num2 = 2;
    }
    public Nums(int num1)
    {
        this.num1 = num1;
        num2 = 2;
    }
    public Nums(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public void show()
    {
        Console.WriteLine("1: " + num1 + " 2: " + num2);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Nums A = new Nums();
        A.show();
        Nums B = new Nums(10);
        B.show();
        Nums C = new Nums(22, 33);
        C.show();
        Console.ReadKey();
    }
}

