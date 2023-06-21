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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Maker));
            this.tabControlSchedule = new System.Windows.Forms.TabControl();
            this.Welcome = new System.Windows.Forms.TabPage();
            this.welcome_txt = new System.Windows.Forms.Label();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_GetShiftByJob = new System.Windows.Forms.Button();
            this.CB_GetShiftByJob = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbShiftType = new System.Windows.Forms.ComboBox();
            this.cbbShiftLocation = new System.Windows.Forms.ComboBox();
            this.lblTimeRange = new System.Windows.Forms.Label();
            this.weekNum = new System.Windows.Forms.Label();
            this.sunN = new System.Windows.Forms.FlowLayoutPanel();
            this.sunA = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.sunD = new System.Windows.Forms.FlowLayoutPanel();
            this.satN = new System.Windows.Forms.FlowLayoutPanel();
            this.satA = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.satD = new System.Windows.Forms.FlowLayoutPanel();
            this.cbEmps = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.friN = new System.Windows.Forms.FlowLayoutPanel();
            this.thuN = new System.Windows.Forms.FlowLayoutPanel();
            this.wedN = new System.Windows.Forms.FlowLayoutPanel();
            this.tueN = new System.Windows.Forms.FlowLayoutPanel();
            this.monN = new System.Windows.Forms.FlowLayoutPanel();
            this.friA = new System.Windows.Forms.FlowLayoutPanel();
            this.thuA = new System.Windows.Forms.FlowLayoutPanel();
            this.wedA = new System.Windows.Forms.FlowLayoutPanel();
            this.tueA = new System.Windows.Forms.FlowLayoutPanel();
            this.monA = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.friD = new System.Windows.Forms.FlowLayoutPanel();
            this.thuD = new System.Windows.Forms.FlowLayoutPanel();
            this.wedD = new System.Windows.Forms.FlowLayoutPanel();
            this.tueD = new System.Windows.Forms.FlowLayoutPanel();
            this.monD = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAssignShift = new System.Windows.Forms.Button();
            this.shiftBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControlSchedule.SuspendLayout();
            this.Welcome.SuspendLayout();
            this.tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSchedule
            // 
            this.tabControlSchedule.Controls.Add(this.Welcome);
            this.tabControlSchedule.Controls.Add(this.tabPageSchedule);
            this.tabControlSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSchedule.Location = new System.Drawing.Point(0, 0);
            this.tabControlSchedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlSchedule.Name = "tabControlSchedule";
            this.tabControlSchedule.SelectedIndex = 0;
            this.tabControlSchedule.Size = new System.Drawing.Size(1398, 719);
            this.tabControlSchedule.TabIndex = 1;
            // 
            // Welcome
            // 
            this.Welcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Welcome.BackgroundImage")));
            this.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome.Controls.Add(this.welcome_txt);
            this.Welcome.Location = new System.Drawing.Point(4, 24);
            this.Welcome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(1390, 691);
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
            // tabPageSchedule
            // 
            this.tabPageSchedule.Controls.Add(this.label15);
            this.tabPageSchedule.Controls.Add(this.label1);
            this.tabPageSchedule.Controls.Add(this.Btn_GetShiftByJob);
            this.tabPageSchedule.Controls.Add(this.CB_GetShiftByJob);
            this.tabPageSchedule.Controls.Add(this.button1);
            this.tabPageSchedule.Controls.Add(this.datePicker);
            this.tabPageSchedule.Controls.Add(this.label2);
            this.tabPageSchedule.Controls.Add(this.label3);
            this.tabPageSchedule.Controls.Add(this.cbbShiftType);
            this.tabPageSchedule.Controls.Add(this.cbbShiftLocation);
            this.tabPageSchedule.Controls.Add(this.lblTimeRange);
            this.tabPageSchedule.Controls.Add(this.weekNum);
            this.tabPageSchedule.Controls.Add(this.sunN);
            this.tabPageSchedule.Controls.Add(this.sunA);
            this.tabPageSchedule.Controls.Add(this.label11);
            this.tabPageSchedule.Controls.Add(this.sunD);
            this.tabPageSchedule.Controls.Add(this.satN);
            this.tabPageSchedule.Controls.Add(this.satA);
            this.tabPageSchedule.Controls.Add(this.label10);
            this.tabPageSchedule.Controls.Add(this.satD);
            this.tabPageSchedule.Controls.Add(this.cbEmps);
            this.tabPageSchedule.Controls.Add(this.button2);
            this.tabPageSchedule.Controls.Add(this.label8);
            this.tabPageSchedule.Controls.Add(this.label7);
            this.tabPageSchedule.Controls.Add(this.friN);
            this.tabPageSchedule.Controls.Add(this.thuN);
            this.tabPageSchedule.Controls.Add(this.wedN);
            this.tabPageSchedule.Controls.Add(this.tueN);
            this.tabPageSchedule.Controls.Add(this.monN);
            this.tabPageSchedule.Controls.Add(this.friA);
            this.tabPageSchedule.Controls.Add(this.thuA);
            this.tabPageSchedule.Controls.Add(this.wedA);
            this.tabPageSchedule.Controls.Add(this.tueA);
            this.tabPageSchedule.Controls.Add(this.monA);
            this.tabPageSchedule.Controls.Add(this.label6);
            this.tabPageSchedule.Controls.Add(this.label5);
            this.tabPageSchedule.Controls.Add(this.label4);
            this.tabPageSchedule.Controls.Add(this.label12);
            this.tabPageSchedule.Controls.Add(this.label13);
            this.tabPageSchedule.Controls.Add(this.friD);
            this.tabPageSchedule.Controls.Add(this.thuD);
            this.tabPageSchedule.Controls.Add(this.wedD);
            this.tabPageSchedule.Controls.Add(this.tueD);
            this.tabPageSchedule.Controls.Add(this.monD);
            this.tabPageSchedule.Controls.Add(this.btnAssignShift);
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 24);
            this.tabPageSchedule.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tabPageSchedule.Size = new System.Drawing.Size(1390, 691);
            this.tabPageSchedule.TabIndex = 5;
            this.tabPageSchedule.Text = "Schedule";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(48, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 21);
            this.label15.TabIndex = 101;
            this.label15.Text = "Manual Schedule";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 549);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 21);
            this.label1.TabIndex = 96;
            this.label1.Text = "Automatic Schedule";
            // 
            // Btn_GetShiftByJob
            // 
            this.Btn_GetShiftByJob.Location = new System.Drawing.Point(184, 88);
            this.Btn_GetShiftByJob.Name = "Btn_GetShiftByJob";
            this.Btn_GetShiftByJob.Size = new System.Drawing.Size(92, 23);
            this.Btn_GetShiftByJob.TabIndex = 95;
            this.Btn_GetShiftByJob.Text = "See schedule";
            this.Btn_GetShiftByJob.UseVisualStyleBackColor = true;
            this.Btn_GetShiftByJob.Click += new System.EventHandler(this.Btn_GetShiftByJob_Click);
            // 
            // CB_GetShiftByJob
            // 
            this.CB_GetShiftByJob.FormattingEnabled = true;
            this.CB_GetShiftByJob.Location = new System.Drawing.Point(45, 89);
            this.CB_GetShiftByJob.Name = "CB_GetShiftByJob";
            this.CB_GetShiftByJob.Size = new System.Drawing.Size(133, 23);
            this.CB_GetShiftByJob.TabIndex = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1241, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 22);
            this.button1.TabIndex = 93;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(48, 143);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 23);
            this.datePicker.TabIndex = 92;
            this.datePicker.Value = new System.DateTime(2023, 6, 14, 16, 21, 31, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.datePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 91;
            this.label3.Text = "Location:";
            // 
            // cbbShiftType
            // 
            this.cbbShiftType.FormattingEnabled = true;
            this.cbbShiftType.Location = new System.Drawing.Point(48, 200);
            this.cbbShiftType.Name = "cbbShiftType";
            this.cbbShiftType.Size = new System.Drawing.Size(121, 23);
            this.cbbShiftType.TabIndex = 53;
            // 
            // cbbShiftLocation
            // 
            this.cbbShiftLocation.FormattingEnabled = true;
            this.cbbShiftLocation.Location = new System.Drawing.Point(48, 306);
            this.cbbShiftLocation.Name = "cbbShiftLocation";
            this.cbbShiftLocation.Size = new System.Drawing.Size(121, 23);
            this.cbbShiftLocation.TabIndex = 90;
            // 
            // lblTimeRange
            // 
            this.lblTimeRange.AutoSize = true;
            this.lblTimeRange.Location = new System.Drawing.Point(736, 31);
            this.lblTimeRange.Name = "lblTimeRange";
            this.lblTimeRange.Size = new System.Drawing.Size(44, 15);
            this.lblTimeRange.TabIndex = 89;
            this.lblTimeRange.Text = "label12";
            // 
            // weekNum
            // 
            this.weekNum.AutoSize = true;
            this.weekNum.Location = new System.Drawing.Point(698, 31);
            this.weekNum.Name = "weekNum";
            this.weekNum.Size = new System.Drawing.Size(32, 15);
            this.weekNum.TabIndex = 88;
            this.weekNum.Text = "num";
            // 
            // sunN
            // 
            this.sunN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sunN.Location = new System.Drawing.Point(1158, 475);
            this.sunN.Name = "sunN";
            this.sunN.Size = new System.Drawing.Size(130, 173);
            this.sunN.TabIndex = 87;
            // 
            // sunA
            // 
            this.sunA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sunA.Location = new System.Drawing.Point(1158, 297);
            this.sunA.Name = "sunA";
            this.sunA.Size = new System.Drawing.Size(130, 173);
            this.sunA.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1198, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 85;
            this.label11.Text = "SUNDAY";
            // 
            // sunD
            // 
            this.sunD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sunD.Location = new System.Drawing.Point(1158, 119);
            this.sunD.Name = "sunD";
            this.sunD.Size = new System.Drawing.Size(130, 173);
            this.sunD.TabIndex = 84;
            // 
            // satN
            // 
            this.satN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.satN.Location = new System.Drawing.Point(1021, 475);
            this.satN.Name = "satN";
            this.satN.Size = new System.Drawing.Size(130, 173);
            this.satN.TabIndex = 83;
            // 
            // satA
            // 
            this.satA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.satA.Location = new System.Drawing.Point(1021, 297);
            this.satA.Name = "satA";
            this.satA.Size = new System.Drawing.Size(130, 173);
            this.satA.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1061, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 81;
            this.label10.Text = "SATURDAY";
            // 
            // satD
            // 
            this.satD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.satD.Location = new System.Drawing.Point(1021, 119);
            this.satD.Name = "satD";
            this.satD.Size = new System.Drawing.Size(130, 173);
            this.satD.TabIndex = 80;
            // 
            // cbEmps
            // 
            this.cbEmps.FormattingEnabled = true;
            this.cbEmps.Location = new System.Drawing.Point(48, 254);
            this.cbEmps.Name = "cbEmps";
            this.cbEmps.Size = new System.Drawing.Size(157, 23);
            this.cbEmps.TabIndex = 78;
            this.cbEmps.SelectedIndexChanged += new System.EventHandler(this.cbEmps_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(45, 595);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 77;
            this.button2.Text = "Generate Schedule";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(662, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 75;
            this.label8.Text = "Week:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 74;
            this.label7.Text = "Available Employees";
            // 
            // friN
            // 
            this.friN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friN.Location = new System.Drawing.Point(885, 475);
            this.friN.Name = "friN";
            this.friN.Size = new System.Drawing.Size(130, 173);
            this.friN.TabIndex = 73;
            // 
            // thuN
            // 
            this.thuN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuN.Location = new System.Drawing.Point(750, 475);
            this.thuN.Name = "thuN";
            this.thuN.Size = new System.Drawing.Size(130, 173);
            this.thuN.TabIndex = 72;
            // 
            // wedN
            // 
            this.wedN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wedN.Location = new System.Drawing.Point(615, 475);
            this.wedN.Name = "wedN";
            this.wedN.Size = new System.Drawing.Size(130, 173);
            this.wedN.TabIndex = 71;
            // 
            // tueN
            // 
            this.tueN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tueN.Location = new System.Drawing.Point(480, 475);
            this.tueN.Name = "tueN";
            this.tueN.Size = new System.Drawing.Size(130, 173);
            this.tueN.TabIndex = 70;
            // 
            // monN
            // 
            this.monN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monN.Location = new System.Drawing.Point(345, 475);
            this.monN.Name = "monN";
            this.monN.Size = new System.Drawing.Size(130, 173);
            this.monN.TabIndex = 69;
            // 
            // friA
            // 
            this.friA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friA.Location = new System.Drawing.Point(885, 297);
            this.friA.Name = "friA";
            this.friA.Size = new System.Drawing.Size(130, 173);
            this.friA.TabIndex = 68;
            // 
            // thuA
            // 
            this.thuA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuA.Location = new System.Drawing.Point(750, 297);
            this.thuA.Name = "thuA";
            this.thuA.Size = new System.Drawing.Size(130, 173);
            this.thuA.TabIndex = 67;
            // 
            // wedA
            // 
            this.wedA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wedA.Location = new System.Drawing.Point(615, 297);
            this.wedA.Name = "wedA";
            this.wedA.Size = new System.Drawing.Size(130, 173);
            this.wedA.TabIndex = 66;
            // 
            // tueA
            // 
            this.tueA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tueA.Location = new System.Drawing.Point(480, 297);
            this.tueA.Name = "tueA";
            this.tueA.Size = new System.Drawing.Size(130, 173);
            this.tueA.TabIndex = 65;
            // 
            // monA
            // 
            this.monA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monA.Location = new System.Drawing.Point(345, 297);
            this.monA.Name = "monA";
            this.monA.Size = new System.Drawing.Size(130, 173);
            this.monA.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(925, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 63;
            this.label6.Text = "FRIDAY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(785, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 62;
            this.label5.Text = "THURSDAY";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(643, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "WEDNESDAY";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(514, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 15);
            this.label12.TabIndex = 60;
            this.label12.Text = "TUESDAY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(379, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 15);
            this.label13.TabIndex = 59;
            this.label13.Text = "MONDAY";
            // 
            // friD
            // 
            this.friD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.friD.Location = new System.Drawing.Point(885, 119);
            this.friD.Name = "friD";
            this.friD.Size = new System.Drawing.Size(130, 173);
            this.friD.TabIndex = 58;
            // 
            // thuD
            // 
            this.thuD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thuD.Location = new System.Drawing.Point(750, 119);
            this.thuD.Name = "thuD";
            this.thuD.Size = new System.Drawing.Size(130, 173);
            this.thuD.TabIndex = 57;
            // 
            // wedD
            // 
            this.wedD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wedD.Location = new System.Drawing.Point(615, 119);
            this.wedD.Name = "wedD";
            this.wedD.Size = new System.Drawing.Size(130, 173);
            this.wedD.TabIndex = 56;
            // 
            // tueD
            // 
            this.tueD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tueD.Location = new System.Drawing.Point(480, 119);
            this.tueD.Name = "tueD";
            this.tueD.Size = new System.Drawing.Size(130, 173);
            this.tueD.TabIndex = 55;
            // 
            // monD
            // 
            this.monD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monD.Location = new System.Drawing.Point(345, 119);
            this.monD.Name = "monD";
            this.monD.Size = new System.Drawing.Size(130, 173);
            this.monD.TabIndex = 54;
            // 
            // btnAssignShift
            // 
            this.btnAssignShift.Location = new System.Drawing.Point(69, 351);
            this.btnAssignShift.Name = "btnAssignShift";
            this.btnAssignShift.Size = new System.Drawing.Size(75, 23);
            this.btnAssignShift.TabIndex = 53;
            this.btnAssignShift.Text = "Assign";
            this.btnAssignShift.UseVisualStyleBackColor = true;
            this.btnAssignShift.Click += new System.EventHandler(this.btnAssignShift_Click);
            // 
            // Schedule_Maker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 719);
            this.Controls.Add(this.tabControlSchedule);
            this.Name = "Schedule_Maker";
            this.Text = "Schedule_Maker";
            this.tabControlSchedule.ResumeLayout(false);
            this.Welcome.ResumeLayout(false);
            this.Welcome.PerformLayout();
            this.tabPageSchedule.ResumeLayout(false);
            this.tabPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shiftBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private TabControl tabControlSchedule;
		private TabPage Welcome;
		private Label welcome_txt;
		private BindingSource shiftBindingSource;
		private TabPage tabPageSchedule;
		private Label lblTimeRange;
		private Label weekNum;
		private FlowLayoutPanel sunN;
		private FlowLayoutPanel sunA;
		private Label label11;
		private FlowLayoutPanel sunD;
		private FlowLayoutPanel satN;
		private FlowLayoutPanel satA;
		private Label label10;
		private FlowLayoutPanel satD;
		private ComboBox cbEmps;
		private Button button2;
		private Label label8;
		private Label label7;
		private FlowLayoutPanel friN;
		private FlowLayoutPanel thuN;
		private FlowLayoutPanel wedN;
		private FlowLayoutPanel tueN;
		private FlowLayoutPanel monN;
		private FlowLayoutPanel friA;
		private FlowLayoutPanel thuA;
		private FlowLayoutPanel wedA;
		private FlowLayoutPanel tueA;
		private FlowLayoutPanel monA;
		private Label label6;
		private Label label5;
		private Label label4;
		private Label label12;
		private Label label13;
		private FlowLayoutPanel friD;
		private FlowLayoutPanel thuD;
		private FlowLayoutPanel wedD;
		private FlowLayoutPanel tueD;
		private FlowLayoutPanel monD;
		private Button btnAssignShift;
		private Label label3;
		private ComboBox cbbShiftLocation;
		private Label label2;
		private ComboBox cbbShiftType;
		private DateTimePicker datePicker;
		private Button button1;
		private Button Btn_GetShiftByJob;
		private ComboBox CB_GetShiftByJob;
		private Label label1;
        private Label label15;
    }
}