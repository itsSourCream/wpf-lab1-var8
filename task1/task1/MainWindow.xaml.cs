using System;
using System.Windows;

namespace task1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void vozrastBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fam = familiaBox.Text;
                double okl = Convert.ToDouble(okladBox.Text);
                DateTime dr = drPicker.SelectedDate.Value;
                Worker rab = new Worker(fam, okl, dr);
                int v = rab.Vozrast();
                resultBox.Text = "Возраст работника " + fam + " = " + v + " лет";
            }
            catch
            {
                MessageBox.Show("Введите все данные правильно!");
            }
        }

        private void do50Btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string fam = familiaBox.Text;
                double okl = Convert.ToDouble(okladBox.Text);
                DateTime dr = drPicker.SelectedDate.Value;
                Worker rab = new Worker(fam, okl, dr);
                int d = rab.DneyDo50();
                if (d < 0)
                {
                    resultBox.Text = "Работнику " + fam + " уже больше 50 лет";
                }
                else
                {
                    resultBox.Text = "До 50 лет осталось " + d + " дней";
                }
            }
            catch
            {
                MessageBox.Show("Введите все данные правильно!");
            }
        }
    }
}
