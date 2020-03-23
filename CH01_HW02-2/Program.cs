/*
Напишите программу, в которой пользователь вводит имя и возраст.
Программа выводит сообщение об имени и возрасте.
Forms версия.
 */
using Microsoft.VisualBasic;
using System.Windows.Forms;

class HW1_CH1_Forms
{
   static void Main()
    {

        string name;
        string age;

        name = Interaction.InputBox("Введите Ваше имя:", "Ваше имя");
        age = Interaction.InputBox("Введите Ваш возраст:", "Ваш возраст");

        string txt = "Вас зовут " + name + " и Вам " + age + " лет.";

        MessageBox.Show(txt, "Знакомство состоялось", MessageBoxButtons.OK, MessageBoxIcon.None, 
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}