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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_see_more = new System.Windows.Forms.Label();
            this.btn_add_employee_HR = new System.Windows.Forms.Button();
            this.lbx_Employees = new System.Windows.Forms.ListBox();
            this.lbx_test = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_more_details = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.Location = new System.Drawing.Point(10, 23);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 76);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome ......";
            // 
            // lb_see_more
            // 
            this.lb_see_more.AutoSize = true;
            this.lb_see_more.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_see_more.ForeColor = System.Drawing.Color.White;
            this.lb_see_more.Location = new System.Drawing.Point(568, 14);
            this.lb_see_more.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_see_more.Name = "lb_see_more";
            this.lb_see_more.Size = new System.Drawing.Size(148, 20);
            this.lb_see_more.TabIndex = 1;
            this.lb_see_more.Text = "See more Employees";
            // 
            // btn_add_employee_HR
            // 
            this.btn_add_employee_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_add_employee_HR.Location = new System.Drawing.Point(577, 40);
            this.btn_add_employee_HR.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_employee_HR.Name = "btn_add_employee_HR";
            this.btn_add_employee_HR.Size = new System.Drawing.Size(139, 27);
            this.btn_add_employee_HR.TabIndex = 0;
            this.btn_add_employee_HR.Text = "Add new employee";
            this.btn_add_employee_HR.UseVisualStyleBackColor = false;
            this.btn_add_employee_HR.Click += new System.EventHandler(this.btn_add_employee_HR_Click);
            // 
            // lbx_Employees
            // 
            this.lbx_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lbx_Employees.ForeColor = System.Drawing.Color.White;
            this.lbx_Employees.FormattingEnabled = true;
            this.lbx_Employees.ItemHeight = 15;
            this.lbx_Employees.Location = new System.Drawing.Point(10, 141);
            this.lbx_Employees.Name = "lbx_Employees";
            this.lbx_Employees.Size = new System.Drawing.Size(783, 334);
            this.lbx_Employees.TabIndex = 5;
            // 
            // lbx_test
            // 
            this.lbx_test.BackColor = System.Drawing.Color.Black;
            this.lbx_test.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbx_test.ForeColor = System.Drawing.Color.White;
            this.lbx_test.FormattingEnabled = true;
            this.lbx_test.ItemHeight = 20;
            this.lbx_test.Location = new System.Drawing.Point(10, 115);
            this.lbx_test.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_test.Name = "lbx_test";
            this.lbx_test.Size = new System.Drawing.Size(783, 4);
            this.lbx_test.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(857, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Selected Employee info";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.lb_more_details);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(843, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 359);
            this.panel2.TabIndex = 8;
            // 
            // lb_more_details
            // 
            this.lb_more_details.AutoSize = true;
            this.lb_more_details.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_more_details.ForeColor = System.Drawing.Color.White;
            this.lb_more_details.Location = new System.Drawing.Point(59, 319);
            this.lb_more_details.Name = "lb_more_details";
            this.lb_more_details.Size = new System.Drawing.Size(117, 25);
            this.lb_more_details.TabIndex = 1;
            this.lb_more_details.Text = "More details";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(14, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 4);
            this.panel3.TabIndex = 0;
            // 
            // Human_Resources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(1101, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_test);
            this.Controls.Add(this.lbx_Employees);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private ListBox lbx_Employees;
        private ListBox lbx_test;
        private Label label3;
        private Panel panel2;
        private Label lb_more_details;
        private Panel panel3;
    }
}