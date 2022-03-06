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
    /// Interaction logic for _3Dimensional.xaml
    /// </summary>
    public partial class _3Dimensional : Window
    {

        string VDraft = "V = ";
        string SDraft = "S = ";

        public _3Dimensional()
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
            double cubeA;
            decimal cubeS, cubeV;
            bool CubeAParse = double.TryParse(CubeA.Text, out cubeA);

            if (CubeAParse)
            {
                cubeV = Convert.ToDecimal(cubeA * cubeA * cubeA);
                cubeS = Convert.ToDecimal(6 * (cubeA * cubeA));
                CubeV.Text = VDraft + Convert.ToString(Math.Round(cubeV, 2));
                CubeS.Text = SDraft + Convert.ToString(Math.Round(cubeS, 2));
            }

            double parallelepipedA, parallelepipedB, parallelepipedH;
            decimal parallelepipedV, parallelepipedS;
            bool ParallelepipedAParse = double.TryParse(ParallelepipedA.Text, out parallelepipedA);
            bool ParallelepipedBParse = double.TryParse(ParallelepipedB.Text, out parallelepipedB);
            bool ParallelepipedHParse = double.TryParse(ParallelepipedH.Text, out parallelepipedH);

            if (ParallelepipedAParse && ParallelepipedBParse && ParallelepipedHParse)
            {
                parallelepipedV = Convert.ToDecimal(parallelepipedA * parallelepipedB);
                parallelepipedS = Convert.ToDecimal(2 * (parallelepipedA * parallelepipedB) + 2 * (parallelepipedA * parallelepipedH) + 2 * (parallelepipedA * parallelepipedH));
                ParallelepipedV.Text = VDraft + Convert.ToString(Math.Round(parallelepipedV, 2));
                ParallelepipedS.Text = SDraft + Convert.ToString(Math.Round(parallelepipedS, 2));
            }

            double pyramidA, pyramidB, pyramidH, pyramidL;
            decimal pyramidV, pyramidS;
            bool PyramidAParse = double.TryParse(PyramidA.Text, out pyramidA);
            bool PyramidBParse = double.TryParse(PyramidB.Text, out pyramidB);
            bool PyramidHParse = double.TryParse(PyramidH.Text, out pyramidH);
            bool PyramidLParse = double.TryParse(PyramidL.Text, out pyramidL);

            if (PyramidAParse && PyramidBParse && PyramidHParse)
            {
                pyramidV = Convert.ToDecimal(((pyramidA*pyramidB)*pyramidH)/3);
                PyramidV.Text = VDraft + Convert.ToString(Math.Round(pyramidV, 2));
            }

            if (PyramidAParse && PyramidBParse && PyramidLParse)
            {
                pyramidS = Convert.ToDecimal((pyramidA * pyramidB) + (pyramidA * pyramidB) * pyramidL * (1/2));
                PyramidS.Text = SDraft + Convert.ToString(Math.Round(pyramidS, 2));
            }

            double coneR, coneL, coneH;
            decimal coneV, coneS;
            bool ConeRParse = double.TryParse(ConeR.Text, out coneR);
            bool ConeLParse = double.TryParse(ConeL.Text, out coneL);
            bool ConeHParse = double.TryParse(ConeH.Text, out coneH);
            

            if (ConeRParse && ConeHParse)
            {
                coneV = Convert.ToDecimal(((coneR*coneR*Math.PI)*coneH)/3);
                ConeV.Text = VDraft + Convert.ToString(Math.Round(coneV, 2));
            }

            if (ConeRParse && ConeLParse)
            {
                coneS = Convert.ToDecimal((coneR * coneR * Math.PI) + (coneR*coneL*Math.PI));
                ConeS.Text = SDraft + Convert.ToString(Math.Round(coneS, 2));
            }

            double sphereR;
            decimal sphereV, sphereS;
            bool sphereRParse = double.TryParse(SphereR.Text, out sphereR);

            if (sphereRParse)
            {
                
                sphereV = Convert.ToDecimal(1.33 * (sphereR * sphereR * sphereR) * Math.PI);
                sphereS = Convert.ToDecimal(4 * Math.PI * (sphereR * sphereR));
                SphereV.Text = VDraft + Convert.ToString(Math.Round(sphereV, 2));
                SphereS.Text = SDraft + Convert.ToString(Math.Round(sphereS, 2));

            }

        }

    }
}
