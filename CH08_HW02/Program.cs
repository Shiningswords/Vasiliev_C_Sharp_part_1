/*
 Напишите программу, в которой есть класс с полем, являющимся ссылкой на одномерный целочисленный массив.
 У класса есть конструктор с одним целочисленным аргументом, определяющим размер массива.
 При создании объекта все элементы массива получают нулевые значения.
 В классе перегружаются следующие операторы. Унарный оператор ~ перегружен таким образом, что результатом
 возвращается текстовая строка со значениями элементов массива (на который ссылается поле объекта, к которому применяется оператор).
 Унарный оператор инкремента ++ перегружен так, что его применение к объекту приводит к добавлению в массив нового элемента с нулевым значением.
 Результатом возвращается ссылка на объект-операнд. При применении к объекту оператора декркмента -- из массива удаляется один элемент (напрмер, последний),
 а результатом возвращается ссылка на объект-операнд. Бинарный оператор сложения + должен быть определен так, чтобы можно было вычислять сумму двух объектов,
 объекта и числа, а также числа и объекта. Во всех случаях результатом возвращается новый объект. Если в операции учавствуют два объекта-операнда, то в объекте-результате
 массив формируется объединением массивов складываемых объектов. Если вычисляется сумма объекта и числа, то в объекте-результате массив получается добавлением
 нового элемента к массиву из объекта-операнда. Значение добавляемого элемента определяется значением числа-операнда. Если к числу прибавляется объект, то новый элемент
 добавляется в начало массива. Если к объекту прибавляется число, то новый элемент добавляется в конец массива.
 */
using System;
class MyClass
{
    int[] arr;
    public MyClass(int n)
    {
        arr = new int[n];
    }
    public static string operator ~(MyClass a)
    {
        string txt = "";
        for (int i = 0; i < a.arr.Length; i++)
        {
            txt += a.arr[i] + " ";
        }
        return txt;
    }
    public static MyClass operator ++(MyClass a)
    {
        MyClass T = new MyClass(a.arr.Length + 1);
        for (int i = 0; i < a.arr.Length; i++)
        {
            T.arr[i] = a.arr[i];
        }
        return T;
    }
    public static MyClass operator --(MyClass a)
    {
        MyClass T = new MyClass(a.arr.Length - 1);
        for (int i = 0; i < T.arr.Length; i++)
        {
            T.arr[i] = a.arr[i];
        }
        return T;
    }
    public static MyClass operator +(MyClass a, MyClass b)
    {
        MyClass T = new MyClass(a.arr.Length + b.arr.Length);
        for (int i = 0; i < a.arr.Length; i++)
        {
            T.arr[i] = a.arr[i];
        }
        for (int i = a.arr.Length, j = 0; i < T.arr.Length; i++, j++)
        {
            T.arr[i] = b.arr[j];
        }
        return T;
    }
    public static MyClass operator +(MyClass a, int n)
    {
        MyClass T = new MyClass(a.arr.Length + 1);
        for (int i = 0; i < a.arr.Length; i++)
        {
            T.arr[i] = a.arr[i];
        }
        T.arr[a.arr.Length] = n;
        return T;
    }
    public static MyClass operator +(int n, MyClass a)
    {
        MyClass T = new MyClass(a.arr.Length + 1);
        for (int i = 1; i < a.arr.Length; i++)
        {
            T.arr[i] = a.arr[i];
        }
        T.arr[0] = n;
        return T;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass(5);
        string txt = ~A;
        Console.WriteLine(txt);
        A = ++A;
        txt = ~A;
        Console.WriteLine(txt);
        A = --A;
        txt = ~A;
        Console.WriteLine(txt);
        MyClass B = new MyClass(6);
        MyClass C = A + B;
        txt = ~C;
        Console.WriteLine(txt);
        C = A + 9;
        txt = ~C;
        Console.WriteLine(txt);
        C = 9 + A;
        txt = ~C;
        Console.WriteLine(txt);
        Console.ReadKey();
    }
}