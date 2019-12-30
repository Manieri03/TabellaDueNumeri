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

namespace InterfacciaInput
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double max;
            double min;
            double num1 = int.Parse(txtnum1.Text);
            double num2 = int.Parse(txtnum2.Text);
            if(num1 >= num2)
            {
                max = num1;
                min = num2;
            }
            else
            {
                max = num2;
                min = num1;
            }
            double media = (num1 + num2) / 2;

            lblmax.Content = max.ToString();
            lblmin.Content = min.ToString();
            lblmed.Content = media.ToString();


        }
    }
}
