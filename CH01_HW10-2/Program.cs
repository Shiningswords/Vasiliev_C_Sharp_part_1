/*
 Напишите программу, в которой пользователь вводит два числа, а программой вычисляется
 и отображается сумма и разность этих чисел.
 Forms версия.
 */
using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

class Program
{
    static void Main()
    {
        try
        {
            int num1 = Int32.Parse(Interaction.InputBox("Введите первое число", "Первое число"));
            int num2 = Int32.Parse(Interaction.InputBox("Введите второе число", "Второе число"));
            MessageBox.Show($"Сумма {num1 + num2}, Разница {num1 - num2}", "Операции",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        catch
        {
            Application.Exit();
        }
    }
}