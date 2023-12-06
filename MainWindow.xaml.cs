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

namespace Lab_Text_Boxes_Labels_and_Buttons
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


        private void PerformOperation(Func<double, double, double> operation, string operationSymbol)
        {
            if (double.TryParse(txtValue1.Text, out double value1) && double.TryParse(txtValue2.Text, out double value2))
            {
                double result = operation(value1, value2);
                txtResult.Text = result.ToString();
                lblOperation.Content = operationSymbol;
            }
            else
            {
                MessageBox.Show("Invalid entry. Please enter valid numeric values.");
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a + b, "+");
        }

        private void BtnSubtract_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a - b, "-");
        }

        private void BtnMultiply_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a * b, "x");
        }

        private void BtnDivide_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => b != 0 ? a / b : double.NaN, "/");
        }

        private void BtnCalculateAverage_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double result) && double.TryParse(txtValue2.Text, out double value2))
            {
                double average = (result + value2) / 2;
                txtResult.Text = average.ToString();
                lblOperation.Content = "Avg";
            }
            else
            {
                MessageBox.Show("Invalid entry. Please perform a calculation first.");
            }






        }

    }

}
