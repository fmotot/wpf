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

            Button btn2 = new Button();
            btn2.FontWeight = FontWeights.Bold;
            btn2.HorizontalAlignment = HorizontalAlignment.Left;
            btn2.VerticalAlignment = VerticalAlignment.Bottom;
            btn2.Width = 120;
            btn2.Height = 25;

            WrapPanel pnl = new WrapPanel();
            
            TextBlock txt = new TextBlock();
            txt.Text = "Multi";
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Color";
            txt.Foreground = Brushes.Red;
            pnl.Children.Add(txt);

            txt = new TextBlock();
            txt.Text = "Button2";
            pnl.Children.Add(txt);

            btn2.Content = pnl;
            grid.Children.Add(btn2);
        }
    }
}
