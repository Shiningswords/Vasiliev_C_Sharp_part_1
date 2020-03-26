/*
 Напишите программу, в которой есть класс с целочисленным полем и текстовым полем. Выполните перегрузку всех
 операторов сравнения. Сравнение на предмет "больше" или "меньше" выполняется на основе сравнения длины текстовых значений
 (имеются ввиду текстовые поля сравниваемых объектов). При сравнении на предмет "больше или равно" или "меньше или равно"
 сравниваются значения целочисленных полей объектов. При сравнении на предмет "равно" или "не равно" сравниваются и
 целочисленные, и текстовые поля объектов. Также предложите способ переопределения методов Equals() и GetHashCode().
 */
using System;

class MyClass
{
    public int num;
    public string txt;
    public MyClass(int num, string txt)
    {
        this.num = num;
        this.txt = txt;
    }
    public static bool operator >(MyClass a, MyClass b)
    {
        if (a.txt.Length > b.txt.Length && a.txt.Length != b.txt.Length) return true;
        else return false;
    }
    public static bool operator <(MyClass a, MyClass b)
    {
        if (!(a > b) && a.txt.Length != b.txt.Length) return true;
        else return false;
    }
    public static bool operator >=(MyClass a, MyClass b)
    {
        if (a.num > b.num || a.num == b.num) return true;
        else return false;
    }
    public static bool operator <=(MyClass a, MyClass b)
    {
        if (a.num < b.num || a.num == b.num) return true;
        else return false;
    }
    public static bool operator ==(MyClass a, MyClass b)
    {
        if (a.num == b.num && a.txt == b.txt) return true;
        else return false;
    }
    public static bool operator !=(MyClass a, MyClass b)
    {
        if (!(a == b)) return true;
        else return false;
    }
    public override int GetHashCode()
    {
        return (num >> 2) + txt.Length;
    }
    public override bool Equals(Object obj)
    {
        MyClass t = (MyClass)obj;
        if (num == t.num && txt == t.txt) return true;
        else return false;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(1, "one");
        MyClass B = new MyClass(3, "three");
        MyClass C = new MyClass(1, "one");

        Console.WriteLine(A > B);
        Console.WriteLine(A < B);
        Console.WriteLine();

        Console.WriteLine(A >= B);
        Console.WriteLine(A <= B);
        Console.WriteLine();

        Console.WriteLine(A == B);
        Console.WriteLine(A != B);
        Console.WriteLine(A == C);
        Console.WriteLine(A != C);
        Console.WriteLine();

        Console.WriteLine(A.GetHashCode());
        Console.WriteLine(A.Equals(C));
        Console.ReadKey();
    }
}
