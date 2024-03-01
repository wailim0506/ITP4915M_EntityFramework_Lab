
namespace EFTest
{
    partial class Form1
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
            this.dgvLab1.Location = new System.Drawing.Point(43, 45);
            this.dgvLab1.Name = "dgvLab1";
            this.dgvLab1.Size = new System.Drawing.Size(345, 150);
            this.dgvLab1.TabIndex = 0;
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
            // txtLab1
            // 
            this.txtLab1.Location = new System.Drawing.Point(43, 19);
            this.txtLab1.Name = "txtLab1";
            this.txtLab1.Size = new System.Drawing.Size(245, 20);
            this.txtLab1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLab1);
            this.Controls.Add(this.dgvLab1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLab1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLab1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.TextBox txtLab1;
    }
}

