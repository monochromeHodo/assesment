using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ups
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }
        private int currentPage = 1;
        private int pageCount;
        string searchTerm = string.Empty;
        HttpClient httpClient = new HttpClient();
        private async void frmEmployee_Load(object sender, EventArgs e)
        {
            httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "XxKuGhQz4GR3rbkcHgwjggX4smgStkZFt1k0");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            dtg_EmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            

            dtg_EmployeeList.DataSource = await getEmployees();
          
        }

        private async Task<IEnumerable<Result>> getEmployees(int page = 1)
        {

            string responseBody = await httpClient.GetStringAsync($"users?page={page}{searchTerm}");

            var response = JsonConvert.DeserializeObject<Rootobject>(responseBody);
            pageCount = response._meta.pageCount;
            pageChanged();
            return response.result;
        }

        private async void btn_NextPage_Click(object sender, EventArgs e)
        {
            currentPage++;

            dtg_EmployeeList.DataSource = await getEmployees(currentPage);
        }

        private void pageChanged()
        {
            if (currentPage == pageCount)
            {
                btn_NextPage.Enabled = false;
            }
            else
            {
                btn_NextPage.Enabled = true;
            }
            if (currentPage == 1)
            {
                btn_PreviousPage.Enabled = false;
            }
            else
            {
                btn_PreviousPage.Enabled = true;
            }
            lbl_PageIndicator.Text = $"{currentPage}/{pageCount}";
        }

        private async void btn_PreviousPage_Click(object sender, EventArgs e)
        {
            currentPage--;

            dtg_EmployeeList.DataSource = await getEmployees(currentPage);
        }

        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            frmAddEmployee frmAddEmployee = new frmAddEmployee();
            frmAddEmployee.ShowDialog();
        }

        private void btn_EditEmployee_Click(object sender, EventArgs e)
        {
            if(dtg_EmployeeList.SelectedRows.Count==1)
            {
                var selectedEmployee= dtg_EmployeeList.SelectedRows[0].DataBoundItem as Result;

                frmAddEmployee frmAddEmployee = new frmAddEmployee(selectedEmployee);
                frmAddEmployee.ShowDialog();

            }
        }

        private async void btn_RemoveEmployee_Click(object sender, EventArgs e)
        {

            if (dtg_EmployeeList.SelectedRows.Count == 1)
            {
                var selectedEmployee = dtg_EmployeeList.SelectedRows[0].DataBoundItem as Result;

                HttpResponseMessage response = await httpClient.DeleteAsync($"users/{selectedEmployee.id}");

                

                string result = await response.Content.ReadAsStringAsync();
                pageChanged();
                

            }

           
        }

        private async void btn_Search_Click(object sender, EventArgs e)
        {
            Result searchResult = new Result();
            searchResult.first_name = txt_SearchFirstName.Text;
            searchResult.last_name = txt_SearchLastName.Text;
            searchResult.email = txt_SearchEmail.Text;
            searchResult.phone = txt_SearchPhone.Text;
            searchResult.website = txt_SearchWebsite.Text;

            var searchKeys = new List<string>();

            if(!string.IsNullOrEmpty(searchResult.first_name))
            {
                searchKeys.Add($"{nameof(searchResult.first_name)}={searchResult.first_name}");
            }
            if (!string.IsNullOrEmpty(searchResult.last_name))
            {
                searchKeys.Add($"{nameof(searchResult.last_name)}={searchResult.last_name}");
            }
            if (!string.IsNullOrEmpty(searchResult.email))
            {
                searchKeys.Add($"{nameof(searchResult.email)}={searchResult.email}");
            }
            if (!string.IsNullOrEmpty(searchResult.phone))
            {
                searchKeys.Add($"{nameof(searchResult.phone)}={searchResult.phone}");
            }
            if (!string.IsNullOrEmpty(searchResult.website))
            {
                searchKeys.Add($"{nameof(searchResult.website)}={searchResult.website}");
            }

            string searchString=string.Empty;

            foreach (var key in searchKeys)
            {
                searchString += $"&{key}";
            }

            searchTerm = searchString;
            currentPage = 1;
            pageChanged();

            dtg_EmployeeList.DataSource = await getEmployees(currentPage);

        }

        private async void btn_ClearSearch_Click(object sender, EventArgs e)
        {
            txt_SearchFirstName.Text=string.Empty;
            txt_SearchLastName.Text = string.Empty;
            txt_SearchEmail.Text = string.Empty;
            txt_SearchPhone.Text = string.Empty;
            txt_SearchWebsite.Text = string.Empty;

            searchTerm = string.Empty;

            currentPage = 1;
            pageChanged();

            dtg_EmployeeList.DataSource = await getEmployees(currentPage);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            frmExport frmExport = new frmExport(httpClient,currentPage, searchTerm);

            frmExport.ShowDialog();
        }
    }
}
