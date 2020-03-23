/*
 Напишите программу для вычисления суммы двух чисел. Оба числа вводятся пользователем.
 Для вычисления суммы используйте оператор +.
 Forms версия.
 */
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        try
        {
            int num1 = Int32.Parse(Interaction.InputBox("Введите первое чило:", "Первое число"));
            int num2 = Int32.Parse(Interaction.InputBox("Введите второе чило:", "Второе число"));
            MessageBox.Show($"Сумма числа {num1} и числа {num2} равна: {num1 + num2}", "Sum",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        catch
        {
            Application.Exit();
        }
        }
}