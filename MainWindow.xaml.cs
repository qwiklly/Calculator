using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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
using System.Linq.Expressions;
using static System.Net.Mime.MediaTypeNames;

namespace kalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach (UIElement el in MainRoot.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += Button_Click;
                }

            }
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private Calculator calculator = new Calculator();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string str = (string)((Button)e.OriginalSource).Content;
            textLabel.Text += "";
            switch (str)
            {
                case ("CE"):

                    textLabel.Text = calculator.HandleCE();
                    break;
                case ("C"):
                    textLabel.Text = calculator.HandleC();
                    break;

                case ("⌫"):
                    textLabel.Text = calculator.HandleBackspace(textLabel.Text);
                    break;
                case ("+/-"):

                    textLabel.Text = calculator.HandleNegative(textLabel.Text);
                    break;
                case ("x²"):

                    textLabel.Text = calculator.HandlePow(textLabel.Text);
                    break;
                case ("1/x"):

                    textLabel.Text = calculator.HandleInverse(textLabel.Text);
                    break;
                case ("√"):
                    textLabel.Text = calculator.HandleSqrt(textLabel.Text);
                    break;

                case ("="):
                    textLabel.Text = calculator.HandleEquals(textLabel.Text);
                    break;
                default:

                    try
                    {
                        textLabel.Text += str;
                    }
                    catch
                    {
                        textLabel.Text = "error";
                    }
                    break;
            }
        }
    }
}