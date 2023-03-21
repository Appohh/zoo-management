namespace Desktop_app
{
    partial class Human_Resources
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_see_more = new System.Windows.Forms.Label();
            this.btn_add_employee_HR = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_more_details = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmployeeID = new System.Windows.Forms.ColumnHeader();
            this.EmployeeName = new System.Windows.Forms.ColumnHeader();
            this.EmployeePhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.lbx_Employees = new System.Windows.Forms.ListView();
            EmployeeEmail = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lb_see_more);
            this.panel1.Controls.Add(this.btn_add_employee_HR);
            this.panel1.Location = new System.Drawing.Point(14, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 113);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome ......";
            // 
            // lb_see_more
            // 
            this.lb_see_more.AutoSize = true;
            this.lb_see_more.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_see_more.ForeColor = System.Drawing.Color.White;
            this.lb_see_more.Location = new System.Drawing.Point(873, 23);
            this.lb_see_more.Name = "lb_see_more";
            this.lb_see_more.Size = new System.Drawing.Size(218, 30);
            this.lb_see_more.TabIndex = 1;
            this.lb_see_more.Text = "See more Employees";
            // 
            // btn_add_employee_HR
            // 
            this.btn_add_employee_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_add_employee_HR.Location = new System.Drawing.Point(892, 59);
            this.btn_add_employee_HR.Name = "btn_add_employee_HR";
            this.btn_add_employee_HR.Size = new System.Drawing.Size(199, 45);
            this.btn_add_employee_HR.TabIndex = 0;
            this.btn_add_employee_HR.Text = "Add new employee";
            this.btn_add_employee_HR.UseVisualStyleBackColor = false;
            this.btn_add_employee_HR.Click += new System.EventHandler(this.btn_add_employee_HR_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1215, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Employee info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lb_more_details);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(1171, 111);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 679);
            this.panel2.TabIndex = 8;
            // 
            // lb_more_details
            // 
            this.lb_more_details.AutoSize = true;
            this.lb_more_details.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_more_details.ForeColor = System.Drawing.Color.White;
            this.lb_more_details.Location = new System.Drawing.Point(78, 597);
            this.lb_more_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_more_details.Name = "lb_more_details";
            this.lb_more_details.Size = new System.Drawing.Size(176, 40);
            this.lb_more_details.TabIndex = 1;
            this.lb_more_details.Text = "More details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(20, 113);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 7);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 30);
            this.label1.TabIndex = 21;
            this.label1.Text = "Zoo Bazaar - HR /";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(207, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 22;
            this.label4.Text = "Home";
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
            // lbx_Employees
            // 
            this.lbx_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbx_Employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmployeeID,
            this.EmployeeName,
            EmployeeEmail,
            this.EmployeePhoneNumber});
            this.lbx_Employees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbx_Employees.ForeColor = System.Drawing.Color.White;
            this.lbx_Employees.FullRowSelect = true;
            this.lbx_Employees.Location = new System.Drawing.Point(14, 190);
            this.lbx_Employees.Margin = new System.Windows.Forms.Padding(5);
            this.lbx_Employees.Name = "lbx_Employees";
            this.lbx_Employees.Size = new System.Drawing.Size(1117, 600);
            this.lbx_Employees.TabIndex = 20;
            this.lbx_Employees.UseCompatibleStateImageBehavior = false;
            this.lbx_Employees.View = System.Windows.Forms.View.Details;
            // 
            // Human_Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1573, 847);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_Employees);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Human_Resources";
            this.Text = "Human_Resources";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label lb_see_more;
        private Button btn_add_employee_HR;
        private Label label3;
        private Panel panel2;
        private Label lb_more_details;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private ColumnHeader EmployeeID;
        private ColumnHeader EmployeeName;
        private ColumnHeader EmployeePhoneNumber;
        private ListView lbx_Employees;
    }
}