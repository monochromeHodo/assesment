namespace ups
{
    partial class frmAddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebSite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_EmployeeId = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.rdb_GenderF = new System.Windows.Forms.RadioButton();
            this.rdb_GenderM = new System.Windows.Forms.RadioButton();
            this.rdb_StatusI = new System.Windows.Forms.RadioButton();
            this.rdb_StatusA = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_Phone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(135, 44);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(135, 75);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(100, 20);
            this.txt_LastName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gender";
            // 
            // txt_EMail
            // 
            this.txt_EMail.Location = new System.Drawing.Point(135, 137);
            this.txt_EMail.Name = "txt_EMail";
            this.txt_EMail.Size = new System.Drawing.Size(100, 20);
            this.txt_EMail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail";
            // 
            // txtWebSite
            // 
            this.txtWebSite.Location = new System.Drawing.Point(135, 189);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(100, 20);
            this.txtWebSite.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Website";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Status";
            // 
            // lbl_EmployeeId
            // 
            this.lbl_EmployeeId.AutoSize = true;
            this.lbl_EmployeeId.Location = new System.Drawing.Point(132, 16);
            this.lbl_EmployeeId.Name = "lbl_EmployeeId";
            this.lbl_EmployeeId.Size = new System.Drawing.Size(10, 13);
            this.lbl_EmployeeId.TabIndex = 14;
            this.lbl_EmployeeId.Text = "-";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(79, 268);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Close.Location = new System.Drawing.Point(160, 268);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 16;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // rdb_GenderF
            // 
            this.rdb_GenderF.AutoSize = true;
            this.rdb_GenderF.Location = new System.Drawing.Point(135, 109);
            this.rdb_GenderF.Name = "rdb_GenderF";
            this.rdb_GenderF.Size = new System.Drawing.Size(31, 17);
            this.rdb_GenderF.TabIndex = 17;
            this.rdb_GenderF.TabStop = true;
            this.rdb_GenderF.Text = "F";
            this.rdb_GenderF.UseVisualStyleBackColor = true;
            // 
            // rdb_GenderM
            // 
            this.rdb_GenderM.AutoSize = true;
            this.rdb_GenderM.Location = new System.Drawing.Point(175, 109);
            this.rdb_GenderM.Name = "rdb_GenderM";
            this.rdb_GenderM.Size = new System.Drawing.Size(34, 17);
            this.rdb_GenderM.TabIndex = 18;
            this.rdb_GenderM.TabStop = true;
            this.rdb_GenderM.Text = "M";
            this.rdb_GenderM.UseVisualStyleBackColor = true;
            // 
            // rdb_StatusI
            // 
            this.rdb_StatusI.AutoSize = true;
            this.rdb_StatusI.Location = new System.Drawing.Point(175, 221);
            this.rdb_StatusI.Name = "rdb_StatusI";
            this.rdb_StatusI.Size = new System.Drawing.Size(28, 17);
            this.rdb_StatusI.TabIndex = 20;
            this.rdb_StatusI.TabStop = true;
            this.rdb_StatusI.Text = "I";
            this.rdb_StatusI.UseVisualStyleBackColor = true;
            // 
            // rdb_StatusA
            // 
            this.rdb_StatusA.AutoSize = true;
            this.rdb_StatusA.Location = new System.Drawing.Point(135, 221);
            this.rdb_StatusA.Name = "rdb_StatusA";
            this.rdb_StatusA.Size = new System.Drawing.Size(32, 17);
            this.rdb_StatusA.TabIndex = 19;
            this.rdb_StatusA.TabStop = true;
            this.rdb_StatusA.Text = "A";
            this.rdb_StatusA.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // txt_Phone
            // 
            this.txt_Phone.AutoSize = true;
            this.txt_Phone.Location = new System.Drawing.Point(13, 166);
            this.txt_Phone.Name = "txt_Phone";
            this.txt_Phone.Size = new System.Drawing.Size(38, 13);
            this.txt_Phone.TabIndex = 21;
            this.txt_Phone.Text = "Phone";
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Close;
            this.ClientSize = new System.Drawing.Size(249, 316);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_Phone);
            this.Controls.Add(this.rdb_StatusI);
            this.Controls.Add(this.rdb_StatusA);
            this.Controls.Add(this.rdb_GenderM);
            this.Controls.Add(this.rdb_GenderF);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_EmployeeId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtWebSite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_EMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_EmployeeId;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.RadioButton rdb_GenderF;
        private System.Windows.Forms.RadioButton rdb_GenderM;
        private System.Windows.Forms.RadioButton rdb_StatusI;
        private System.Windows.Forms.RadioButton rdb_StatusA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_Phone;
    }
}