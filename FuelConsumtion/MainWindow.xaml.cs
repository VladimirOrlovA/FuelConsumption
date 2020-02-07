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
            //(sender as TextBox).Background = new SolidColorBrush(Colors.LightGreen);
            //(sender as TextBox).Background = Brushes.LightGreen;
            ((TextBox)sender).Background = Brushes.LightGreen;
        }

        private void field_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).Background = new SolidColorBrush(Colors.White);
        }

        private void btnGetResult_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(startOdometerVal.Text, out int sov);
            int.TryParse(endOdometerVal.Text, out int eov);
            int.TryParse(fuelFilled.Text, out int ff);
            int mileage = eov - sov;

            if (mileage > 0)
            {
                int consumtion = 100 * ff / mileage;
                result.Text = consumtion.ToString() + " л/100км";
            }
            else result.Text = "Введены неверные данные";

        }

        private void btnClearField_Click(object sender, RoutedEventArgs e)
        {
            this.startOdometerVal.Text = this.endOdometerVal.Text = this.mileage.Text = this.fuelFilled.Text = "";
        }
    }
}
