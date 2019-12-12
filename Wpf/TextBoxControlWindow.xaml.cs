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
using System.Windows.Shapes;

namespace Wpf
{
    /// <summary>
    /// Logique d'interaction pour TextBoxControlWindow.xaml
    /// </summary>
    public partial class TextBoxControlWindow : Window
    {
        public TextBoxControlWindow()
        {
            InitializeComponent();
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            txtSelect.Focus();
            txtSelect.SelectionLength = 3;
            txtSelect.SelectionStart = 2;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            txtSelect.Focus();
            txtSelect.SelectionStart = 4;
            txtSelect.SelectionLength = 0;
            txtSelect.SelectedText = "Prout";
        }
    }
}
