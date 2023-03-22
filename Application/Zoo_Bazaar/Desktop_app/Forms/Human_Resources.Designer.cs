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
            ColumnHeader EmployeeEmail;
            EmployeeNameLabel = new Label();
            lb_more_details = new Label();
            panel3 = new Panel();
            label1 = new Label();
            label4 = new Label();
            Name = new ColumnHeader();
            Namez = new ColumnHeader();
            EmployeePhoneNumber = new ColumnHeader();
            lv_Employees = new ListView();
            BirthDate = new ColumnHeader();
            EmployeeJob = new ColumnHeader();
            btn_add_employee_HR = new Button();
            lb_see_more = new Label();
            label2 = new Label();
            artanPanel3 = new ArtanPanel();
            button2 = new Button();
            button1 = new Button();
            artanPanel4 = new ArtanPanel();
            btn_ViewDetails = new Button();
            label3 = new Label();
            EmployeeEmail = new ColumnHeader();
            artanPanel3.SuspendLayout();
            artanPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Text = "City";
            EmployeeEmail.Width = 150;
            // 
            // EmployeeNameLabel
            // 
            EmployeeNameLabel.AutoSize = true;
            EmployeeNameLabel.BackColor = Color.Transparent;
            EmployeeNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            EmployeeNameLabel.ForeColor = Color.White;
            EmployeeNameLabel.Location = new Point(86, 59);
            EmployeeNameLabel.Margin = new Padding(4, 0, 4, 0);
            EmployeeNameLabel.Name = "EmployeeNameLabel";
            EmployeeNameLabel.Size = new Size(0, 25);
            EmployeeNameLabel.TabIndex = 7;
            // 
            // lb_more_details
            // 
            lb_more_details.AutoSize = true;
            lb_more_details.BackColor = Color.Transparent;
            lb_more_details.Font = new Font("Segoe UI", 14.25F, FontStyle.Underline, GraphicsUnit.Point);
            lb_more_details.ForeColor = Color.White;
            lb_more_details.Location = new Point(98, 581);
            lb_more_details.Margin = new Padding(4, 0, 4, 0);
            lb_more_details.Name = "lb_more_details";
            lb_more_details.Size = new Size(176, 40);
            lb_more_details.TabIndex = 1;
            lb_more_details.Text = "More details";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(40, 130);
            panel3.Margin = new Padding(4, 5, 4, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(299, 7);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 8);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 21;
            label1.Text = "Zoo Bazaar - HR /";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(221, 66, 76);
            label4.Location = new Point(167, 8);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 22;
            label4.Text = "Home";
            // 
            // Name
            // 
            Name.Text = "Spouse";
            Name.Width = 120;
            // 
            // Namez
            // 
            Namez.Text = "Name";
            Namez.Width = 150;
            // 
            // EmployeePhoneNumber
            // 
            EmployeePhoneNumber.Text = "Phone Number";
            EmployeePhoneNumber.Width = 150;
            // 
            // lv_Employees
            // 
            lv_Employees.BackColor = Color.FromArgb(44, 44, 44);
            lv_Employees.BorderStyle = BorderStyle.None;
            lv_Employees.Columns.AddRange(new ColumnHeader[] { Namez, EmployeeEmail, BirthDate, EmployeePhoneNumber, EmployeeJob, Name });
            lv_Employees.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lv_Employees.ForeColor = Color.White;
            lv_Employees.FullRowSelect = true;
            lv_Employees.Location = new Point(12, 152);
            lv_Employees.Margin = new Padding(4, 4, 4, 4);
            lv_Employees.Name = "lv_Employees";
            lv_Employees.Size = new Size(871, 480);
            lv_Employees.TabIndex = 20;
            lv_Employees.UseCompatibleStateImageBehavior = false;
            lv_Employees.View = View.Details;
            lv_Employees.SelectedIndexChanged += lv_Employees_SelectedIndexChanged;
            // 
            // BirthDate
            // 
            BirthDate.Text = "BirthDate";
            BirthDate.Width = 150;
            // 
            // EmployeeJob
            // 
            EmployeeJob.Text = "Job";
            EmployeeJob.Width = 150;
            // 
            // btn_add_employee_HR
            // 
            btn_add_employee_HR.BackColor = Color.FromArgb(221, 66, 76);
            btn_add_employee_HR.Location = new Point(896, 50);
            btn_add_employee_HR.Name = "btn_add_employee_HR";
            btn_add_employee_HR.Size = new Size(199, 45);
            btn_add_employee_HR.TabIndex = 0;
            btn_add_employee_HR.Text = "Add new employee";
            btn_add_employee_HR.UseVisualStyleBackColor = false;
            // 
            // lb_see_more
            // 
            lb_see_more.AutoSize = true;
            lb_see_more.BackColor = Color.Transparent;
            lb_see_more.Font = new Font("Segoe UI", 11F, FontStyle.Underline, GraphicsUnit.Point);
            lb_see_more.ForeColor = Color.White;
            lb_see_more.Location = new Point(877, 14);
            lb_see_more.Name = "lb_see_more";
            lb_see_more.Size = new Size(218, 30);
            lb_see_more.TabIndex = 1;
            lb_see_more.Text = "See more Employees";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(34, 17);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 2;
            label2.Text = "Welcome ......";
            // 
            // artanPanel3
            // 
            artanPanel3.BackColor = Color.Black;
            artanPanel3.BorderRadius = 30;
            artanPanel3.Controls.Add(button2);
            artanPanel3.Controls.Add(button1);
            artanPanel3.ForeColor = Color.Black;
            artanPanel3.GradientAngle = 90F;
            artanPanel3.GradientBottomColor = Color.FromArgb(44, 44, 44);
            artanPanel3.GradientTopColor = Color.FromArgb(44, 44, 44);
            artanPanel3.Location = new Point(12, 51);
            artanPanel3.Margin = new Padding(2, 2, 2, 2);
            artanPanel3.Name = "artanPanel3";
            artanPanel3.Size = new Size(871, 84);
            artanPanel3.TabIndex = 23;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(221, 66, 76);
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(493, 44);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(169, 29);
            button2.TabIndex = 1;
            button2.Text = "Refresh";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 66, 76);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(684, 44);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(169, 29);
            button1.TabIndex = 0;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // artanPanel4
            // 
            artanPanel4.BackColor = Color.DimGray;
            artanPanel4.BorderRadius = 40;
            artanPanel4.Controls.Add(btn_ViewDetails);
            artanPanel4.Controls.Add(EmployeeNameLabel);
            artanPanel4.ForeColor = Color.Black;
            artanPanel4.GradientAngle = 90F;
            artanPanel4.GradientBottomColor = Color.FromArgb(44, 44, 44);
            artanPanel4.GradientTopColor = Color.FromArgb(64, 64, 64);
            artanPanel4.Location = new Point(911, 114);
            artanPanel4.Margin = new Padding(2, 2, 2, 2);
            artanPanel4.Name = "artanPanel4";
            artanPanel4.Size = new Size(324, 518);
            artanPanel4.TabIndex = 26;
            // 
            // btn_ViewDetails
            // 
            btn_ViewDetails.BackColor = Color.FromArgb(221, 66, 76);
            btn_ViewDetails.Location = new Point(111, 461);
            btn_ViewDetails.Margin = new Padding(2, 2, 2, 2);
            btn_ViewDetails.Name = "btn_ViewDetails";
            btn_ViewDetails.Size = new Size(119, 34);
            btn_ViewDetails.TabIndex = 0;
            btn_ViewDetails.Text = "View Details";
            btn_ViewDetails.UseVisualStyleBackColor = false;
            btn_ViewDetails.Click += btn_ViewDetails_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(969, 87);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 25);
            label3.TabIndex = 27;
            label3.Text = "Employee Information";
            // 
            // Human_Resources
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 22, 24);
            ClientSize = new Size(1244, 642);
            Controls.Add(artanPanel4);
            Controls.Add(artanPanel3);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lv_Employees);
            Controls.Add(label3);
            Margin = new Padding(4, 1, 4, 1);
            //Name = "Human_Resources";
            Text = "Human_Resources";
            artanPanel3.ResumeLayout(false);
            artanPanel4.ResumeLayout(false);
            artanPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label EmployeeNameLabel;
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
        private ArtanPanel artanPanel3;
        private Button button1;
        private ArtanPanel artanPanel4;
        private Button btn_ViewDetails;
        private Label label3;
        private ColumnHeader BirthDate;
        private Button button2;
    }
}