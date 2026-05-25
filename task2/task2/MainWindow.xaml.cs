using System;
using System.Windows;
using System.Windows.Controls;

namespace task2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void figuraBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (label1 == null || label2 == null) return;

            int i = figuraBox.SelectedIndex;
            if (i == 0)
            {
                label1.Content = "сторона:";
                label2.Content = "высота:";
            }
            else if (i == 1)
            {
                label1.Content = "ширина:";
                label2.Content = "высота:";
            }
            else if (i == 2)
            {
                label1.Content = "полуось a:";
                label2.Content = "полуось b:";
            }
            param1Box.Text = "";
            param2Box.Text = "";
        }

        private Figura SozdatFiguru()
        {
            double p1 = Convert.ToDouble(param1Box.Text);
            double p2 = Convert.ToDouble(param2Box.Text);
            int i = figuraBox.SelectedIndex;
            if (i == 0) return new Romb(p1, p2);
            if (i == 1) return new Pryamougolnik(p1, p2);
            if (i == 2) return new Ellips(p1, p2);
            return null;
        }

        private void poschitat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (figuraBox.SelectedIndex < 0)
                {
                    MessageBox.Show("Сначала выберите фигуру!");
                    return;
                }
                Figura f = SozdatFiguru();
                string text = f.Info() + "\n";
                text += "Площадь = " + Math.Round(f.Ploshad(), 3) + "\n";
                text += "Периметр = " + Math.Round(f.Perimetr(), 3);

                if (f is Pryamougolnik pr)
                {
                    text += "\nПлощадь × 2 = " + Math.Round(pr.Ploshad(2), 3);
                }

                resultBox.Text = text;
            }
            catch
            {
                MessageBox.Show("Введите числа правильно!");
            }
        }
    }
}
