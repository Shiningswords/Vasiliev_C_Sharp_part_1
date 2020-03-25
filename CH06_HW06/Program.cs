/*
 Напишите программу с классом, в котором есть два закрытых целочисленных поля (назовем их min и max).
 Значение поля max не может быть меньше значения поля min. Значения полям присваиваются с помощью открытого метода.
 Метод может вызываться с одним или двумя целочисленными аргументами. При вызове метода значения присваиваются так:
 сравниваются текущие значения полей и значения аргумента или аргументов, переданных методу.
 Самое большое из значений присваивается полю max, а самое маленькое из значений присваивается полю min.
 Предусмотрите конструктор, который по тому же принципу, что и метод для присваивания значений полям.
 В классе также должен быть метод, отображающий в консольном окне значения полей объекта.
 */
using System;

class MinMax
{
    private int min;
    private int max;

    public void show()
    {
        Console.WriteLine($"Max: {max}, Min: {min}");
    }

    public void set(int num)
    {
        if (num > this.max)
            this.max = num;
        else if (num < this.min)
            this.min = num;
    }

    public void set(int num1, int num2)
    {
        if (num1 > this.max && num1 > num2 || num1 == num2)
        {
            this.max = num1;
            this.min = num2;
        }
        else if (num2 > this.max && num2 > num1)
        {
            this.max = num2;
            this.min = num1;
        }

        if (num1 < this.min && num1 < num2)
        {
            this.min = num1;
            this.max = num2;
        }
        else if (num2 < this.min && num2 < num1)
        {
            this.min = num2;
            this.max = num1;
        }
    }

    public MinMax() { }

    public MinMax(int num1, int num2)
    {
        if (num1 > this.max && num1 > num2 || num1 == num2)
        {
            this.max = num1;
            this.min = num2;
        }
        else if (num2 > this.max && num2 > num1)
        {
            this.max = num2;
            this.min = num1;
        }

        if (num1 < this.min && num1 < num2)
        {
            this.min = num1;
            this.max = num2;
        }
        else if (num2 < this.min && num2 < num1)
        {
            this.min = num2;
            this.max = num1;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MinMax A = new MinMax();
        A.set(25, 25);
        A.show();
        A.set(1);
        A.show();

        MinMax B = new MinMax(45, 36);
        B.show();

        Console.ReadKey();
    }
}
