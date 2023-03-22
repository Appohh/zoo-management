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
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.lb_more_details = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Profile = new System.Windows.Forms.ColumnHeader();
            this.EmployeeFirstName = new System.Windows.Forms.ColumnHeader();
            this.EmployeePhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.lv_Employees = new System.Windows.Forms.ListView();
            this.EmployeeLastName = new System.Windows.Forms.ColumnHeader();
            this.Employee_Role = new System.Windows.Forms.ColumnHeader();
            this.btn_add_employee_HR = new System.Windows.Forms.Button();
            this.lb_see_more = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.artanPanel3 = new Desktop_app.ArtanPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Lbl_search = new System.Windows.Forms.Label();
            this.artanPanel4 = new Desktop_app.ArtanPanel();
            this.btn_ViewDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            EmployeeEmail = new System.Windows.Forms.ColumnHeader();
            this.artanPanel3.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Text = "Email";
            EmployeeEmail.Width = 150;
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(68, 37);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(189, 25);
            this.EmployeeNameLabel.TabIndex = 7;
            this.EmployeeNameLabel.Text = "EmployeeNameLabel";
            this.EmployeeNameLabel.Visible = false;
            // 
            // lb_more_details
            // 
            this.lb_more_details.AutoSize = true;
            this.lb_more_details.BackColor = System.Drawing.Color.Transparent;
            this.lb_more_details.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_more_details.ForeColor = System.Drawing.Color.White;
            this.lb_more_details.Location = new System.Drawing.Point(98, 581);
            this.lb_more_details.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_more_details.Name = "lb_more_details";
            this.lb_more_details.Size = new System.Drawing.Size(176, 40);
            this.lb_more_details.TabIndex = 1;
            this.lb_more_details.Text = "More details";
            this.lb_more_details.Click += new System.EventHandler(this.lb_more_details_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(40, 130);
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
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Zoo Bazaar - HR /";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(167, 7);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Home";
            // 
            // Profile
            // 
            this.Profile.Text = "Profile";
            this.Profile.Width = 120;
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.Text = "FirstName";
            this.EmployeeFirstName.Width = 150;
            // 
            // EmployeePhoneNumber
            // 
            this.EmployeePhoneNumber.Text = "Phone Number";
            this.EmployeePhoneNumber.Width = 150;
            // 
            // lv_Employees
            // 
            this.lv_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lv_Employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Profile,
            this.EmployeeFirstName,
            this.EmployeeLastName,
            EmployeeEmail,
            this.EmployeePhoneNumber,
            this.Employee_Role});
            this.lv_Employees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Employees.ForeColor = System.Drawing.Color.White;
            this.lv_Employees.FullRowSelect = true;
            this.lv_Employees.Location = new System.Drawing.Point(11, 152);
            this.lv_Employees.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lv_Employees.Name = "lv_Employees";
            this.lv_Employees.Size = new System.Drawing.Size(871, 480);
            this.lv_Employees.TabIndex = 20;
            this.lv_Employees.UseCompatibleStateImageBehavior = false;
            this.lv_Employees.View = System.Windows.Forms.View.Details;
            this.lv_Employees.SelectedIndexChanged += new System.EventHandler(this.lv_Employees_SelectedIndexChanged);
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.Text = "LastName";
            this.EmployeeLastName.Width = 150;
            // 
            // Employee_Role
            // 
            this.Employee_Role.Text = "Role";
            this.Employee_Role.Width = 150;
            // 
            // btn_add_employee_HR
            // 
            this.btn_add_employee_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_add_employee_HR.Location = new System.Drawing.Point(896, 50);
            this.btn_add_employee_HR.Name = "btn_add_employee_HR";
            this.btn_add_employee_HR.Size = new System.Drawing.Size(199, 45);
            this.btn_add_employee_HR.TabIndex = 0;
            this.btn_add_employee_HR.Text = "Add new employee";
            this.btn_add_employee_HR.UseVisualStyleBackColor = false;
            this.btn_add_employee_HR.Click += new System.EventHandler(this.btn_add_employee_HR_Click);
            // 
            // lb_see_more
            // 
            this.lb_see_more.AutoSize = true;
            this.lb_see_more.BackColor = System.Drawing.Color.Transparent;
            this.lb_see_more.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_see_more.ForeColor = System.Drawing.Color.White;
            this.lb_see_more.Location = new System.Drawing.Point(877, 14);
            this.lb_see_more.Name = "lb_see_more";
            this.lb_see_more.Size = new System.Drawing.Size(218, 30);
            this.lb_see_more.TabIndex = 1;
            this.lb_see_more.Text = "See more Employees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome ......";
            // 
            // artanPanel3
            // 
            this.artanPanel3.BackColor = System.Drawing.Color.Black;
            this.artanPanel3.BorderRadius = 30;
            this.artanPanel3.Controls.Add(this.button2);
            this.artanPanel3.Controls.Add(this.button1);
            this.artanPanel3.ForeColor = System.Drawing.Color.Black;
            this.artanPanel3.GradientAngle = 90F;
            this.artanPanel3.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel3.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel3.Location = new System.Drawing.Point(11, 51);
            this.artanPanel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.artanPanel3.Name = "artanPanel3";
            this.artanPanel3.Size = new System.Drawing.Size(871, 84);
            this.artanPanel3.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(683, 9);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "See all employees";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(683, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.Location = new System.Drawing.Point(421, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 24;
            // 
            // Lbl_search
            // 
            this.Lbl_search.AutoSize = true;
            this.Lbl_search.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_search.ForeColor = System.Drawing.Color.White;
            this.Lbl_search.Location = new System.Drawing.Point(357, 11);
            this.Lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_search.Name = "Lbl_search";
            this.Lbl_search.Size = new System.Drawing.Size(65, 23);
            this.Lbl_search.TabIndex = 25;
            this.Lbl_search.Text = "Search:";
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.DimGray;
            this.artanPanel4.BorderRadius = 40;
            this.artanPanel4.Controls.Add(this.btn_ViewDetails);
            this.artanPanel4.Controls.Add(this.EmployeeNameLabel);
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel4.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.artanPanel4.Location = new System.Drawing.Point(911, 115);
            this.artanPanel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(325, 517);
            this.artanPanel4.TabIndex = 26;
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_ViewDetails.Location = new System.Drawing.Point(111, 461);
            this.btn_ViewDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(119, 35);
            this.btn_ViewDetails.TabIndex = 0;
            this.btn_ViewDetails.Text = "View Details";
            this.btn_ViewDetails.UseVisualStyleBackColor = false;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(970, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employee Information";
            // 
            // Human_Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1209, 685);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artanPanel4);
            this.Controls.Add(this.Lbl_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.artanPanel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Employees);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "Human_Resources";
            this.Text = "Human_Resources";
            this.Load += new System.EventHandler(this.Human_Resources_Load);
            this.artanPanel3.ResumeLayout(false);
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label EmployeeNameLabel;
        private Label lb_more_details;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private ColumnHeader Profile;
        private ColumnHeader EmployeeFirstName;
        private ColumnHeader EmployeePhoneNumber;
        private ListView lv_Employees;
        private Button btn_add_employee_HR;
        private Label lb_see_more;
        private ArtanPanel artanPanel1;
        private Label label2;
        private ArtanPanel artanPanel2;
        private ColumnHeader Employee_Role;
        private ColumnHeader EmployeeLastName;
        private ArtanPanel artanPanel3;
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label Lbl_search;
        private ArtanPanel artanPanel4;
        private Button btn_ViewDetails;
        private Label label3;
    }
}