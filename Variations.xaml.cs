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
    /// Interaction logic for Variations.xaml
    /// </summary>
    public partial class Variations : Window
    {
        public Variations()
        {
            InitializeComponent();
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

        private void CloseMain_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }

        private void HideMain_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            int n;
            int k;
            bool nParse = int.TryParse(nNumber.Text, out n);
            bool kParse = int.TryParse(kNumber.Text, out k);
            if (nParse && kParse)
            {
                int V = (Factoriel(n))/(Factoriel(n - k));
                VNumber.Text = Convert.ToString(V);
            }
        }

        public static int Factoriel(int a)
        {

            int b = 1;
            for (int i = 1; i < a + 1; i++)
            {
                b = b * i;
            }
            return b;
        }

    }
}
