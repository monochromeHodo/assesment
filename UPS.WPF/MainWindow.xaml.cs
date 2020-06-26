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
using UPS.WPF.ViewModel;

namespace UPS.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmployeeListViewModel viewModel;
        public  MainWindow()
        {
            InitializeComponent();
            viewModel = new EmployeeListViewModel();
            this.DataContext = viewModel;
        }

       

        private void editEmployee(object id)
        {
            var employeeModel= viewModel.EmployeeModels.Single(t => t.Id == id.ToString());
            EmployeeModel employeeViewModel = new EmployeeModel();

            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow(employeeViewModel);

            addEmployeeWindow.ShowDialog();

        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var employeeModel = ((ListView)sender).SelectedItem as EmployeeModel;
            

            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow(employeeModel);

            addEmployeeWindow.ShowDialog();
        }

        private void AddEmployeeClick(object sender, RoutedEventArgs e)
        {
           
            AddEmployeeWindow addEmployeeWindow = new AddEmployeeWindow();

            addEmployeeWindow.ShowDialog();
        }

      
    }
}
