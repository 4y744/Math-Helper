using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Math_Helper
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        double a;
        double b;
        double c;
        double x1;
        double x2;
        double x1_r;
        double x2_r;


        public Window3()
        {
            InitializeComponent();
        }

        private void CloseMain_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void HideMain_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch (Exception)
            {

            }
        }

        private void CalculateQuadraticEquation(object sender, RoutedEventArgs e)
        {
            CalculateQuadraticEquation();
        }

        private void SquareRootText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CalculateQuadraticEquation();
            }
        }

        private void CalculateQuadraticEquation()
        {
            bool aTest = double.TryParse(aText.Text, out a);
            bool bTest = double.TryParse(bText.Text, out b);
            bool cTest = double.TryParse(cText.Text, out c);
            if (aTest && bTest && cTest)
            {
                double D = (b * b) - 4 * a * c;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
                x1_r = Math.Round(x1, 4);
                x2_r = Math.Round(x2, 4);
                x1Text.Text = Convert.ToString(x1_r);
                x2Text.Text = Convert.ToString(x2_r);

            }
        }
    }
}
