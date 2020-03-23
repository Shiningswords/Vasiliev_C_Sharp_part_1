/*
Напишите программу, в которой пользователь вводит число, а программой отображается последовательность
из трех чисел: число, на единицу меньше введеного, введеное число и число, на единицу больше введеного.
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
            int num = Int32.Parse(Interaction.InputBox("Введите число", "Число"));
            MessageBox.Show($"{num - 1} {num} {num + 1}", "Последовательность",
                MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        catch
        {
            Application.Exit();
        }
    }
}