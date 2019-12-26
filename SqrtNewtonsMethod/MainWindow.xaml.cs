using System;
using System.Windows;

namespace SqrtNewtonsMethod
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            double epsilon, rootNumber, assumption;

            try
            {
                double.TryParse(textBox3.Text.Replace(".", ","), out epsilon);
                double.TryParse(textBox1.Text, out rootNumber);
                double.TryParse(textBox4.Text, out assumption);
                double sqrtValue = NewtonsMethod.Pow(rootNumber, epsilon, assumption);
                textBox2.Text = sqrtValue.ToString();
                textBox5.Text = Math.Abs(Math.Pow(sqrtValue, 2) - rootNumber).ToString("0.##########");
            }
            catch (ArgumentException argumentException)
            {
                MessageBox.Show("Неверное значение одного из параметров");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
