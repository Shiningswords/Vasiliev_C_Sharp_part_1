/*
 Напишите программу для вычисления суммы квадратов натуральных чисел.
 Для проверки результата воспользуйтесь тем, что (1*1)+(2*2)+...+(n*n)=n(n+1)(2n+1)/6.
 Предложите версии программы, использующие разные операторы цикла.
 */
using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            //Цикл For
            #region
            //Console.Write("Введите целое число и узнаете сумму квадратов всех чисел до него включительно: ");
            //int n = int.Parse(Console.ReadLine());
            //int s = 0;
            //Console.Write("Сумма всех квадратов чисел до {0} * {0}: ", n);

            //for (int k = 1; k <= n; k++)
            //{
            //    s += k*k;
            //}
            //Console.WriteLine(s);
            //Console.WriteLine("Проверка: " + (n*(n+1) * (2 * n + 1) / 6) );
            //Console.ReadKey();
            #endregion

            //Цикл While
            #region
            Console.Write("Введите целое число и узнаете сумму квадратов всех чисел до него включительно: ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            int k = 1;
            Console.Write("Сумма всех квадратов чисел до {0} * {0}: ", n);

            while (k <= n)
            {
                s += k * k;
                k++;
            }
            Console.WriteLine(s);
            Console.WriteLine("Проверка: " + (n * (n + 1) * (2 * n + 1) / 6));
            Console.ReadKey();
            #endregion
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
            Console.ReadKey();
        }
    }
}
