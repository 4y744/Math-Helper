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

namespace Math_Helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Window1 CalculatorWindow = new Window1();
        Window2 SquareRootWindow = new Window2();
        Window3 QuadraticEquationWindow = new Window3();
        _2Dimensional Window2D = new _2Dimensional();
        _3Dimensional Window3D = new _3Dimensional();
        Permutations WindowPer = new Permutations();
        Variations WindowVar = new Variations();
        Combinations WindowCom = new Combinations();

        public MainWindow()
        {
            InitializeComponent();
            
        }        

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch(Exception)
            {

            }
        }

        private void CloseMain_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void HideMain_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void WisAlg(object sender, RoutedEventArgs e)
        {
            var url_al = "https://en.wikipedia.org/wiki/Algebra";
            var psi_alg = new System.Diagnostics.ProcessStartInfo();
            psi_alg.UseShellExecute = true;
            psi_alg.FileName = url_al;
            System.Diagnostics.Process.Start(psi_alg);
        }

        private void WisGeo(object sender, RoutedEventArgs e)
        {
            var url_geo = "https://en.wikipedia.org/wiki/Geometry";
            var psi_geo = new System.Diagnostics.ProcessStartInfo();
            psi_geo.UseShellExecute = true;
            psi_geo.FileName = url_geo;
            System.Diagnostics.Process.Start(psi_geo);
        }

        private void WisPro(object sender, RoutedEventArgs e)
        {
            var url_pro = "https://en.wikipedia.org/wiki/Probability";
            var psi_pro = new System.Diagnostics.ProcessStartInfo();
            psi_pro.UseShellExecute = true;
            psi_pro.FileName = url_pro;
            System.Diagnostics.Process.Start(psi_pro);
        }

        private void Open_Calculator(object sender, RoutedEventArgs e)
        {
            CalculatorWindow.Show();
            if(CalculatorWindow.WindowState == WindowState.Minimized)
            {
                CalculatorWindow.WindowState = WindowState.Normal;
            }

        }

        private void Square_Root(object sender, RoutedEventArgs e)
        {
            SquareRootWindow.Show();
            if (SquareRootWindow.WindowState == WindowState.Minimized)
            {
                SquareRootWindow.WindowState = WindowState.Normal;
            }
        }

        private void Quadratic_Equation(object sender, RoutedEventArgs e)
        {
            QuadraticEquationWindow.Show();
            if (QuadraticEquationWindow.WindowState == WindowState.Minimized)
            {
                QuadraticEquationWindow.WindowState = WindowState.Normal;
            }
        }  

        private void Dim2open(object sender, RoutedEventArgs e)
        {
            Window2D.Show();
            if (Window2D.WindowState == WindowState.Minimized)
            {
                Window2D.WindowState = WindowState.Normal;
            }
        }

        private void Dim3open(object sender, RoutedEventArgs e)
        {
            Window3D.Show();
            if (Window3D.WindowState == WindowState.Minimized)
            {
                Window3D.WindowState = WindowState.Normal;
            }
        }

        private void PerOpen(object sender, RoutedEventArgs e)
        {
            WindowPer.Show();
            if (WindowPer.WindowState == WindowState.Minimized)
            {
                WindowPer.WindowState = WindowState.Normal;
            }
        }

        private void VarOpen(object sender, RoutedEventArgs e)
        {
            WindowVar.Show();
            if (WindowVar.WindowState == WindowState.Minimized)
            {
                WindowVar.WindowState = WindowState.Normal;
            }
        }

        private void ComOpen(object sender, RoutedEventArgs e)
        {
            WindowCom.Show();
            if (WindowCom.WindowState == WindowState.Minimized)
            {
                WindowCom.WindowState = WindowState.Normal;
            }
        }

        private void MyGitHub(object sender, RoutedEventArgs e)
        {
            var url_git = "https://github.com/AytachS";
            var psi_pro = new System.Diagnostics.ProcessStartInfo();
            psi_pro.UseShellExecute = true;
            psi_pro.FileName = url_git;
            System.Diagnostics.Process.Start(psi_pro);
        }
    }
}
