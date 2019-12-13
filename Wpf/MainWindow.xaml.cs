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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Canvas window = new Canvas();
            window.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WrapPanel window = new WrapPanel();
            window.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StackPanelWindow win = new StackPanelWindow();
            win.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DockPanelWindow win = new DockPanelWindow();
            win.Show();
        }
    }
}
