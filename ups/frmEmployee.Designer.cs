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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_EmployeeList)).BeginInit();
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
            this.dtg_EmployeeList.Location = new System.Drawing.Point(49, 61);
            this.dtg_EmployeeList.MultiSelect = false;
            this.dtg_EmployeeList.Name = "dtg_EmployeeList";
            this.dtg_EmployeeList.ReadOnly = true;
            this.dtg_EmployeeList.Size = new System.Drawing.Size(779, 377);
            this.dtg_EmployeeList.TabIndex = 3;
            // 
            // btn_NextPage
            // 
            this.btn_NextPage.Location = new System.Drawing.Point(834, 215);
            this.btn_NextPage.Name = "btn_NextPage";
            this.btn_NextPage.Size = new System.Drawing.Size(38, 23);
            this.btn_NextPage.TabIndex = 4;
            this.btn_NextPage.Text = ">";
            this.btn_NextPage.UseVisualStyleBackColor = true;
            this.btn_NextPage.Click += new System.EventHandler(this.btn_NextPage_Click);
            // 
            // btn_PreviousPage
            // 
            this.btn_PreviousPage.Location = new System.Drawing.Point(5, 215);
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
            this.lbl_PageIndicator.Location = new System.Drawing.Point(421, 445);
            this.lbl_PageIndicator.Name = "lbl_PageIndicator";
            this.lbl_PageIndicator.Size = new System.Drawing.Size(0, 13);
            this.lbl_PageIndicator.TabIndex = 6;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 488);
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
    }
}

