/*
 Напишите программу с классом, в котором есть текстовое поле и символьное поле.
 Значение полям присваивается при создании объекта класса. В классе должен быть метод, возвращающий
 результатом массив из текстовых строк. Такие строки получаются разбиением на подстроки значения текстового поля.
 Символ, являющийся индикатором для разбивки на подстроки, определяется значением символьного поля.
 Переопределить в классе метод ToString() так, чтобы он возвращал текст со значениями полей объекта и подстроки, на которые разбивается
 текст из текстового поля.
 */
using System;

class MyClass
{
    string txt;
    char symb;
    public MyClass(string txt, char symb)
    {
        this.txt = txt;
        this.symb = symb;
    }
    public string[] SubTxts()
    {
        string[] arr = this.txt.Split(this.symb);
        return arr;
    }
    public override string ToString()
    {
        string TXT = $"Поле текст: {this.txt}\nПоле символа: {this.symb}\nПодстроки:\n";
        string[] arr = this.txt.Split(this.symb);
        for (int i = 0; i < arr.Length; i++)
        {
            TXT += arr[i] + ";\n";
        }
        return TXT;
    }
}
class Program
{
    static void Main(string[] args)
    {
        string txt = "паровоз,параход,самолет,автомобиль";
        MyClass A = new MyClass(txt, ',');
        string[] arr = A.SubTxts();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} "); ;
        }
        Console.WriteLine();
        Console.WriteLine(A.ToString());
        Console.ReadKey();
    }
}