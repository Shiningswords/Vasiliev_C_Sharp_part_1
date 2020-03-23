/*
Напишите программу в которой пользователь вводит имя и год рождения, а программа отображает сообщение,
содержащее имя пользователя и его возраст.
Forms версия.
*/
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System;

class Program
{
    static void Main()
    {
        int year = Int32.Parse(Interaction.InputBox("Введите год Вашего рождения:", "Год рождения"));
        string name = Interaction.InputBox("Введите Ваше имя", "Имя");
        int age = 2019 - year;

        MessageBox.Show($"Вас зовут {name}, и Вам примерно {age} лет!", "Приветствие",
            MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}