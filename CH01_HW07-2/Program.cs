/*
 Напишите программу в которой по возрасту определяется год рождения.
 Возраст пользователь вводит вводит в окно с полем, а вычисленный год рождения отображается в другом диалоговом окне.
 */

using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;

class Program
{
    static void Main()
    {
        int age = Int32.Parse(Interaction.InputBox("Введите Ваш возраст:", "Возраст"));
        int year = 2019 - age;

        MessageBox.Show($"Вы родились примерно в {year - 1}-{year} годах!", "Год рождения",
            MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }

}