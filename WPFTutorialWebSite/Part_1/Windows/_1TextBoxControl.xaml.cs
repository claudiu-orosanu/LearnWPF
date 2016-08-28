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

namespace Part_1.Windows
{
    /// <summary>
    /// Interaction logic for _1TextBoxControl.xaml
    /// </summary>
    public partial class _1TextBoxControl : Window
    {
        public _1TextBoxControl()
        {
            InitializeComponent();
            txtbox.Text = "The truth becomes undeniable!";
        }

        private void TextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            txtStatus.Text = "Selection starts at character #" + textBox.SelectionStart + Environment.NewLine;
            txtStatus.Text += "Selection is " + textBox.SelectionLength + " character(s) long" + Environment.NewLine;
            txtStatus.Text += "Selected text: '" + textBox.SelectedText + "'";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tboxwest.Focus();
        }
    }
}
