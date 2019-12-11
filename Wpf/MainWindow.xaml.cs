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
            pnlMainGrid.MouseDown += pnlMainGrid_MouseDown;
        }
        

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs eventArgs)
        {
            MessageBox.Show("You clicked me at " + eventArgs.GetPosition(this).ToString());
        }

        private void pnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Coucou");
        }
    }
}
