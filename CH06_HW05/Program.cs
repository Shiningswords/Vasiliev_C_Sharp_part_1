/*
 Напишите программу с классом, у которого есть закрытое целочисленное поле.
 Значение полю присваивается с помощью открытого метода. Методу аргументом может
 передаваться целое число, а также метод может вызываться без аргументов. Если метод вызывается без аргументов,
 то поле получает нулевое значение. Если метод вызывается с целочисленным аргументом, то это значение присваивается полю.
 Однако если переданное аргументом методу значение превышает 100. Предусмотрите в классе конструктор,
 которые работает по тому же принципу, что и метод для присваивания значения полю.
 Также в классе должен быть метод, позволяющий проверить значение поля.
 */
using System;

class Program
{
    class Nums
    {
        private int num;
        public void set(int num)
        {
            if (num < 100)
                this.num = num;
            else this.num = 100;
        }

        public void set()
        {
            this.num = 0;
        }

        public void show()
        {
            Console.WriteLine(this.num);
        }

        public Nums() { }

        public Nums(int num)
        {
            if (num < 100)
                this.num = num;
            else this.num = 100;
        }
    }
    static void Main(string[] args)
    {
        Nums A = new Nums();
        A.show();
        A.set(25);
        A.show();
        A.set();
        A.show();
        A.set(12258);
        A.show();

        Nums B = new Nums(1225);
        B.show();

        Nums C = new Nums(27);
        C.show();

        Console.ReadKey();
    }
}
