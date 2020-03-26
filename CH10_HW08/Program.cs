/*
 Напишите программу, в которой есть базовый класс с открытым целочисленным полем. В классе описан виртуальный индексатор, позволяющий
 считывать цифры в десятичном представлении числа (значение поля). На основе базового класса создается производный класс, в котором появляется
 еще одно открытое целочисленное поле. В производном классе описывается версия индексатора с двумя индексами: первый индекс определяет поле, значение которого используется, 
 а второй индекс определяет разряд, для которого считывается цифра. Индексатор с одним индексом переопределяется так, что вычисления (считывание цифры в десятичном представлении
 числа) производится на основе значения, равного сумме значений полей индексируемого объекта.
 */
using System;
class Base
{
    public int num;
    public Base(int num)
    {
        this.num = num;
    }
    public virtual int this[int n]
    {
        get
        {
            int tmp = this.num;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res = tmp % 10;
                tmp /= 10;
            }
            return res;
        }
    }
}
class SubBase : Base
{
    public int num2;
    public SubBase(int num, int num2) : base(num)
    {
        this.num2 = num2;
    }
    public int this[int n, int n2]
    {
        get
        {
            if (n <= 0)
            {
                int tmp = this.num;
                int res = 0;
                for (int i = 0; i < n2; i++)
                {
                    res = tmp % 10;
                    tmp /= 10;
                }
                return res;
            }
            else
            {
                int tmp = this.num2;
                int res = 0;
                for (int i = 0; i < n2; i++)
                {
                    res = tmp % 10;
                    tmp /= 10;
                }
                return res;
            }
        }
    }
    public override int this[int n]
    {
        get
        {
            int tmp = this.num + this.num2;
            int res = 0;
            for (int i = 0; i < n; i++)
            {
                res = tmp % 10;
                tmp /= 10;
            }
            return res;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Base A = new Base(1234);
        Console.WriteLine(A[2]);
        SubBase B = new SubBase(1234, 4321);
        Console.WriteLine(B[0, 1] + " " + B[1, 1]);
        Console.WriteLine(B[1]);
        Console.ReadKey();
    }
}
