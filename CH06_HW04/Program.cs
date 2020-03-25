/*
 Напишите программу с классом, у которого есть символьное и целочисленное поле.
 В классе должны быть описаны версии конструктора с двумя аргументами (целое число и символ - определяют
 значения полей), а также с одним аргументом типа double. В последнем случае действительная часть
 аргумента определяет код символа(значение символьного поля), а дробная часть (с учетом десятых и сотых)
 определяет значение целочисленного поля. Например, если аргументом передается число 65.1267, то значением
 символьного поля будет символ 'A' с кодом 65, а целочисленное поле получит значение 12 (в дробной части
 учитываются только десятые и сотые)
 */
using System;
class MyClass
{
    public int num;
    public char symb;
    public MyClass(int num, char symb)
    {
        this.num = num;
        this.symb = symb;
    }
    public MyClass(double num)
    {
        this.symb = (char)(int)num;
        num = num - (int)this.symb;
        this.num = ((int)Math.Floor((num * 100)));
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(12, 'A');
        Console.WriteLine(A.symb + " " + A.num);

        MyClass B = new MyClass(65.1688);
        Console.WriteLine(B.symb + " " + B.num);

        Console.ReadKey();
    }
}
