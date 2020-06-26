using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using UPS.WPF.ViewModel;

namespace UPS.WPF
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        public AddEmployeeWindow()
        {
            InitializeComponent();
            this.DataContext = new EmployeeModel();
        }
        public AddEmployeeWindow(EmployeeModel employeeViewModel):this()
        {
            this.DataContext = employeeViewModel;
        }
    }
}
