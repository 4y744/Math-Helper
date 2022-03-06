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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string operation;
        double? num1 = null;
        double? num2 = null;
        //"?" makes variable nullable
        decimal? result;
        string checkForDot;
        string Dot = ".";

        string zero_scary = "Can't divide by zero!";
        public Window1()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary)
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }


        private void plus(object sender, EventArgs e)
        {

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }
            else
            {
                if (num1 == null)
                {
                    operation = "+";
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (num1 != null && num2 == null)
                {

                    num2 = Convert.ToDouble(textBox1.Text);
                    switch (operation)
                    {
                        case "+":
                            num1 = num1 + num2;
                            break;
                        case "-":
                            num1 = num1 - num2;
                            break;
                        case "*":
                            num1 = num1 * num2;
                            break;
                        case "/":
                            num1 = num1 / num2;
                            break;


                    }

                    num2 = null;
                    textBox1.Text = "";
                    operation = "+";
                }
            }

        }

        private void minus(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }
            else
            {
                if (num1 == null)
                {
                    operation = "-";
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (num1 != null && num2 == null)
                {

                    num2 = Convert.ToDouble(textBox1.Text);
                    switch (operation)
                    {
                        case "+":
                            num1 = num1 + num2;
                            break;
                        case "-":
                            num1 = num1 - num2;
                            break;
                        case "*":
                            num1 = num1 * num2;
                            break;
                        case "/":
                            num1 = num1 / num2;
                            break;


                    }
                    num2 = null;
                    textBox1.Text = "";
                    operation = "-";
                }
            }
        }

        private void div(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }
            else
            {
                if (num1 == null)
                {
                    operation = "/";
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (num1 != null && num2 == null)
                {

                    num2 = Convert.ToDouble(textBox1.Text);
                    if (num2 == 0)
                    {
                        textBox1.Text = "Can't divide by zero!";
                    }
                    else
                    {
                        switch (operation)
                        {
                            case "+":
                                num1 = num1 + num2;
                                break;
                            case "-":
                                num1 = num1 - num2;
                                break;
                            case "*":
                                num1 = num1 * num2;
                                break;
                            case "/":
                                num1 = num1 / num2;
                                break;


                        }
                        num2 = null;
                        textBox1.Text = "";
                        operation = "/";
                    }

                }
            }
        }

        private void multiply(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }

            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }
            else
            {
                if (num1 == null)
                {
                    operation = "*";
                    num1 = Convert.ToDouble(textBox1.Text);
                    textBox1.Text = "";
                }
                else if (num1 != null && num2 == null)
                {

                    num2 = Convert.ToDouble(textBox1.Text);
                    switch (operation)
                    {
                        case "+":
                            num1 = num1 + num2;
                            break;
                        case "-":
                            num1 = num1 - num2;
                            break;
                        case "*":
                            num1 = num1 * num2;
                            break;
                        case "/":
                            num1 = num1 / num2;
                            break;


                    }
                    num2 = null;
                    textBox1.Text = "";
                    operation = "*";
                }
            }
        }

        private void dot(object sender, EventArgs e)
        {
            if (textBox1.Text == zero_scary)
            {
                textBox1.Text = "";
            }
            else
            {
                checkForDot = textBox1.Text;
                if (checkForDot.Contains(Dot))
                {

                }
                else
                {
                    textBox1.Text += ".";
                }
            }

        }

        private void equ(object sender, EventArgs e)
        {

            if (textBox1.Text == zero_scary || textBox1.Text == ".")
            {
                textBox1.Text = "";
            }

            if (textBox1.Text == "")
            {
                num2 = 0;
            }
            else
            {
                num2 = Convert.ToDouble(textBox1.Text);
            }


            if (operation == "+")
            {
                result = Convert.ToDecimal(num1 + num2);
                textBox1.Text = Convert.ToString(result);
                num1 = null;
                num2 = null;
            }
            else if (operation == "-")
            {
                result = Convert.ToDecimal(num1 - num2);
                textBox1.Text = Convert.ToString(result);
                num1 = null;
                num2 = null;
            }
            else if (operation == "/")
            {
                if (num2 == 0)
                {
                    textBox1.Text = "Can't divide by zero!";
                    num1 = null;
                    num2 = null;
                }
                else
                {
                    result = Convert.ToDecimal(num1 / num2);
                    textBox1.Text = Convert.ToString(result);
                    num1 = null;
                    num2 = null;
                }
            }
            else if (operation == "*")
            {
                result = Convert.ToDecimal(num1 * num2);
                textBox1.Text = Convert.ToString(result);
                num1 = null;
                num2 = null;
            }
            else
            {
                result = 0;
                textBox1.Text = Convert.ToString(result);
                num1 = null;
                num2 = null;
            }


        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = null;
            num2 = null;
        }
    }
}
