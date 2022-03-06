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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        double BfSquareRoot;
        double AfSquareRoot;
        decimal answer;
        bool isNumber;
        public Window2()
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

        private void SquareRootClick(object sender, RoutedEventArgs e)
        {
            CalculateSquareRoot();       
        }

        private void SquareRootText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                CalculateSquareRoot();
            }
        }

        private void CalculateSquareRoot()
        {
            isNumber = double.TryParse(SquareRootText.Text, out BfSquareRoot);
            if(isNumber)
            {
                AfSquareRoot = Math.Sqrt(BfSquareRoot);
                answer = Math.Round(Convert.ToDecimal(AfSquareRoot), 6);
                SquareRootAnswer.Text = Convert.ToString(answer);
            }  
        }
    }
}
