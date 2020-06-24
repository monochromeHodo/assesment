using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace UPS.WPF
{
    public class EmployeeModel : INotifyPropertyChanged

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
