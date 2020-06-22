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
    public partial class frmAddEmployee : Form
    {
        public frmAddEmployee()
        {
            InitializeComponent();
        }
        HttpClient httpClient = new HttpClient();
        public frmAddEmployee(Result result) : this()
        {
            Result = result;
        }

        public Result Result { get; set; } = new Result();

        private void frmAddEmployee_Load(object sender, EventArgs e)
        {
            httpClient.BaseAddress = new Uri("https://gorest.co.in/public-api/");
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "XxKuGhQz4GR3rbkcHgwjggX4smgStkZFt1k0");
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            lbl_EmployeeId.Text = Result.id;
            txt_FirstName.Text = Result.first_name;
            txt_LastName.Text = Result.last_name;
            txt_Phone.Text = Result.phone;
            txt_EMail.Text = Result.email;
            rdb_GenderF.Checked = Result.gender == "female";
            rdb_GenderM.Checked = Result.gender == "male";
            txtWebSite.Text = Result.website;
            rdb_StatusA.Checked = Result.status == "active";
            rdb_StatusI.Checked = Result.status == "inactive";




        }

        private async void btn_Save_Click(object sender, EventArgs e)
        {
            Result.first_name = txt_FirstName.Text;
            Result.last_name = txt_LastName.Text;
            Result.phone = txt_Phone.Text;
            Result.email = txt_EMail.Text;
            Result.gender = rdb_GenderF.Checked ? "female" : "male";
            Result.website = txtWebSite.Text;
            Result.status = rdb_StatusA.Checked ? "active" : "inactive";


            var json = JsonConvert.SerializeObject(Result);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response;

            if (string.IsNullOrEmpty(Result.id))
            {
                response = await httpClient.PostAsync("users", data);
            }
            else
            {
                response = await httpClient.PutAsync($"users/{Result.id}", data);
            }


            string result = await response.Content.ReadAsStringAsync();

        }
    }
}
