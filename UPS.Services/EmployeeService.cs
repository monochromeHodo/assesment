using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using UPS.Entities;

namespace UPS.Services
{
    public class EmployeeService
    {
        static HttpClient httpClient;
        static EmployeeService()
        {
            httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "XxKuGhQz4GR3rbkcHgwjggX4smgStkZFt1k0");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async void AddEmployee(Employee employee) 
        {
            var json = JsonConvert.SerializeObject(employee);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            if (string.IsNullOrEmpty(employee.id))
            {
                response = await httpClient.PostAsync("users", data);
            }
            else
            {
                response = await httpClient.PutAsync($"users/{employee.id}", data);
            }

        }

        public async void DeleteEmployee(int employeeId)
        {
            HttpResponseMessage response = await httpClient.DeleteAsync($"users/{employeeId}");



            string result = await response.Content.ReadAsStringAsync();
        }

        public void GetEmployee()
        {

        }

    }
}
