using System;
using System.Collections.Generic;
using System.Text;
using UPS.Entities.EmployeeEntities;

namespace UPS.WPF.ViewModel
{
    internal class EmployeeMapper
    {
        public  static Employee  modelToEntity(EmployeeModel employeeModel)
        {
            Employee employee = new Employee()
            {
                address = employeeModel.Address,
                dob = employeeModel.Dob,
                email = employeeModel.Email,
                first_name = employeeModel.FirstName,
                gender = employeeModel.Gender,
                id = employeeModel.Id,
                last_name = employeeModel.LastName,
                phone = employeeModel.Phone,
                status = employeeModel.Status,
                website = employeeModel.Website,
                
            };

            return employee;
        }

        public static EmployeeModel entityToModel(Employee employee)
        {
            EmployeeModel employeeModel = new EmployeeModel()
            {
                Address = employee.address,
                Dob = employee.dob,
                Email = employee.email,
                FirstName = employee.first_name,
                Gender = employee.gender,
                Id = employee.id,
                LastName = employee.last_name,
                Phone = employee.phone,
                Status = employee.status,
                Website = employee.website,
            };
            return employeeModel;
        }

        public static IEnumerable<EmployeeModel> entityListToModelList(IEnumerable< Employee> employeeList)
        {
            foreach (Employee employee in employeeList)
            {
                EmployeeModel employeeModel = new EmployeeModel()
                {
                    Address = employee.address,
                    Dob = employee.dob,
                    Email = employee.email,
                    FirstName = employee.first_name,
                    Gender = employee.gender,
                    Id = employee.id,
                    LastName = employee.last_name,
                    Phone = employee.phone,
                    Status = employee.status,
                    Website = employee.website,
                };
                yield return employeeModel;
            }

           
            
        }

    }
}
