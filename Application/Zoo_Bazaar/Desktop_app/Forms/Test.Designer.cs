﻿namespace Desktop_app.Forms
{
    partial class Test
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
            System.Windows.Forms.ColumnHeader EmployeeEmail;
            this.LV_HumanResources = new System.Windows.Forms.ListView();
            this.EmployeeID = new System.Windows.Forms.ColumnHeader();
            this.EmployeeName = new System.Windows.Forms.ColumnHeader();
            this.EmployeePhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.NameBoxHR = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_employee_HR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            EmployeeEmail = new System.Windows.Forms.ColumnHeader();
            this.NameBoxHR.SuspendLayout();
            this.SuspendLayout();
            // 
            // LV_HumanResources
            // 
            this.LV_HumanResources.BackColor = System.Drawing.Color.LightGray;
            this.LV_HumanResources.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.EmployeeName,
            EmployeeEmail,
            this.EmployeePhoneNumber});
            this.LV_HumanResources.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LV_HumanResources.GridLines = true;
            this.LV_HumanResources.Location = new System.Drawing.Point(3, 145);
            this.LV_HumanResources.Name = "LV_HumanResources";
            this.LV_HumanResources.Size = new System.Drawing.Size(555, 386);
            this.LV_HumanResources.TabIndex = 19;
            this.LV_HumanResources.UseCompatibleStateImageBehavior = false;
            this.LV_HumanResources.View = System.Windows.Forms.View.Details;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Text = "Employee Id";
            this.EmployeeID.Width = 100;
            // 
            // EmployeeName
            // 
            this.EmployeeName.Text = "Name";
            this.EmployeeName.Width = 150;
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Text = "Email";
            EmployeeEmail.Width = 150;
            // 
            // EmployeePhoneNumber
            // 
            this.EmployeePhoneNumber.Text = "Phone Number";
            this.EmployeePhoneNumber.Width = 150;
            // 
            // NameBoxHR
            // 
            this.NameBoxHR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.NameBoxHR.Controls.Add(this.button2);
            this.NameBoxHR.Controls.Add(this.textBox1);
            this.NameBoxHR.Controls.Add(this.label1);
            this.NameBoxHR.Controls.Add(this.button1);
            this.NameBoxHR.Controls.Add(this.label2);
            this.NameBoxHR.Controls.Add(this.btn_add_employee_HR);
            this.NameBoxHR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameBoxHR.Location = new System.Drawing.Point(3, 1);
            this.NameBoxHR.Margin = new System.Windows.Forms.Padding(2);
            this.NameBoxHR.Name = "NameBoxHR";
            this.NameBoxHR.Size = new System.Drawing.Size(1121, 139);
            this.NameBoxHR.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(503, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Human Resources";
            // 
            // btn_add_employee_HR
            // 
            this.btn_add_employee_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_add_employee_HR.Location = new System.Drawing.Point(825, 82);
            this.btn_add_employee_HR.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_employee_HR.Name = "btn_add_employee_HR";
            this.btn_add_employee_HR.Size = new System.Drawing.Size(159, 36);
            this.btn_add_employee_HR.TabIndex = 0;
            this.btn_add_employee_HR.Text = "Add new employee";
            this.btn_add_employee_HR.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button1.Location = new System.Drawing.Point(825, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "See All Employees";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(13, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "aa";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button2.Location = new System.Drawing.Point(189, 73);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 36);
            this.button2.TabIndex = 24;
            this.button2.Text = "Search Employee";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1122, 585);
            this.Controls.Add(this.NameBoxHR);
            this.Controls.Add(this.LV_HumanResources);
            this.Name = "Test";
            this.Text = "Test";
            this.NameBoxHR.ResumeLayout(false);
            this.NameBoxHR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView LV_HumanResources;
        private ColumnHeader EmployeeID;
        private ColumnHeader EmployeeName;
        private ColumnHeader EmployeePhoneNumber;
        private Panel NameBoxHR;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Button btn_add_employee_HR;
    }
}