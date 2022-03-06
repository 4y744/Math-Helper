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
    /// Interaction logic for _2Dimensional.xaml
    /// </summary>
    /// 

    

    public partial class _2Dimensional : Window
    {

        string PDraft = "P = ";
        string SDraft = "S = ";

        public _2Dimensional()
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
            double squareA;
            decimal squareP, squareS;
            bool SquareAParse = double.TryParse(SquareA.Text, out squareA);
            
            if(SquareAParse)
            {
                squareP = Convert.ToDecimal(4 * squareA);
                squareS = Convert.ToDecimal(squareA * squareA);
                SquareP.Text = PDraft + Convert.ToString(Math.Round(squareP, 2));
                SquareS.Text = SDraft + Convert.ToString(Math.Round(squareS, 2));
            }

            double rectangleA, rectangleB;
            decimal rectangleP, rectangleS;
            bool RectangleAParse = double.TryParse(RectangleA.Text, out rectangleA);
            bool RectangleBParse = double.TryParse(RectangleB.Text, out rectangleB);

            if(RectangleAParse && RectangleBParse)
            {
                rectangleP = Convert.ToDecimal(2 * rectangleA + 2 * rectangleB);
                rectangleS = Convert.ToDecimal(rectangleA * rectangleB);
                RectangleP.Text = PDraft + Convert.ToString(Math.Round(rectangleP, 2));
                RectangleS.Text = SDraft + Convert.ToString(Math.Round(rectangleS, 2));
            }

            double triangleA, triangleB, triangleC, triangleHa;
            decimal triangleP, triangleS;
            bool TriangleAParse = double.TryParse(TriangleA.Text, out triangleA);
            bool TriangleBParse = double.TryParse(TriangleB.Text, out triangleB);
            bool TriangleCParse = double.TryParse(TriangleC.Text, out triangleC);
            bool TriangleHaParse = double.TryParse(TriangleHA.Text, out triangleHa);

            if (TriangleAParse && TriangleBParse && TriangleCParse)
            {
                triangleP = Convert.ToDecimal(triangleA + triangleB + triangleC);
                TriangleP.Text = PDraft + Convert.ToString(Math.Round(triangleP, 2));
            }

            if(TriangleAParse && TriangleHaParse)
            {
                triangleS = Convert.ToDecimal((triangleA * triangleHa) / 2);
                TriangleS.Text = SDraft + Convert.ToString(Math.Round(triangleS, 2));
            }

            double trapezeA, trapezeB, trapezeC, trapezeH;
            decimal trapezeP, trapezeS;
            bool TrapezeAParse = double.TryParse(TrapezeA.Text, out trapezeA);
            bool TrapezeBParse = double.TryParse(TrapezeB.Text, out trapezeB);
            bool TrapezeCParse = double.TryParse(TrapezeC.Text, out trapezeC);
            bool TrapezeHParse = double.TryParse(TrapezeH.Text, out trapezeH);

            if(TrapezeAParse && TrapezeBParse && TrapezeCParse)
            {
                trapezeP = Convert.ToDecimal(trapezeA + trapezeB + 2 * trapezeC);
                TrapezeP.Text = PDraft + Convert.ToString(Math.Round(trapezeP, 2));
            }

            if(TrapezeAParse && TrapezeBParse && TrapezeHParse)
            {
                trapezeS = Convert.ToDecimal(((trapezeA + trapezeB)/2) * trapezeH);
                TrapezeS.Text = SDraft + Convert.ToString(Math.Round(trapezeS, 2));
            }

            double circleR;
            decimal circleP, circleS;
            bool circleRParse = double.TryParse(CircleR.Text, out circleR);

            if(circleRParse)
            {
                circleP = Convert.ToDecimal(2 * Math.PI * circleR);
                circleS = Convert.ToDecimal(Math.PI * circleR * circleR);
                CircleP.Text = PDraft + Convert.ToString(Math.Round(circleP, 2));
                CircleS.Text = SDraft + Convert.ToString(Math.Round(circleS, 2));
            }

        }

    }
    

}
