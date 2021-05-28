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

namespace Calculator_App
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


        private void addButton_Click(object sender, RoutedEventArgs e)
        {
           // float op1, op2;
           
          
            double op1 = double.Parse(la.Text);
            double op2 = double.Parse(ra.Text);
            String oper = op.Text;
            String result = "";

            switch (oper)
            {
                case "+":
                    double resultfloat = op1 + op2;
                    result = resultfloat.ToString();

                    res.Text = result;
                    break;



                case "-":
                    double resultfloatmin = op1 - op2;
                    result = resultfloatmin.ToString();

                    res.Text = result;
                    break;


                case "*":
                    double resultmul = op1 * op2;
                    result = resultmul.ToString();

                    res.Text = result;
                    break;


                case "/":
                    double resultdiv = op1 - op2;
                    result = resultdiv.ToString();

                    res.Text = result;
                    break;


                case "^":


                    double result1 = 1;


                    int i = 1;

                    while (i <= op2)
                    {
                        result1 *= op1;
                        i++;
                    }


                     result = result1.ToString();

                    res.Text = result;
                    break;

                default:

                      res.Text = "INVALID";
                      break;


            }







            
           
        }

        private void clearing(object sender, RoutedEventArgs e)
        {
            // float op1, op2;


           

            String emp = "";

            res.Text = emp;
            la.Text = emp;
            ra.Text = emp;
            op.Text = emp;


        }
    }
}