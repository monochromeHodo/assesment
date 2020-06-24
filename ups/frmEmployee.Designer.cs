namespace ups
{
    partial class frmEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_AddEmployee = new System.Windows.Forms.Button();
            this.btn_RemoveEmployee = new System.Windows.Forms.Button();
            this.btn_EditEmployee = new System.Windows.Forms.Button();
            this.dtg_EmployeeList = new System.Windows.Forms.DataGridView();
            this.btn_NextPage = new System.Windows.Forms.Button();
            this.btn_PreviousPage = new System.Windows.Forms.Button();
            this.lbl_PageIndicator = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SearchLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SearchEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SearchPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SearchWebsite = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_ClearSearch = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EmployeeList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AddEmployee
            // 
            this.btn_AddEmployee.Location = new System.Drawing.Point(12, 12);
            this.btn_AddEmployee.Name = "btn_AddEmployee";
            this.btn_AddEmployee.Size = new System.Drawing.Size(75, 43);
            this.btn_AddEmployee.TabIndex = 0;
            this.btn_AddEmployee.Text = "Add Employee";
            this.btn_AddEmployee.UseVisualStyleBackColor = true;
            this.btn_AddEmployee.Click += new System.EventHandler(this.btn_AddEmployee_Click);
            // 
            // btn_RemoveEmployee
            // 
            this.btn_RemoveEmployee.Location = new System.Drawing.Point(93, 12);
            this.btn_RemoveEmployee.Name = "btn_RemoveEmployee";
            this.btn_RemoveEmployee.Size = new System.Drawing.Size(75, 43);
            this.btn_RemoveEmployee.TabIndex = 1;
            this.btn_RemoveEmployee.Text = "Remove Employee";
            this.btn_RemoveEmployee.UseVisualStyleBackColor = true;
            this.btn_RemoveEmployee.Click += new System.EventHandler(this.btn_RemoveEmployee_Click);
            // 
            // btn_EditEmployee
            // 
            this.btn_EditEmployee.Location = new System.Drawing.Point(174, 12);
            this.btn_EditEmployee.Name = "btn_EditEmployee";
            this.btn_EditEmployee.Size = new System.Drawing.Size(75, 43);
            this.btn_EditEmployee.TabIndex = 2;
            this.btn_EditEmployee.Text = "Edit Employee";
            this.btn_EditEmployee.UseVisualStyleBackColor = true;
            this.btn_EditEmployee.Click += new System.EventHandler(this.btn_EditEmployee_Click);
            // 
            // dtg_EmployeeList
            // 
            this.dtg_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_EmployeeList.Location = new System.Drawing.Point(49, 102);
            this.dtg_EmployeeList.MultiSelect = false;
            this.dtg_EmployeeList.Name = "dtg_EmployeeList";
            this.dtg_EmployeeList.ReadOnly = true;
            this.dtg_EmployeeList.Size = new System.Drawing.Size(779, 377);
            this.dtg_EmployeeList.TabIndex = 3;
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(834, 256);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(38, 23);
            this.btn_NextPage.TabIndex = 4;
            this.btn_NextPage.Text = ">";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.Location = new System.Drawing.Point(5, 256);
            this.btn_PreviousPage.Name = "btn_PreviousPage";
            this.btn_PreviousPage.Size = new System.Drawing.Size(38, 23);
            this.btn_PreviousPage.TabIndex = 5;
            this.btn_PreviousPage.Text = "<";
            this.btn_PreviousPage.UseVisualStyleBackColor = true;
            this.btn_PreviousPage.Click += new System.EventHandler(this.btn_PreviousPage_Click);
            // 
            // lbl_PageIndicator
            // 
            this.lbl_PageIndicator.AutoSize = true;
            this.lbl_PageIndicator.Location = new System.Drawing.Point(421, 486);
            this.lbl_PageIndicator.Name = "lbl_PageIndicator";
            this.lbl_PageIndicator.Size = new System.Drawing.Size(0, 13);
            this.lbl_PageIndicator.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ClearSearch);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_SearchWebsite);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_SearchPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_SearchEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_SearchLastName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_SearchFirstName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(293, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 84);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Options";
            // 
            // txt_SearchFirstName
            // 
            this.txt_SearchFirstName.Location = new System.Drawing.Point(68, 23);
            this.txt_SearchFirstName.Name = "txt_SearchFirstName";
            this.txt_SearchFirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // txt_SearchLastName
            // 
            this.txt_SearchLastName.Location = new System.Drawing.Point(68, 49);
            this.txt_SearchLastName.Name = "txt_SearchLastName";
            this.txt_SearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchLastName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-Mail";
            // 
            // txt_SearchEmail
            // 
            this.txt_SearchEmail.Location = new System.Drawing.Point(235, 23);
            this.txt_SearchEmail.Name = "txt_SearchEmail";
            this.txt_SearchEmail.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // txt_SearchPhone
            // 
            this.txt_SearchPhone.Location = new System.Drawing.Point(235, 49);
            this.txt_SearchPhone.Name = "txt_SearchPhone";
            this.txt_SearchPhone.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(339, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Website";
            // 
            // txt_SearchWebsite
            // 
            this.txt_SearchWebsite.Location = new System.Drawing.Point(403, 23);
            this.txt_SearchWebsite.Name = "txt_SearchWebsite";
            this.txt_SearchWebsite.Size = new System.Drawing.Size(100, 20);
            this.txt_SearchWebsite.TabIndex = 9;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(367, 52);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_ClearSearch
            // 
            this.btn_ClearSearch.Location = new System.Drawing.Point(448, 52);
            this.btn_ClearSearch.Name = "btn_ClearSearch";
            this.btn_ClearSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_ClearSearch.TabIndex = 12;
            this.btn_ClearSearch.Text = "Clear";
            this.btn_ClearSearch.UseVisualStyleBackColor = true;
            this.btn_ClearSearch.Click += new System.EventHandler(this.btn_ClearSearch_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(753, 501);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 13;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 536);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_PageIndicator);
            this.Controls.Add(this.btn_PreviousPage);
            this.Controls.Add(this.btn_NextPage);
            this.Controls.Add(this.dtg_EmployeeList);
            this.Controls.Add(this.btn_EditEmployee);
            this.Controls.Add(this.btn_RemoveEmployee);
            this.Controls.Add(this.btn_AddEmployee);
            this.Name = "frmEmployee";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EmployeeList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddEmployee;
        private System.Windows.Forms.Button btn_RemoveEmployee;
        private System.Windows.Forms.Button btn_EditEmployee;
        private System.Windows.Forms.DataGridView dtg_EmployeeList;
        private System.Windows.Forms.Button btn_NextPage;
        private System.Windows.Forms.Button btn_PreviousPage;
        private System.Windows.Forms.Label lbl_PageIndicator;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_SearchEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SearchLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SearchFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SearchPhone;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SearchWebsite;
        private System.Windows.Forms.Button btn_ClearSearch;
        private System.Windows.Forms.Button btn_Export;
    }
}

