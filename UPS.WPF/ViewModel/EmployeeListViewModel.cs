using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using UPS.Services;
using UPS.WPF.Model;

namespace UPS.WPF.ViewModel
{
    public class EmployeeListViewModel : ModelBase
    {
        ICommand nextPage;
        ICommand previousPage;
        ICommand firstPage;
        ICommand lastPage;
        MetaModel metamodel;
        public ICommand EditEmployee;
       
        EmployeeService employeeService;
        private IEnumerable<EmployeeModel> employeeModels;

        public IEnumerable<EmployeeModel> EmployeeModels
        {
            get => employeeModels; set
            {
                employeeModels = value;
                OnPropertyChange();
            }
        }

        public ICommand NextPage { get => nextPage; set => nextPage = value; }
        public ICommand PreviousPage { get => previousPage; set => previousPage = value; }
        public MetaModel Metamodel
        {
            get => metamodel; set
            {
                metamodel = value;
                OnPropertyChange();
            }
        }
        public ICommand FirstPage { get => firstPage; set => firstPage = value; }
        public ICommand LastPage { get => lastPage; set => lastPage = value; }

        public EmployeeListViewModel()
        {
            employeeService = new EmployeeService(); 
            this.metamodel=new MetaModel();
            NextPage = new RelayCommand(t => { Metamodel.CurrentPage++; getEmployees(); }, t => true);
            PreviousPage = new RelayCommand(t => { Metamodel.CurrentPage--; getEmployees(); }, t => true);
            FirstPage = new RelayCommand(t => { Metamodel.CurrentPage=1; getEmployees(); }, t => true);
            LastPage = new RelayCommand(t => 
            { 
                Metamodel.CurrentPage = Metamodel.PageCount; getEmployees(); 
            }, t => true);
            getEmployees();
        }
        

        private async void getEmployees(string searchTerm = "")
        {
            searchTerm = $"?page={metamodel.CurrentPage}";
            var employeeRootObject = await employeeService.GetEmployee(searchTerm);
            this.metamodel = MetaMapper.entityToModel(employeeRootObject._meta);
            EmployeeModels = EmployeeMapper.entityListToModelList(employeeRootObject.result);
        }

        
    }
}
