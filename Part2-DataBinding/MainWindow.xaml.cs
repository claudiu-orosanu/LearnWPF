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

namespace Part2_DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Employee emp;
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = Employee.GetEmployee();

            //this is for the example without list binding
            /*emp = new Employee()
            {
                Name = "Joe",
                Title = "QA"
            };
            DataContext = emp;*/

            DataContext = Employee.GetEmployees();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // when button is clicked, the view will change to match the data (one way binding)

            // we can do it like this, if we get the employee through GetEmployee
            /*var emp = DataContext as Employee;
            if (emp != null)
            {
                emp.Name = "Joe"; 
            }*/

            // or this
            emp.Name = "Mark";
            emp.Title = "Designer";

        }
    }
}
