/*
 напишите программу, в которой есть базовый класс с защищенным текстовым полем, конструктор с текстовым аргументом и метод, при вызове которого в консольном окне
 отображается название класса и значение поля. На основе базового класса создаются два производных класса (оба на основе одного и того же базового).
 В одном из классов появляется защищенное целочисленное поле, там есть конструктор с двумя аргументами и переопределен метод для отображения значений полей объекта и названия класса.
 Во втором производном классе появляется защищенное символьное поле, конструктор с двумя аргументами и переопределен метод, отображающий в консоли название класса и значения полей.
 В главном методе создайте объекты каждого из классов. Проверьте работу метода, отображающего значения полей объектов, для каждого из объектов. Вызовите этот же метод через 
 объектную переменную базового класса, которая ссылается на объект производного класса. 
 */
using System;
class Base
{
    protected string txt;
    public Base(string txt)
    {
        this.txt = txt;
    }
    public virtual void show()
    {
        Console.WriteLine($"Класс Base и его поле: {this.txt}");
    }
}
class SubBase1 : Base
{
    protected int num;
    public SubBase1(string txt, int num) : base(txt)
    {
        this.num = num;
    }
    public override void show()
    {
        Console.WriteLine($"Класс SubBase1 и его поля: {this.txt} и {this.num}");
    }
}
class SubBase2 : Base
{
    protected char symb;
    public SubBase2(string txt, char symb) : base(txt)
    {
        this.symb = symb;
    }
    public override void show()
    {
        Console.WriteLine($"Класс SubBase2 и его поля: {this.txt} и {this.symb}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base("First");
        A.show();

        SubBase1 B = new SubBase1("Second", 1);
        B.show();

        SubBase2 C = new SubBase2("Third", 'A');
        C.show();

        A = C;
        A.show();
        Console.ReadKey();
    }
}