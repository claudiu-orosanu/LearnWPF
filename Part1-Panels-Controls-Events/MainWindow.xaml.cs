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

namespace Part1_Panels_Controls_Events
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

        // PART 2
        /*
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Full name: " + Fullname.Text + "\n");
            sb.Append("Sex: " + (Male.IsChecked == true ? Male.Content : Female.Content) + "\n");
            sb.Append("Computer: ");
            sb.Append(Desktop.IsChecked == true ? (Desktop.Content + " ") : "");
            sb.Append(Laptop.IsChecked == true ? (Laptop.Content + " ") : "");
            sb.Append(Tablet.IsChecked == true ? (Tablet.Content + " ") : "");
            sb.Append("\n");
            sb.Append("Job: " + Job.SelectedItem?.ToString() + "\n");
            sb.Append("Delivery Date: " + DeliveryDate.SelectedDate?.ToShortDateString());
            MessageBox.Show(sb.ToString());
        }

        private void Job_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var newlySelectedItem = e.AddedItems[0];
            MessageBox.Show(newlySelectedItem.ToString());
        }
        */
    }
}
