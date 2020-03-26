/*
Напишите программу, в которой есть базовый класс с защищенным целочисленным массивом, индексатором (с целочисленным индексом),
позволяющим считывать и присваивать значения элементам массива, а также свойство, возвращающее результатом размер массива.
На основе базового класса создается производный класс, у которого появляется защищенный символьный массив. Опишите в производном
классе версию индексатора с символьным индексом, который возвращает значение элемента символьного массива и позволяет присвоить значение элементу 
символьного массива. Для свойства из базового класса необходимо выполнить замещение так, чтобы результатом возвращался целочисленный массив из
двух элементов: первый элемент определяет размер целочисленного массива объекта, а второй элемент определяет размер символьного массива объекта.
 */
using System;
class Base
{
    protected int[] nums;
    public Base(int[] nums)
    {
        this.nums = nums;
    }
    public int this[int n]
    {
        get
        {
            if (n >= 0 && n <= nums.Length) return this.nums[n];
            else return 0;
        }
        set
        {
            this.nums[n] = value;
        }
    }
    public int length
    {
        get
        {
            return nums.Length;
        }
    }
}
class SubBase : Base
{
    protected char[] symbs;
    public SubBase(int[] nums, char[] symbs) : base(nums)
    {
        this.symbs = symbs;
    }
    public char this[char s]
    {
        get
        {
            return symbs[(int)s % 2];
        }
        set
        {
            symbs[(int)s % 2] = value;
        }
    }
    new public int[] length
    {
        get
        {
            int[] nums = { this.nums.Length, this.symbs.Length };
            return nums;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] numz = { 1, 2, 3, 4, 5, 6, 8, 9 };
        char[] symbs = { 'a', 'b' };
        Base A = new Base(numz);
        A[0] = 18;
        Console.WriteLine(A[0]);
        SubBase B = new SubBase(numz, symbs);
        B['H'] = 'I';
        Console.WriteLine(B['a'] + " " + B['b']);
        int[] nums = B.length;
        Console.WriteLine(nums[0] + " " + nums[1]);
        Console.ReadKey();
    }
}