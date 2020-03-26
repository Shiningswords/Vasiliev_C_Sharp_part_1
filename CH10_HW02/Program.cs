/*
 Напишите программу, в которой есть базовый класс с защищенным текстовым полем. В базовом классе должен быть метод
 для присваивания значения полю: без аргументов и с одним текстовым аргументом. Объект базового класса создается передачей одного текстового аргумента конструктору.
 Доступное только для чтения свойство результатом возвращает длину текстовой строки. Доступный только для чтения индексатор возвращает значением символ из текстовой строки.
 На основе базового класса создается производный класс. В производном классе появляется дополнительное открытое целочисленное поле. В классе должны быть такие версии метода
 для присваивания значений полям (используется переопределение и перегрузка метода из базового класса): без аргументов, с текстовым аргументом, с целочисленным аргументом,
 с текстовым и целочисленными аргументом. У конструктора производного класса 2 аргумента.
 */
using System;
class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public virtual void set()
    {
        this.txt = "Default";
    }
    public virtual void set(string txt)
    {
        this.txt = txt;
    }
    public int length
    {
        get
        {
            return txt.Length;
        }
    }
    public char this[int n]
    {
        get
        {
            if (n >= 0 && n < txt.Length) return txt[n];
            else return '!';
        }
    }
    public override string ToString()
    {
        string tmp = "Класс Base и поле : " + this.txt;
        return tmp;
    }
}
class MyClass : Base
{
    public int num;
    public MyClass(int num, string txt) : base(txt)
    {
        this.num = num;
    }
    public override void set()
    {
        this.txt = "Default2";
        this.num = 0;
    }
    public override void set(string txt)
    {
        this.txt = txt;
        this.num = 0;
    }
    public void set(int num)
    {
        this.txt = "Default3";
        this.num = num;
    }
    public void set(int num, string txt)
    {
        this.txt = txt;
        this.num = num;
    }
    public override string ToString()
    {
        string tmp = "Класс MyClass и поля : " + this.txt + " & " + this.num;
        return tmp;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("YoYO!");
        Console.WriteLine(A);
        A.set();
        Console.WriteLine(A);
        A.set("Whoa!");
        Console.WriteLine(A);
        Console.WriteLine(A.length);
        Console.WriteLine(A[1]);
        MyClass B = new MyClass(7, "Excuse me what the?!");
        Console.WriteLine(B);
        B.set();
        Console.WriteLine(B);
        B.set(999999);
        Console.WriteLine(B);
        B.set("Look at my cat!");
        Console.WriteLine(B);
        B.set(98, "98@");
        Console.WriteLine(B);

        Console.ReadKey();
    }
}