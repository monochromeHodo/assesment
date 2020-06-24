using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace UPS.WPF.ViewModel
{
    public class EmployeeListViewModel : INotifyPropertyChanged
    {
        ICommand DeleteEmployee=new RelayCommand(t=> { },t=> { return true; });
        ObservableCollection<EmployeeModel> EmployeeModels = new ObservableCollection<EmployeeModel>();
        public event PropertyChangedEventHandler PropertyChanged;
        public EmployeeListViewModel()
        {
            DeleteEmployee = new RelayCommand(t => { this.deleteEmployee(t); }, t => { return true; });
        }
        private void deleteEmployee(object id)
        {

        }
    }
}
