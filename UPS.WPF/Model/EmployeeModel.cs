using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using UPS.Services;
using UPS.WPF.ViewModel;

namespace UPS.WPF
{
    public class EmployeeModel : ModelBase

    {
        private string firstName;
        private string gender;
        private string lastName;
        private string id;
        private string dob;
        private string email;
        private string phone;
        private string website;
        private string address;
        private string status;

        private ICommand saveEmployee1;
        private ICommand deleteEmployee1;
        private ICommand editEmployee;
        EmployeeService employeeService;

        public EmployeeModel()
        {
            SaveEmployee = new RelayCommand(t => saveEmployee(), t => true);
            DeleteEmployee = new RelayCommand(t => { this.deleteEmployee(); }, t => { return true; });
            employeeService = new EmployeeService();
        }

        public string Id { get => id; set => id = value; }
        public string FirstName
        {
            get => firstName; set
            {
                firstName = value;
                OnPropertyChange();
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                lastName = value;
                OnPropertyChange();
            }
        }
        public string Gender
        {
            get => gender; set
            {
                gender = value;
                OnPropertyChange();
            }
        }
        public string Dob
        {
            get => dob; set
            {
                dob = value;
                OnPropertyChange();
            }
        }
        public string Email
        {
            get => email; set
            {
                email = value;
                OnPropertyChange();
            }
        }
        public string Phone
        {
            get => phone; set
            {
                phone = value;
                OnPropertyChange();
            }
        }
        public string Website
        {
            get => website; set
            {
                website = value;
                OnPropertyChange();
            }
        }
        public string Address
        {
            get => address; set
            {
                address = value;
                OnPropertyChange();
            }
        }
        public string Status
        {
            get => status; set
            {
                status = value;
                OnPropertyChange();
            }
        }

        public ICommand EditEmployee { get => editEmployee; set => editEmployee = value; }
        public ICommand DeleteEmployee { get => deleteEmployee1; set => deleteEmployee1 = value; }
        public ICommand SaveEmployee { get => saveEmployee1; set => saveEmployee1 = value; }

        private void saveEmployee()
        {
            var entity = EmployeeMapper.modelToEntity(this);
            employeeService.SaveEmployee(entity);
        }

        private void deleteEmployee()
        {
            employeeService.DeleteEmployee(Convert.ToInt32(this.id));
        }
    }
}
