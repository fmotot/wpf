using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Globalization;

namespace Wpf
{
    /// <summary>
    /// Logique d'interaction pour ApplicationCultureSwitchSample.xaml
    /// </summary>
    public partial class ApplicationCultureSwitchSample : Window
    {
        public ApplicationCultureSwitchSample()
        {
            InitializeComponent();
        }

        private void CultureInfoSwitchButton_Click(object sender, RoutedEventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo((sender as Button).Tag.ToString());
            lblNumber.Content = (123456789.42).ToString("N2");
            lblDate.Content = DateTime.Now.ToString();
        }
    }
}
