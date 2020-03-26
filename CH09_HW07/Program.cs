/*
 Напишите программу с классом, в котором есть неотрицательное целочисленное поле.
 Опишите для класса индексатор (с одним get-аксессором) такой, что при индексировании объекта с
 целочисленным индексом результатом возвращается значение бита в бинарном представлении числа (значение целочисленного поля)
 */
using System;
class MyClass
{
    private uint num;
    public MyClass(uint n)
    {
        num = n;
    }

    public string this[int n]
    {
        get
        {
            string txt = "";
            string tmp = "";
            uint num2 = num;
            while (num2 > 0)
            {
                txt += num2 % 2;
                num2 /= 2;
            }
            for (int i = txt.Length - 1; i >= 0; i--)
            {
                tmp += txt[i];
            }
            return tmp;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(244);
        Console.WriteLine(A[2]);
        Console.ReadKey();
    }
}