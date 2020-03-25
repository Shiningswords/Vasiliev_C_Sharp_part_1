/*
 Напишите программу с классом, в котором есть два поля: символьное и текстовое.
 В классе должен быть перегруженный метод для присваивания значений полям. Если метод 
 вызывается с символьным аргументом, то соответствующее значение присваивается символьному полю.
 Если метод вызывается с текстовым аргументом, то он определяет значение текстового поля.
 Методу аргументом также может передаваться символьный массив. Если массив состоит из одного элемента, то он определяет
 значение символьного поля. В противном случае (если в массиве больше одного элемента) из символов массива формируется
 текстовая строка и присваивается значением текстовому полю.
 */
using System;

class TXT
{
    public char symb;
    public string txt;

    public void set(char symb)
    {
        this.symb = symb;
    }

    public void set(string txt)
    {
        this.txt = txt;
    }

    public void set(char[] symbs)
    {
        string txt = "";
        if (symbs.Length == 1)
        {
            txt += symbs[0];
            this.txt = txt;
        }
        else
        {
            for (int i = 0; i < symbs.Length; i++)
            {
                txt += symbs[i];
            }
            this.txt = txt;
        }
    }

    public void show()
    {
        Console.WriteLine($"symb: {this.symb}, string: {this.txt}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        TXT A = new TXT();
        A.set('A');
        A.show();
        A.set("Yeah");
        A.show();
        A.set(new char[]{ 'M', 'a', 'g', 'i', 'c', '!', '!', '!' });
        A.show();

        Console.ReadKey();
    }
}