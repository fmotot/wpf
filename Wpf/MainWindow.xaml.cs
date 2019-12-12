using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Wpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            double largeNumber = 123456789.42;

            CultureInfo usCulture = new CultureInfo("en-US");
            CultureInfo deCulture = new CultureInfo("de-DE");
            CultureInfo seCulture = new CultureInfo("sv-SE");
            CultureInfo frCulture = new CultureInfo("fr-FR");

            lblNumberUs.Content = largeNumber.ToString("N2", usCulture);
            lblNumberDe.Content = largeNumber.ToString("N2", deCulture);
            lblNumberSe.Content = largeNumber.ToString("N2", seCulture);
            lblNumber.Content = largeNumber.ToString("N2", CultureInfo.CurrentCulture);
        }


    }
}
