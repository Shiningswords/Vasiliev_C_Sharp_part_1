/*
 Напишите программу, в которой есть класс с закрытым неотрицательным целочисленным полем.
 Также в классе должно быть закрытое текстовое поле, содержащее значением восьмеричный код числа из целочисленного поля.
 Опишите в классе свойство, доступное только для присваивания значения. При присваивании неотрицательного целочисленного значения
 свойству соответствующее число записывается в целочисленное поле, а в текстовое поле заносится восьмеричный код числа.
 Опишите ещё одно свойство, доступное только для чтения, которое результатом возвращает текст из текстового поля (восьмеричный код числа).
 */
using System;
class MyClass
{
    private uint num;
    private string txt;
    public uint Prop
    {
        set
        {
            num = value;
            uint n = value;
            string t = "" + n;
            string tmp = "";
            string res = "";
            for (int i = 0; i < t.Length; i++)
            {
                tmp += n % 8;
                n /= 8;
            }
            for (int i = t.Length - 1; i >= 0; i--)
            {
                res += tmp[i];
            }
            this.txt = res;
        }
    }
    public string Prop2
    {
        get
        {
            return txt;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        A.Prop = 145;
        Console.WriteLine(A.Prop2);
        Console.ReadKey();
    }
}