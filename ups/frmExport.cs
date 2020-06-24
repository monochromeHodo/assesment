using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ups
{
    public partial class frmExport : Form
    {
        private int currentPage;
        private readonly string searchTerm;
        private readonly IEnumerable<Result> results;
        HttpClient httpClient;
        public frmExport(HttpClient httpClient, int currentPage, string searchTerm)
        {
            InitializeComponent();
            this.httpClient = httpClient;
            this.currentPage = currentPage;
            this.searchTerm = searchTerm;
        }

        public frmExport(IEnumerable<Result> results)
        {
            InitializeComponent();
            this.results = results;
        }

        private  void btn_ExportToCsv_Click(object sender, EventArgs e)
        {
            string delimitter;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Csv files (*.csv)|*.csv";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bool isSucceed=false;
                try
                {
                    if (rdb_DelimitterOther.Checked)
                    {
                        delimitter = txt_DelimitterOther.Text;
                    }
                    else if (rdb_DelimitterTab.Checked)
                    {
                        delimitter = "\t";
                    }
                    else
                    {
                        delimitter = ",";
                    }

                    StringBuilder csvExportString = new StringBuilder();
                    foreach (Result result in results)
                    {
                        string row = $"{result.id}{delimitter}{result.first_name}{delimitter}{result.last_name}{delimitter}{result.gender}{delimitter}{result.dob}{delimitter}{result.email}{delimitter}{result.phone}{delimitter}{result.website}{delimitter}{result.address.Replace(Environment.NewLine, "")}{delimitter}{result.status}";
                        csvExportString.AppendLine(row);
                    }

                    
                    File.WriteAllText(saveFileDialog.FileName, csvExportString.ToString());
                    isSucceed = true;
                }
                catch
                {
                    MessageBox.Show("An error occured while exporting.");
                }
                finally
                {
                    if(isSucceed)
                    {
                        MessageBox.Show($"List exported to file {saveFileDialog.FileName} successfully");
                        this.Close();
                    }
                }
               
            }

        }
    }
}
