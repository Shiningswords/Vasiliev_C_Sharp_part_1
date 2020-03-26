/*
 напишите программу, в которой есть класс с двумя целочисленными полями. Опишите для этого класса
 операторные методы, которые позволяют сравнивать объекты класса на предмет "меньше" или "больше".
 Исходите из того, что один объект меньше/больше другого, если сумма квадратов значений его полей меньше/больше
 суммы квадратов значений его полей меньше/больше суммы квадратов значений полей другого объекта.
 */
using System;
class MyClass
{
    public int num1;
    public int num2;
    public MyClass(int num1, int num2)
    {
        this.num1 = num1;
        this.num2 = num2;
    }
    public static bool operator >(MyClass a, MyClass b)
    {
        if (((a.num1 * a.num1) + (a.num2 * a.num2) > (b.num1 * b.num1) + (b.num2 * b.num2))) return true;
        else return false;
    }
    public static bool operator <(MyClass a, MyClass b)
    {
        if (!(a > b)) return true;
        else return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(2, 2);
        MyClass B = new MyClass(3, 3);
        Console.WriteLine(A > B);
        Console.WriteLine(A < B);
        Console.ReadKey();
    }
}