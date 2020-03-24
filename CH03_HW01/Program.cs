/*
 Напишите программу, в которой пользователь вводит число, а программа проверяет,
 делится ли это число на 3 и на 7.  Результаты проверки отображаются в сообщении в диалоговом окне. Используйте обработку исключений
 */
using Microsoft.VisualBasic;
using System.Windows.Forms;


class Program
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Interaction.InputBox("Введите целое число и узнаете делится ли оно на 3 и на 7:", "Число"));
            if (number % 2 == 0 && number % 7 == 0)
            {
                MessageBox.Show($"Число {number} делится и на 3 и на 7!", "Ура!", MessageBoxButtons.OK,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                MessageBox.Show($"Число {number} к сожалению не делится на 3 и на 7!", "О нет!", MessageBoxButtons.OK,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
        }
        catch
        {
            MessageBox.Show("Вы ввели не целое число!", "О нет!", MessageBoxButtons.OK,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        MessageBox.Show("Bye Bye!", "Пока!", MessageBoxButtons.OK,
                MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}

