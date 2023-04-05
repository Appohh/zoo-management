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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Human_Resources));
            this.lb_more_details = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Namez = new System.Windows.Forms.ColumnHeader();
            this.EmployeePhoneNumber = new System.Windows.Forms.ColumnHeader();
            this.lv_Employees = new System.Windows.Forms.ListView();
            this.BirthDate = new System.Windows.Forms.ColumnHeader();
            this.EmployeeJob = new System.Windows.Forms.ColumnHeader();
            this.btn_add_employee_HR = new System.Windows.Forms.Button();
            this.lb_see_more = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_Overview = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.artanPanel4 = new Desktop_app.ArtanPanel();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.btn_ViewDetails = new System.Windows.Forms.Button();
            this.Tab_Add_Employee = new System.Windows.Forms.TabPage();
            this.Tab_Update_Employee = new System.Windows.Forms.TabPage();
            EmployeeEmail = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.Tab_Overview.SuspendLayout();
            this.artanPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Text = "Email";
            EmployeeEmail.Width = 250;
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
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.label4.Location = new System.Drawing.Point(166, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Home";
            // 
            // Name
            // 
            this.Name.Text = "Spouse";
            this.Name.Width = 300;
            // 
            // Namez
            // 
            this.Namez.Text = "Name";
            this.Namez.Width = 250;
            // 
            // EmployeePhoneNumber
            // 
            this.EmployeePhoneNumber.Text = "Phone Number";
            this.EmployeePhoneNumber.Width = 350;
            // 
            // lv_Employees
            // 
            this.lv_Employees.BackColor = System.Drawing.Color.SkyBlue;
            this.lv_Employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namez,
            EmployeeEmail,
            this.BirthDate,
            this.EmployeePhoneNumber,
            this.EmployeeJob,
            this.Name});
            this.lv_Employees.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Employees.ForeColor = System.Drawing.Color.White;
            this.lv_Employees.FullRowSelect = true;
            this.lv_Employees.Location = new System.Drawing.Point(34, 162);
            this.lv_Employees.Margin = new System.Windows.Forms.Padding(4);
            this.lv_Employees.Name = "lv_Employees";
            this.lv_Employees.Size = new System.Drawing.Size(1317, 651);
            this.lv_Employees.TabIndex = 20;
            this.lv_Employees.UseCompatibleStateImageBehavior = false;
            this.lv_Employees.View = System.Windows.Forms.View.Details;
            this.lv_Employees.SelectedIndexChanged += new System.EventHandler(this.lv_Employees_SelectedIndexChanged_1);
            // 
            // BirthDate
            // 
            this.BirthDate.Text = "BirthDate";
            this.BirthDate.Width = 300;
            // 
            // EmployeeJob
            // 
            this.EmployeeJob.Text = "Job";
            this.EmployeeJob.Width = 300;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1430, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 37);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employee Information";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1181, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 42);
            this.button3.TabIndex = 28;
            this.button3.Text = "Logout";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_Overview);
            this.tabControl1.Controls.Add(this.Tab_Add_Employee);
            this.tabControl1.Controls.Add(this.Tab_Update_Employee);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1865, 1029);
            this.tabControl1.TabIndex = 27;
            // 
            // Tab_Overview
            // 
            this.Tab_Overview.BackColor = System.Drawing.Color.Black;
            this.Tab_Overview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tab_Overview.BackgroundImage")));
            this.Tab_Overview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Tab_Overview.Controls.Add(this.button3);
            this.Tab_Overview.Controls.Add(this.label5);
            this.Tab_Overview.Controls.Add(this.textBox1);
            this.Tab_Overview.Controls.Add(this.lv_Employees);
            this.Tab_Overview.Controls.Add(this.label3);
            this.Tab_Overview.Controls.Add(this.artanPanel4);
            this.Tab_Overview.ForeColor = System.Drawing.Color.White;
            this.Tab_Overview.Location = new System.Drawing.Point(4, 29);
            this.Tab_Overview.Margin = new System.Windows.Forms.Padding(2);
            this.Tab_Overview.Name = "Tab_Overview";
            this.Tab_Overview.Padding = new System.Windows.Forms.Padding(2);
            this.Tab_Overview.Size = new System.Drawing.Size(1857, 996);
            this.Tab_Overview.TabIndex = 0;
            this.Tab_Overview.Text = "Overview";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 37);
            this.label5.TabIndex = 29;
            this.label5.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 27);
            this.textBox1.TabIndex = 28;
            // 
            // artanPanel4
            // 
            this.artanPanel4.BackColor = System.Drawing.Color.Transparent;
            this.artanPanel4.BorderRadius = 40;
            this.artanPanel4.Controls.Add(this.lbEmployeeName);
            this.artanPanel4.Controls.Add(this.btn_ViewDetails);
            this.artanPanel4.ForeColor = System.Drawing.Color.Black;
            this.artanPanel4.GradientAngle = 90F;
            this.artanPanel4.GradientBottomColor = System.Drawing.Color.DimGray;
            this.artanPanel4.GradientTopColor = System.Drawing.Color.DeepSkyBlue;
            this.artanPanel4.Location = new System.Drawing.Point(1380, 162);
            this.artanPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.artanPanel4.Name = "artanPanel4";
            this.artanPanel4.Size = new System.Drawing.Size(378, 651);
            this.artanPanel4.TabIndex = 26;
            this.artanPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.artanPanel4_Paint);
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lbEmployeeName.Location = new System.Drawing.Point(135, 58);
            this.lbEmployeeName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(0, 35);
            this.lbEmployeeName.TabIndex = 30;
            this.lbEmployeeName.Click += new System.EventHandler(this.lbEmployeeName_Click);
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ViewDetails.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ViewDetails.Location = new System.Drawing.Point(103, 522);
            this.btn_ViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(184, 44);
            this.btn_ViewDetails.TabIndex = 0;
            this.btn_ViewDetails.Text = "View Details";
            this.btn_ViewDetails.UseVisualStyleBackColor = false;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click_1);
            // 
            // Tab_Add_Employee
            // 
            this.Tab_Add_Employee.Location = new System.Drawing.Point(4, 29);
            this.Tab_Add_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.Tab_Add_Employee.Name = "Tab_Add_Employee";
            this.Tab_Add_Employee.Padding = new System.Windows.Forms.Padding(2);
            this.Tab_Add_Employee.Size = new System.Drawing.Size(1916, 996);
            this.Tab_Add_Employee.TabIndex = 1;
            this.Tab_Add_Employee.Text = "Add Employee";
            this.Tab_Add_Employee.UseVisualStyleBackColor = true;
            // 
            // Tab_Update_Employee
            // 
            this.Tab_Update_Employee.Location = new System.Drawing.Point(4, 29);
            this.Tab_Update_Employee.Margin = new System.Windows.Forms.Padding(2);
            this.Tab_Update_Employee.Name = "Tab_Update_Employee";
            this.Tab_Update_Employee.Size = new System.Drawing.Size(1916, 996);
            this.Tab_Update_Employee.TabIndex = 2;
            this.Tab_Update_Employee.Text = "Update Employee";
            this.Tab_Update_Employee.UseVisualStyleBackColor = true;
            // 
            // Human_Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1865, 1029);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            
            this.Text = "Human_Resources";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Tab_Overview.ResumeLayout(false);
            this.Tab_Overview.PerformLayout();
            this.artanPanel4.ResumeLayout(false);
            this.artanPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lb_more_details;
        private Panel panel3;
        private Label label1;
        private Label label4;
        private ColumnHeader Name;
        private ColumnHeader Namez;
        private ColumnHeader EmployeePhoneNumber;
        private ListView lv_Employees;
        private Button btn_add_employee_HR;
        private Label lb_see_more;
        private ArtanPanel artanPanel1;
        private Label label2;
        private ArtanPanel artanPanel2;
        private ColumnHeader EmployeeJob;
        private Label label3;
        private ColumnHeader BirthDate;
        private Button button3;
        private TabControl tabControl1;
        private TabPage Tab_Overview;
        private Label label5;
        private TextBox textBox1;
        private ArtanPanel artanPanel4;
        private Button btn_ViewDetails;
        private TabPage Tab_Add_Employee;
        private TabPage Tab_Update_Employee;
        private Label lbEmployeeName;
    }
}