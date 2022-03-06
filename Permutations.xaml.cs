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
    /// Interaction logic for Permutations.xaml
    /// </summary>
    public partial class Permutations : Window
    {
        public Permutations()
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
            bool nParse= int.TryParse(nNumber.Text, out n);
            if(nParse)
            {
                int P = Factoriel(n);
                PNumber.Text = Convert.ToString(P);
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
