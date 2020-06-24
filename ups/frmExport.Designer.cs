namespace ups
{
    partial class frmExport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdb_DelimitterOther = new System.Windows.Forms.RadioButton();
            this.rdb_DelimitterTab = new System.Windows.Forms.RadioButton();
            this.rdb_DelimitterComma = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DelimitterOther = new System.Windows.Forms.TextBox();
            this.btn_ExportToCsv = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delimtter";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdb_DelimitterOther);
            this.panel1.Controls.Add(this.rdb_DelimitterTab);
            this.panel1.Controls.Add(this.rdb_DelimitterComma);
            this.panel1.Location = new System.Drawing.Point(68, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 22);
            this.panel1.TabIndex = 1;
            // 
            // rdb_DelimitterOther
            // 
            this.rdb_DelimitterOther.AutoSize = true;
            this.rdb_DelimitterOther.Location = new System.Drawing.Point(142, 2);
            this.rdb_DelimitterOther.Name = "rdb_DelimitterOther";
            this.rdb_DelimitterOther.Size = new System.Drawing.Size(51, 17);
            this.rdb_DelimitterOther.TabIndex = 2;
            this.rdb_DelimitterOther.TabStop = true;
            this.rdb_DelimitterOther.Text = "Other";
            this.rdb_DelimitterOther.UseVisualStyleBackColor = true;
            // 
            // rdb_DelimitterTab
            // 
            this.rdb_DelimitterTab.AutoSize = true;
            this.rdb_DelimitterTab.Location = new System.Drawing.Point(92, 2);
            this.rdb_DelimitterTab.Name = "rdb_DelimitterTab";
            this.rdb_DelimitterTab.Size = new System.Drawing.Size(44, 17);
            this.rdb_DelimitterTab.TabIndex = 1;
            this.rdb_DelimitterTab.TabStop = true;
            this.rdb_DelimitterTab.Text = "Tab";
            this.rdb_DelimitterTab.UseVisualStyleBackColor = true;
            // 
            // rdb_DelimitterComma
            // 
            this.rdb_DelimitterComma.AutoSize = true;
            this.rdb_DelimitterComma.Location = new System.Drawing.Point(17, 2);
            this.rdb_DelimitterComma.Name = "rdb_DelimitterComma";
            this.rdb_DelimitterComma.Size = new System.Drawing.Size(69, 17);
            this.rdb_DelimitterComma.TabIndex = 0;
            this.rdb_DelimitterComma.TabStop = true;
            this.rdb_DelimitterComma.Text = "Comma(,)";
            this.rdb_DelimitterComma.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Other";
            // 
            // txt_DelimitterOther
            // 
            this.txt_DelimitterOther.Location = new System.Drawing.Point(68, 43);
            this.txt_DelimitterOther.Name = "txt_DelimitterOther";
            this.txt_DelimitterOther.Size = new System.Drawing.Size(32, 20);
            this.txt_DelimitterOther.TabIndex = 3;
            // 
            // btn_ExportToCsv
            // 
            this.btn_ExportToCsv.Location = new System.Drawing.Point(196, 70);
            this.btn_ExportToCsv.Name = "btn_ExportToCsv";
            this.btn_ExportToCsv.Size = new System.Drawing.Size(75, 23);
            this.btn_ExportToCsv.TabIndex = 5;
            this.btn_ExportToCsv.Text = "Export";
            this.btn_ExportToCsv.UseVisualStyleBackColor = true;
            this.btn_ExportToCsv.Click += new System.EventHandler(this.btn_ExportToCsv_Click);
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 107);
            this.Controls.Add(this.btn_ExportToCsv);
            this.Controls.Add(this.txt_DelimitterOther);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmExport";
            this.Text = "frmExport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdb_DelimitterOther;
        private System.Windows.Forms.RadioButton rdb_DelimitterTab;
        private System.Windows.Forms.RadioButton rdb_DelimitterComma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DelimitterOther;
        private System.Windows.Forms.Button btn_ExportToCsv;
    }
}