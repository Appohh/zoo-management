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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Maker));
            tabControlSchedule = new TabControl();
            Welcome = new TabPage();
            welcome_txt = new Label();
            tabPageSchedule = new TabPage();
            button1 = new Button();
            datePicker = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            cbbShiftType = new ComboBox();
            cbbShiftLocation = new ComboBox();
            lblTimeRange = new Label();
            weekNum = new Label();
            sunN = new FlowLayoutPanel();
            sunA = new FlowLayoutPanel();
            label11 = new Label();
            sunD = new FlowLayoutPanel();
            satN = new FlowLayoutPanel();
            satA = new FlowLayoutPanel();
            label10 = new Label();
            satD = new FlowLayoutPanel();
            cbEmps = new ComboBox();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            friN = new FlowLayoutPanel();
            thuN = new FlowLayoutPanel();
            wedN = new FlowLayoutPanel();
            tueN = new FlowLayoutPanel();
            monN = new FlowLayoutPanel();
            friA = new FlowLayoutPanel();
            thuA = new FlowLayoutPanel();
            wedA = new FlowLayoutPanel();
            tueA = new FlowLayoutPanel();
            monA = new FlowLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label12 = new Label();
            label13 = new Label();
            friD = new FlowLayoutPanel();
            thuD = new FlowLayoutPanel();
            wedD = new FlowLayoutPanel();
            tueD = new FlowLayoutPanel();
            monD = new FlowLayoutPanel();
            btnAssignShift = new Button();
            shiftBindingSource = new BindingSource(components);
            CB_GetShiftByJob = new ComboBox();
            Btn_GetShiftByJob = new Button();
            tabControlSchedule.SuspendLayout();
            Welcome.SuspendLayout();
            tabPageSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shiftBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControlSchedule
            // 
            tabControlSchedule.Controls.Add(Welcome);
            tabControlSchedule.Controls.Add(tabPageSchedule);
            tabControlSchedule.Dock = DockStyle.Fill;
            tabControlSchedule.Location = new Point(0, 0);
            tabControlSchedule.Margin = new Padding(3, 2, 3, 2);
            tabControlSchedule.Name = "tabControlSchedule";
            tabControlSchedule.SelectedIndex = 0;
            tabControlSchedule.Size = new Size(1036, 497);
            tabControlSchedule.TabIndex = 1;
            // 
            // Welcome
            // 
            Welcome.BackgroundImage = (Image)resources.GetObject("Welcome.BackgroundImage");
            Welcome.BackgroundImageLayout = ImageLayout.Stretch;
            Welcome.Controls.Add(welcome_txt);
            Welcome.Location = new Point(4, 24);
            Welcome.Margin = new Padding(3, 2, 3, 2);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(1028, 469);
            Welcome.TabIndex = 3;
            Welcome.Text = "Welcome";
            Welcome.UseVisualStyleBackColor = true;
            // 
            // welcome_txt
            // 
            welcome_txt.AutoSize = true;
            welcome_txt.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            welcome_txt.ForeColor = Color.Maroon;
            welcome_txt.Location = new Point(578, 120);
            welcome_txt.Margin = new Padding(2, 0, 2, 0);
            welcome_txt.Name = "welcome_txt";
            welcome_txt.Size = new Size(300, 86);
            welcome_txt.TabIndex = 1;
            welcome_txt.Text = "Welcome";
            // 
            // tabPageSchedule
            // 
            tabPageSchedule.Controls.Add(Btn_GetShiftByJob);
            tabPageSchedule.Controls.Add(CB_GetShiftByJob);
            tabPageSchedule.Controls.Add(button1);
            tabPageSchedule.Controls.Add(datePicker);
            tabPageSchedule.Controls.Add(label2);
            tabPageSchedule.Controls.Add(label3);
            tabPageSchedule.Controls.Add(cbbShiftType);
            tabPageSchedule.Controls.Add(cbbShiftLocation);
            tabPageSchedule.Controls.Add(lblTimeRange);
            tabPageSchedule.Controls.Add(weekNum);
            tabPageSchedule.Controls.Add(sunN);
            tabPageSchedule.Controls.Add(sunA);
            tabPageSchedule.Controls.Add(label11);
            tabPageSchedule.Controls.Add(sunD);
            tabPageSchedule.Controls.Add(satN);
            tabPageSchedule.Controls.Add(satA);
            tabPageSchedule.Controls.Add(label10);
            tabPageSchedule.Controls.Add(satD);
            tabPageSchedule.Controls.Add(cbEmps);
            tabPageSchedule.Controls.Add(button2);
            tabPageSchedule.Controls.Add(label8);
            tabPageSchedule.Controls.Add(label7);
            tabPageSchedule.Controls.Add(friN);
            tabPageSchedule.Controls.Add(thuN);
            tabPageSchedule.Controls.Add(wedN);
            tabPageSchedule.Controls.Add(tueN);
            tabPageSchedule.Controls.Add(monN);
            tabPageSchedule.Controls.Add(friA);
            tabPageSchedule.Controls.Add(thuA);
            tabPageSchedule.Controls.Add(wedA);
            tabPageSchedule.Controls.Add(tueA);
            tabPageSchedule.Controls.Add(monA);
            tabPageSchedule.Controls.Add(label6);
            tabPageSchedule.Controls.Add(label5);
            tabPageSchedule.Controls.Add(label4);
            tabPageSchedule.Controls.Add(label12);
            tabPageSchedule.Controls.Add(label13);
            tabPageSchedule.Controls.Add(friD);
            tabPageSchedule.Controls.Add(thuD);
            tabPageSchedule.Controls.Add(wedD);
            tabPageSchedule.Controls.Add(tueD);
            tabPageSchedule.Controls.Add(monD);
            tabPageSchedule.Controls.Add(btnAssignShift);
            tabPageSchedule.Location = new Point(4, 24);
            tabPageSchedule.Margin = new Padding(2, 1, 2, 1);
            tabPageSchedule.Name = "tabPageSchedule";
            tabPageSchedule.Padding = new Padding(2, 1, 2, 1);
            tabPageSchedule.Size = new Size(1028, 469);
            tabPageSchedule.TabIndex = 5;
            tabPageSchedule.Text = "Schedule";
            tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1241, 15);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(81, 22);
            button1.TabIndex = 93;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(48, 119);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 92;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 211);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 54;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 264);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 91;
            label3.Text = "Location:";
            // 
            // cbbShiftType
            // 
            cbbShiftType.FormattingEnabled = true;
            cbbShiftType.Location = new Point(48, 229);
            cbbShiftType.Name = "cbbShiftType";
            cbbShiftType.Size = new Size(121, 23);
            cbbShiftType.TabIndex = 53;
            // 
            // cbbShiftLocation
            // 
            cbbShiftLocation.FormattingEnabled = true;
            cbbShiftLocation.Location = new Point(48, 282);
            cbbShiftLocation.Name = "cbbShiftLocation";
            cbbShiftLocation.Size = new Size(121, 23);
            cbbShiftLocation.TabIndex = 90;
            // 
            // lblTimeRange
            // 
            lblTimeRange.AutoSize = true;
            lblTimeRange.Location = new Point(736, 31);
            lblTimeRange.Name = "lblTimeRange";
            lblTimeRange.Size = new Size(44, 15);
            lblTimeRange.TabIndex = 89;
            lblTimeRange.Text = "label12";
            // 
            // weekNum
            // 
            weekNum.AutoSize = true;
            weekNum.Location = new Point(698, 31);
            weekNum.Name = "weekNum";
            weekNum.Size = new Size(32, 15);
            weekNum.TabIndex = 88;
            weekNum.Text = "num";
            // 
            // sunN
            // 
            sunN.BorderStyle = BorderStyle.FixedSingle;
            sunN.Location = new Point(1158, 475);
            sunN.Name = "sunN";
            sunN.Size = new Size(130, 173);
            sunN.TabIndex = 87;
            // 
            // sunA
            // 
            sunA.BorderStyle = BorderStyle.FixedSingle;
            sunA.Location = new Point(1158, 297);
            sunA.Name = "sunA";
            sunA.Size = new Size(130, 173);
            sunA.TabIndex = 86;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(1198, 89);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 85;
            label11.Text = "SUNDAY";
            // 
            // sunD
            // 
            sunD.BorderStyle = BorderStyle.FixedSingle;
            sunD.Location = new Point(1158, 119);
            sunD.Name = "sunD";
            sunD.Size = new Size(130, 173);
            sunD.TabIndex = 84;
            // 
            // satN
            // 
            satN.BorderStyle = BorderStyle.FixedSingle;
            satN.Location = new Point(1021, 475);
            satN.Name = "satN";
            satN.Size = new Size(130, 173);
            satN.TabIndex = 83;
            // 
            // satA
            // 
            satA.BorderStyle = BorderStyle.FixedSingle;
            satA.Location = new Point(1021, 297);
            satA.Name = "satA";
            satA.Size = new Size(130, 173);
            satA.TabIndex = 82;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1061, 89);
            label10.Name = "label10";
            label10.Size = new Size(63, 15);
            label10.TabIndex = 81;
            label10.Text = "SATURDAY";
            // 
            // satD
            // 
            satD.BorderStyle = BorderStyle.FixedSingle;
            satD.Location = new Point(1021, 119);
            satD.Name = "satD";
            satD.Size = new Size(130, 173);
            satD.TabIndex = 80;
            // 
            // cbEmps
            // 
            cbEmps.FormattingEnabled = true;
            cbEmps.Location = new Point(48, 176);
            cbEmps.Name = "cbEmps";
            cbEmps.Size = new Size(157, 23);
            cbEmps.TabIndex = 78;
            cbEmps.SelectedIndexChanged += cbEmps_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Location = new Point(48, 625);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 77;
            button2.Text = "Generate Schedule";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(662, 31);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 75;
            label8.Text = "Week:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 158);
            label7.Name = "label7";
            label7.Size = new Size(115, 15);
            label7.TabIndex = 74;
            label7.Text = "Available Employees";
            // 
            // friN
            // 
            friN.BorderStyle = BorderStyle.FixedSingle;
            friN.Location = new Point(885, 475);
            friN.Name = "friN";
            friN.Size = new Size(130, 173);
            friN.TabIndex = 73;
            // 
            // thuN
            // 
            thuN.BorderStyle = BorderStyle.FixedSingle;
            thuN.Location = new Point(750, 475);
            thuN.Name = "thuN";
            thuN.Size = new Size(130, 173);
            thuN.TabIndex = 72;
            // 
            // wedN
            // 
            wedN.BorderStyle = BorderStyle.FixedSingle;
            wedN.Location = new Point(615, 475);
            wedN.Name = "wedN";
            wedN.Size = new Size(130, 173);
            wedN.TabIndex = 71;
            // 
            // tueN
            // 
            tueN.BorderStyle = BorderStyle.FixedSingle;
            tueN.Location = new Point(480, 475);
            tueN.Name = "tueN";
            tueN.Size = new Size(130, 173);
            tueN.TabIndex = 70;
            // 
            // monN
            // 
            monN.BorderStyle = BorderStyle.FixedSingle;
            monN.Location = new Point(345, 475);
            monN.Name = "monN";
            monN.Size = new Size(130, 173);
            monN.TabIndex = 69;
            // 
            // friA
            // 
            friA.BorderStyle = BorderStyle.FixedSingle;
            friA.Location = new Point(885, 297);
            friA.Name = "friA";
            friA.Size = new Size(130, 173);
            friA.TabIndex = 68;
            // 
            // thuA
            // 
            thuA.BorderStyle = BorderStyle.FixedSingle;
            thuA.Location = new Point(750, 297);
            thuA.Name = "thuA";
            thuA.Size = new Size(130, 173);
            thuA.TabIndex = 67;
            // 
            // wedA
            // 
            wedA.BorderStyle = BorderStyle.FixedSingle;
            wedA.Location = new Point(615, 297);
            wedA.Name = "wedA";
            wedA.Size = new Size(130, 173);
            wedA.TabIndex = 66;
            // 
            // tueA
            // 
            tueA.BorderStyle = BorderStyle.FixedSingle;
            tueA.Location = new Point(480, 297);
            tueA.Name = "tueA";
            tueA.Size = new Size(130, 173);
            tueA.TabIndex = 65;
            // 
            // monA
            // 
            monA.BorderStyle = BorderStyle.FixedSingle;
            monA.Location = new Point(345, 297);
            monA.Name = "monA";
            monA.Size = new Size(130, 173);
            monA.TabIndex = 64;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(925, 89);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 63;
            label6.Text = "FRIDAY";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(785, 89);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 62;
            label5.Text = "THURSDAY";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 89);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 61;
            label4.Text = "WEDNESDAY";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(514, 89);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 60;
            label12.Text = "TUESDAY";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(379, 89);
            label13.Name = "label13";
            label13.Size = new Size(58, 15);
            label13.TabIndex = 59;
            label13.Text = "MONDAY";
            // 
            // friD
            // 
            friD.BorderStyle = BorderStyle.FixedSingle;
            friD.Location = new Point(885, 119);
            friD.Name = "friD";
            friD.Size = new Size(130, 173);
            friD.TabIndex = 58;
            // 
            // thuD
            // 
            thuD.BorderStyle = BorderStyle.FixedSingle;
            thuD.Location = new Point(750, 119);
            thuD.Name = "thuD";
            thuD.Size = new Size(130, 173);
            thuD.TabIndex = 57;
            // 
            // wedD
            // 
            wedD.BorderStyle = BorderStyle.FixedSingle;
            wedD.Location = new Point(615, 119);
            wedD.Name = "wedD";
            wedD.Size = new Size(130, 173);
            wedD.TabIndex = 56;
            // 
            // tueD
            // 
            tueD.BorderStyle = BorderStyle.FixedSingle;
            tueD.Location = new Point(480, 119);
            tueD.Name = "tueD";
            tueD.Size = new Size(130, 173);
            tueD.TabIndex = 55;
            // 
            // monD
            // 
            monD.BorderStyle = BorderStyle.FixedSingle;
            monD.Location = new Point(345, 119);
            monD.Name = "monD";
            monD.Size = new Size(130, 173);
            monD.TabIndex = 54;
            // 
            // btnAssignShift
            // 
            btnAssignShift.Location = new Point(69, 327);
            btnAssignShift.Name = "btnAssignShift";
            btnAssignShift.Size = new Size(75, 23);
            btnAssignShift.TabIndex = 53;
            btnAssignShift.Text = "Assign";
            btnAssignShift.UseVisualStyleBackColor = true;
            btnAssignShift.Click += btnAssignShift_Click;
            // 
            // shiftBindingSource
            // 
            shiftBindingSource.DataSource = typeof(LogicCL.Shift);
            // 
            // CB_GetShiftByJob
            // 
            CB_GetShiftByJob.FormattingEnabled = true;
            CB_GetShiftByJob.Location = new Point(48, 42);
            CB_GetShiftByJob.Name = "CB_GetShiftByJob";
            CB_GetShiftByJob.Size = new Size(133, 23);
            CB_GetShiftByJob.TabIndex = 94;
            // 
            // Btn_GetShiftByJob
            // 
            Btn_GetShiftByJob.Location = new Point(187, 41);
            Btn_GetShiftByJob.Name = "Btn_GetShiftByJob";
            Btn_GetShiftByJob.Size = new Size(92, 23);
            Btn_GetShiftByJob.TabIndex = 95;
            Btn_GetShiftByJob.Text = "See schedule";
            Btn_GetShiftByJob.UseVisualStyleBackColor = true;
            Btn_GetShiftByJob.Click += Btn_GetShiftByJob_Click;
            // 
            // Schedule_Maker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 497);
            Controls.Add(tabControlSchedule);
            Name = "Schedule_Maker";
            Text = "Schedule_Maker";
            tabControlSchedule.ResumeLayout(false);
            Welcome.ResumeLayout(false);
            Welcome.PerformLayout();
            tabPageSchedule.ResumeLayout(false);
            tabPageSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shiftBindingSource).EndInit();
            ResumeLayout(false);
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
    }
}