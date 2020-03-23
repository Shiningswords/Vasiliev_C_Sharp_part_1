/*
Напишите программу, в которой пользователь вводит сначала имя, а затем фамилию.
Программа выводит информацию об имени и фамилии пользователя.
Forms версия.
 */
using Microsoft.VisualBasic;
using System.Windows.Forms;

class HW1_CH1_Forms
{
    static void Main()
    {

        string FirstName;
        string LastName;

        FirstName = Interaction.InputBox("Введите Ваше имя:", "Ваше имя");
        LastName = Interaction.InputBox("Введите Вашу фамилию:", "Ваша фамилия");

        string txt = "Вас зовут: " + FirstName + ", Ваша фамилия: " + LastName;

        MessageBox.Show(txt, "Знакомство состоялось", MessageBoxButtons.OK, MessageBoxIcon.None, 
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


    }
}