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

namespace FuelConsumption
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

        private void field_MouseEnter(object sender, MouseEventArgs e)
        {
            (sender as TextBox).Background = new SolidColorBrush(Colors.LightGreen);
            (sender as TextBox).Focus();
        }

        private void field_MouseLeave(object sender, MouseEventArgs e)
        {
            //(sender as TextBox).Background = new SolidColorBrush(Colors.White);
        }

        private void field_GotFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Background = new SolidColorBrush(Colors.LightGreen);
        }

        private void field_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Background = new SolidColorBrush(Colors.White);
        }

        private void btnGetResult_Click(object sender, RoutedEventArgs e)
        {
            int startOdometerVal = 0;
            int endOdometerVal = 0;
            int mileage = 0;

            startOdometerVal = sender as TextBox startOdometerVal
        }

        private void btnClearField_Click(object sender, RoutedEventArgs e)
        {
            this.startOdometerVal.Text = this.endOdometerVal.Text = this.mileage.Text = this.fuelFilled.Text = "";
        }
    }
}
