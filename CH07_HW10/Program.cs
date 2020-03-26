/*
 Напишите программу с классом, у которого есть поле, являющееся ссылкой на целочисленный массив.
 При создании объекта массив заполняется случайными числами. Переопределите в классе метод ToString() так,
 чтобы метод возвращал текстовую строку со значениями элементов массива. Также строка должна содержать информацию о количестве
 элементов массива и среднем значении для элементов массива (сумма значений элементов, деленная на количество элементов).
 */
using System;
class MyClass
{
    public int[] arr = new int[10];
    public MyClass()
    {
        Random rnd = new Random();
        for (int i = 0; i < this.arr.Length; i++)
        {
            this.arr[i] = rnd.Next(1, 101);
        }
    }
    public override string ToString()
    {
        int count = this.arr.Length;
        int average = 0;
        for (int i = 0; i < this.arr.Length; i++)
        {
            average += this.arr[i];
        }
        average = average / this.arr.Length;

        string TXT = $"Всего элементов: {count}\nСреднее значение: {average}\nЗначения массива: ";

        for (int i = 0; i < this.arr.Length; i++)
        {
            TXT += this.arr[i] + " ";
        }
        return TXT;
    }
}
class Program
{
    static void Main(string[] args)
    {
        MyClass A = new MyClass();
        Console.WriteLine(A.ToString());
        Console.ReadKey();
    }
}