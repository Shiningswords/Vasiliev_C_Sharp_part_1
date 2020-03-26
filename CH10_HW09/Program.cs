/*
 напишите программу, в которой есть базовый класс с защищенным текстовым полем. В классе имеется виртуальное текстовое свойство,
 возвращающее значением текст из текстового поля. При присваивании значения свойству значение присваивается текстовому полю.
 В классе переопределен метод ToString(): он возвращает текстовую строку с названием класса и значением текстового поля.
 На основе базового класса создается производный класс, у которого появляется ещё одно текстовое поле. Свойство переопределяется так,
 что значением возвращается текст, получающийся объединением (через пробел) значений текстовых полей объекта. При присваивании
 значения свойству присваиваемая текстовая строка разбивается на две, которые присваиваются полям объекта. Разделителем для
 разбивки строки на две подстроки является пробел (первый с начала строки). Если пробела нет, то первая подстрока совпадает с исходной строкой,
 а вторая подстрока пустая. Метод ToString() для производного класса нужно переопределить таким образом, чтобы он возвращал название класса и
 значения полей.
 */
using System;
class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public virtual string TEXT
    {
        get
        {
            return this.txt;
        }
        set
        {
            this.txt = value;
        }
    }
    public override string ToString()
    {
        string tmp = $"Класс Base с полем: {this.txt}";
        return tmp;
    }
}
class SubBase : Base
{
    protected string txt2;
    public SubBase(string txt, string txt2) : base(txt)
    {
        this.txt2 = txt2;
    }
    public override string TEXT
    {
        get
        {
            string tmp = this.txt + " " + this.txt2;
            return tmp;
        }
        set
        {
            if (value.Contains(" "))
            {
                string[] txts = value.Split(' ');
                this.txt = txts[0];
                this.txt2 = txts[1];
            }
            else
            {
                this.txt = value;
                this.txt2 = "";
            }
        }
    }
    public override string ToString()
    {
        string t = $"Класс SubBase и его поля: {this.txt} и {this.txt2}";
        return t;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("Hello!");
        Console.WriteLine(A);
        A.TEXT = "Ohayo!";
        Console.WriteLine(A.TEXT);
        Console.WriteLine(A);

        SubBase B = new SubBase("Arigato", "gozaimasu");
        Console.WriteLine(B);
        Console.WriteLine(B.TEXT);
        B.TEXT = "Good boi";
        Console.WriteLine(B.TEXT);
        Console.ReadKey();
    }
}