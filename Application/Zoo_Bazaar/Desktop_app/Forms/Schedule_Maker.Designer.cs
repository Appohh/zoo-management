namespace Desktop_app.Forms
{
    partial class Schedule_Maker
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader Job;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Maker));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Welcome = new System.Windows.Forms.TabPage();
            this.welcome_txt = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSelectedEmp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbShiftLocation = new System.Windows.Forms.ComboBox();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbShiftType = new System.Windows.Forms.ComboBox();
            this.dtPickerShift = new System.Windows.Forms.DateTimePicker();
            this.shiftDGV = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnViewAvailable = new System.Windows.Forms.Button();
            this.btnLoadShiftData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerEmp = new System.Windows.Forms.DateTimePicker();
            this.lv_Employees = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Contract = new System.Windows.Forms.ColumnHeader();
            Job = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.Welcome.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Job
            // 
            Job.Text = "Job";
            Job.Width = 150;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Welcome);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1137, 848);
            this.tabControl1.TabIndex = 1;
            // 
            // Welcome
            // 
            this.Welcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Welcome.BackgroundImage")));
            this.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome.Controls.Add(this.welcome_txt);
            this.Welcome.Location = new System.Drawing.Point(4, 24);
            this.Welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(1343, 820);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = true;
            // 
            // welcome_txt
            // 
            this.welcome_txt.AutoSize = true;
            this.welcome_txt.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_txt.ForeColor = System.Drawing.Color.Maroon;
            this.welcome_txt.Location = new System.Drawing.Point(578, 120);
            this.welcome_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_txt.Name = "welcome_txt";
            this.welcome_txt.Size = new System.Drawing.Size(300, 86);
            this.welcome_txt.TabIndex = 1;
            this.welcome_txt.Text = "Welcome";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnViewAvailable);
            this.tabPage1.Controls.Add(this.btnLoadShiftData);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtPickerEmp);
            this.tabPage1.Controls.Add(this.lv_Employees);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1129, 820);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbSelectedEmp);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.shiftDGV);
            this.groupBox1.Location = new System.Drawing.Point(661, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 702);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shift Data";
            // 
            // lbSelectedEmp
            // 
            this.lbSelectedEmp.AutoSize = true;
            this.lbSelectedEmp.Location = new System.Drawing.Point(132, 41);
            this.lbSelectedEmp.Name = "lbSelectedEmp";
            this.lbSelectedEmp.Size = new System.Drawing.Size(62, 15);
            this.lbSelectedEmp.TabIndex = 55;
            this.lbSelectedEmp.Text = "Employee:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbbShiftLocation);
            this.groupBox2.Controls.Add(this.btnAddShift);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbShiftType);
            this.groupBox2.Controls.Add(this.dtPickerShift);
            this.groupBox2.Location = new System.Drawing.Point(11, 450);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 222);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add New Shift";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Location:";
            // 
            // cbbShiftLocation
            // 
            this.cbbShiftLocation.FormattingEnabled = true;
            this.cbbShiftLocation.Location = new System.Drawing.Point(85, 128);
            this.cbbShiftLocation.Name = "cbbShiftLocation";
            this.cbbShiftLocation.Size = new System.Drawing.Size(121, 23);
            this.cbbShiftLocation.TabIndex = 54;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(85, 178);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(75, 23);
            this.btnAddShift.TabIndex = 53;
            this.btnAddShift.Text = "Add";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Type:";
            // 
            // cbbShiftType
            // 
            this.cbbShiftType.FormattingEnabled = true;
            this.cbbShiftType.Location = new System.Drawing.Point(85, 76);
            this.cbbShiftType.Name = "cbbShiftType";
            this.cbbShiftType.Size = new System.Drawing.Size(121, 23);
            this.cbbShiftType.TabIndex = 51;
            // 
            // dtPickerShift
            // 
            this.dtPickerShift.Location = new System.Drawing.Point(6, 32);
            this.dtPickerShift.Name = "dtPickerShift";
            this.dtPickerShift.Size = new System.Drawing.Size(230, 23);
            this.dtPickerShift.TabIndex = 50;
            // 
            // shiftDGV
            // 
            this.shiftDGV.AutoGenerateColumns = false;
            this.shiftDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shiftDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.empIdDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.shiftDGV.DataSource = this.shiftBindingSource;
            this.shiftDGV.Location = new System.Drawing.Point(11, 98);
            this.shiftDGV.Name = "shiftDGV";
            this.shiftDGV.RowTemplate.Height = 25;
            this.shiftDGV.Size = new System.Drawing.Size(444, 325);
            this.shiftDGV.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // empIdDataGridViewTextBoxColumn
            // 
            this.empIdDataGridViewTextBoxColumn.DataPropertyName = "EmpId";
            this.empIdDataGridViewTextBoxColumn.HeaderText = "EmpId";
            this.empIdDataGridViewTextBoxColumn.Name = "empIdDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // shiftBindingSource
            // 
            this.shiftBindingSource.DataSource = typeof(LogicCL.Shift);
            // 
            // btnViewAvailable
            // 
            this.btnViewAvailable.Location = new System.Drawing.Point(175, 74);
            this.btnViewAvailable.Name = "btnViewAvailable";
            this.btnViewAvailable.Size = new System.Drawing.Size(113, 23);
            this.btnViewAvailable.TabIndex = 52;
            this.btnViewAvailable.Text = "View Available ";
            this.btnViewAvailable.UseVisualStyleBackColor = true;
            this.btnViewAvailable.Click += new System.EventHandler(this.btnViewAvailable_Click);
            // 
            // btnLoadShiftData
            // 
            this.btnLoadShiftData.Location = new System.Drawing.Point(511, 145);
            this.btnLoadShiftData.Name = "btnLoadShiftData";
            this.btnLoadShiftData.Size = new System.Drawing.Size(114, 23);
            this.btnLoadShiftData.TabIndex = 51;
            this.btnLoadShiftData.Text = "Load Shift Data";
            this.btnLoadShiftData.UseVisualStyleBackColor = true;
            this.btnLoadShiftData.Click += new System.EventHandler(this.btnLoadShiftData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Choose Date:";
            // 
            // dtPickerEmp
            // 
            this.dtPickerEmp.Location = new System.Drawing.Point(175, 26);
            this.dtPickerEmp.Name = "dtPickerEmp";
            this.dtPickerEmp.Size = new System.Drawing.Size(200, 23);
            this.dtPickerEmp.TabIndex = 49;
            // 
            // lv_Employees
            // 
            this.lv_Employees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(159)))));
            this.lv_Employees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Employees.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            Job,
            this.Contract});
            this.lv_Employees.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Employees.ForeColor = System.Drawing.Color.Black;
            this.lv_Employees.FullRowSelect = true;
            this.lv_Employees.Location = new System.Drawing.Point(30, 116);
            this.lv_Employees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv_Employees.Name = "lv_Employees";
            this.lv_Employees.Size = new System.Drawing.Size(450, 489);
            this.lv_Employees.TabIndex = 48;
            this.lv_Employees.UseCompatibleStateImageBehavior = false;
            this.lv_Employees.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 200;
            // 
            // Contract
            // 
            this.Contract.Text = "Contract";
            this.Contract.Width = 100;
            // 
            // Schedule_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 848);
            this.Controls.Add(this.tabControl1);
            this.Text = "Schedule_Maker";
            this.tabControl1.ResumeLayout(false);
            this.Welcome.ResumeLayout(false);
            this.Welcome.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Welcome;
        private Label welcome_txt;
        private TabPage tabPage1;
        private Button btnLoadShiftData;
        private Label label1;
        private DateTimePicker dtPickerEmp;
        private ListView lv_Employees;
        private ColumnHeader Name;
        private ColumnHeader Contract;
        private DataGridView shiftDGV;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn empIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private BindingSource shiftBindingSource;
        private Button btnViewAvailable;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAddShift;
        private Label label2;
        private ComboBox cbbShiftType;
        private DateTimePicker dtPickerShift;
        private Label label3;
        private ComboBox cbbShiftLocation;
        private Label lbSelectedEmp;
    }
}