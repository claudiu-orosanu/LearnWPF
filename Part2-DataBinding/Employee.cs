using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Part2_DataBinding
{
    public class Employee : INotifyPropertyChanged
    {
        // implementing INotifyPropertyChanged enables one way data binding
        // when the underlying data changes, the view changes too
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        private string _title;
        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        // list data binding
        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Washington", Title = "President 1" });
            employees.Add(new Employee() { Name = "Adams", Title = "President 2" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "President 3" });
            employees.Add(new Employee() { Name = "Madison", Title = "President 4" });
            employees.Add(new Employee() { Name = "Monroe", Title = "President 5" });
            return employees;
        }
    }
}
