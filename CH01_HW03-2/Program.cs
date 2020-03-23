/*
Напишите программу, в которой пользователь последовательно вводит название текущего дня недели, название месяца и дату.
Программа выводит сообщение о сегодняшней дате(день недели, дата, месяц).
Forms версия.
 */
using Microsoft.VisualBasic;
using System.Windows.Forms;

class HW1_CH1_Forms
{
    static void Main()
    {
        string DayOfWeek, month, date;

        DayOfWeek = Interaction.InputBox("Введите день недели:", "День недели");
        month = Interaction.InputBox("Введите месяц:", "Месяц");
        date = Interaction.InputBox("Введите дату (Число месяца):", "Дата");

        string txt = "Сегодня: " + DayOfWeek + ", Дата: " + date + ", Месяц: " + month;

        MessageBox.Show(txt, "Дата", MessageBoxButtons.OK, MessageBoxIcon.None, 
            MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
    }
}