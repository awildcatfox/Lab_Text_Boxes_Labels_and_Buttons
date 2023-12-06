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

    //    David Abarca
    //    Prog 2
    //    12/5/2023


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

            // attempt to parse the values from the text boxes as doubles
            if (double.TryParse(txtValue1.Text, out double value1) && double.TryParse(txtValue2.Text, out double value2))
            {
                double result = operation(value1, value2);  // Calculate the result using the specified operation
                txtResult.Text = result.ToString(); // Update the result using the specified operation
                lblOperation.Content = operationSymbol; // Display the symbol of the performed operation
            }
            else
            {
                MessageBox.Show("Invalid entry. Please enter valid numeric values.");   // Display a message for invalid entries 
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            PerformOperation((a, b) => a + b, "+");  // Invoke PerformOperation method with addition operation and symbol "+"
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
            if (double.TryParse(txtResult.Text, out double result) && double.TryParse(txtValue2.Text, out double value2))   // Attempt to parse the result and value2 as doubles
            {
                double average = (result + value2) / 2;  // Calculate the average
                txtResult.Text = average.ToString();    // Update the result textbox with the calculated average
                lblOperation.Content = "Avg";   // Display "Avg" in the operation label
            }
            else
            {
                MessageBox.Show("Invalid entry. Please perform a calculation first.");  // Display a message box for invalid entries
            }






        }

    }

}
