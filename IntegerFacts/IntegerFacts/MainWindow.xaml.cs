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
using static IntegerFacts.ArrayMath;

namespace IntegerFacts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] array =
        {
            999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999,
            999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999, 999999
        };


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 0; i < array.Length; ++i)
                {
                    int currentValue = i + 2;
                    if (currentValue > 20)
                    {
                        currentValue = 20;
                    }
                    if (array[i] == 999999)
                    {
                        array[i] = Convert.ToInt32(textBox.Text);
                        Result.Content += " " + array[i];
                        Enter.Content = "Enter Value " + currentValue;
         
                        break;
                    }
                }
                


            }
            catch (SystemException)
            {
                MessageBox.Show("Error. Invalid values entered.");
            }
        }

        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            if (array.Contains(999999))
            {
                MessageBox.Show("Error. Please finish your array");
            }
            else
            {
                int max = 0;
                int min = 0;
                int sum = 0;
                int average = 0;
                GetMath(array, out min, out max, out sum, out average);
                ArrayData.Content = "The highest value is " + max + ". The lowest value is " + min + ". The sum is " +
                                    sum + ". The average is " + average + ".";
            }
            
        }
    }
}
