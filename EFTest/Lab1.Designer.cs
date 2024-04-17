
namespace EFTest
{
    partial class Lab1
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
            this.dgvLab1 = new System.Windows.Forms.DataGridView();
            this.employeeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLab1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLab1
            // 
            this.dgvLab1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLab1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeNumber,
            this.lastName,
            this.firstName});
            this.dgvLab1.Location = new System.Drawing.Point(80, 59);
            this.dgvLab1.Name = "dgvLab1";
            this.dgvLab1.Size = new System.Drawing.Size(343, 393);
            this.dgvLab1.TabIndex = 5;
            // 
            // employeeNumber
            // 
            this.employeeNumber.HeaderText = "empNo";
            this.employeeNumber.Name = "employeeNumber";
            // 
            // lastName
            // 
            this.lastName.HeaderText = "LastName";
            this.lastName.Name = "lastName";
            // 
            // firstName
            // 
            this.firstName.HeaderText = "FirstName";
            this.firstName.Name = "firstName";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(477, 363);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(348, 33);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 471);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(343, 20);
            this.textBox1.TabIndex = 7;
            // 
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(80, 33);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(245, 20);
            this.txtLab1.TabIndex = 6;
            this.txtLab1.TextChanged += new System.EventHandler(this.txtLab1_TextChanged);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 514);
            this.Controls.Add(this.dgvLab1);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtLab1);
            this.Name = "Lab1";
            this.Text = "Lab1";
            this.Load += new System.EventHandler(this.Lab1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtLab1;
    }
}