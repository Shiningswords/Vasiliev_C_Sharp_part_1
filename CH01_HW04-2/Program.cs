/*
Напишите программу, в которой пользователю предлагается ввести название месяца и кол-во дней в этом месяце.
Программа выводит сообщение о том, что соответствующий месяц содержит указанное количество дней.
Forms версия.
 */
using Microsoft.VisualBasic;
using System.Windows.Forms;

class HW1_CH1_Forms
{
    static void Main()
    {

        string month, days;


        month = Interaction.InputBox("Введите название меяца:", "Месяц");
        days = Interaction.InputBox($"Введите количество дней в месяце {month}:", $"Кол-во дней в месяце {month}");


        string txt = "В месяце " + month + " " + days + " дней.";

        MessageBox.Show(txt, $"Кол-во дней в месяце {month}", MessageBoxButtons.OK, 
            MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);


    }
}