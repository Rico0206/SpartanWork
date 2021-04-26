 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string op = "";
        double result1 = 0;
        bool on = false;

        //int result = 0;
        //int num = 0;

        private void one_Click(object sender, RoutedEventArgs e)
        {
            var tex = ((Button)sender).Content;

            if ((answer.Text == "0") || (on))
            {
                answer.Text = "";
            }

            on = false;

            if (tex.ToString() == ".")
            {
                if (!answer.Text.Contains("."))
                {
                    answer.Text += tex.ToString();
                }
            }
            else
            {
                answer.Text += tex.ToString();
            }
        }

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            answer.Text = "";
            op = "";
            result1 = 0;
            on = false;
        }
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            var tex = ((Button)sender).Content;

            op = tex.ToString();
            result1 = double.Parse(answer.Text);
            answer.Text = "";
        }

        private void plusminus_Click(object sender, RoutedEventArgs e)
        {
            var hasNumber = answer.Text.Any(char.IsDigit);
            var tempAnswer = double.Parse(answer.Text);

            if ((hasNumber) && answer.Text != "0")
            {
                tempAnswer *= -1;
                answer.Text = tempAnswer.ToString();
            }

        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            switch (op)
            {
                case "*":
                    answer.Text = (result1 * double.Parse(answer.Text)).ToString();
                    break;
                case "/":
                    answer.Text = Math.Round(result1 / double.Parse(answer.Text)).ToString();
                    break;
                case "+":
                    answer.Text = (result1 + double.Parse(answer.Text)).ToString();
                    break;
                case "-":
                    answer.Text = (result1 - double.Parse(answer.Text)).ToString();
                    break;
                case "%":
                    answer.Text = (result1 % double.Parse(answer.Text)).ToString();
                    break;
            }
        }
    }
}