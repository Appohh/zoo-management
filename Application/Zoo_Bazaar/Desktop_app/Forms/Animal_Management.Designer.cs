namespace Desktop_app.Forms
{
    partial class Animal_Management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal_Management));
            Spiece = new ColumnHeader();
            tabControl1 = new TabControl();
            tab_welcome = new TabPage();
            welcome_txt = new Label();
            tab_Overview = new TabPage();
            Btn_LogOut = new Button();
            label30 = new Label();
            typesCB = new ComboBox();
            label29 = new Label();
            label28 = new Label();
            artanPanel1 = new ArtanPanel();
            BTN_updateAnimal = new Button();
            button1 = new Button();
            label12 = new Label();
            groupBox6 = new GroupBox();
            txt_Gender = new TextBox();
            label5 = new Label();
            CB_Father1 = new ComboBox();
            CB_Mother1 = new ComboBox();
            TB_BirthPlace1 = new TextBox();
            label18 = new Label();
            label22 = new Label();
            label23 = new Label();
            groupBox7 = new GroupBox();
            CB_Diet1 = new ComboBox();
            CB_Type1 = new ComboBox();
            CB_Species1 = new ComboBox();
            CB_Location1 = new ComboBox();
            DT_Birthdate = new DateTimePicker();
            label19 = new Label();
            label16 = new Label();
            label17 = new Label();
            label20 = new Label();
            label15 = new Label();
            TB_name1 = new TextBox();
            label24 = new Label();
            groupBox8 = new GroupBox();
            checkBox1 = new CheckBox();
            label27 = new Label();
            btn_search_Animal = new Button();
            lbl_SearchAnimal = new Label();
            nameTB = new TextBox();
            lv_Animals = new ListView();
            Namez = new ColumnHeader();
            Type = new ColumnHeader();
            Location = new ColumnHeader();
            speciesCB = new ComboBox();
            tab_AddAnimal = new TabPage();
            button2 = new Button();
            Btn_AddAnimal = new Button();
            pictureBox1 = new PictureBox();
            groupBox4 = new GroupBox();
            CB_GenderAdd = new ComboBox();
            lbl_Gender = new Label();
            CB_FatherAdd = new ComboBox();
            CB_MotherAdd = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            TB_BirthPlaceAdd = new TextBox();
            Gb_Details_employee = new GroupBox();
            CB_LocationAdd = new ComboBox();
            DT_BirthDateAdd = new DateTimePicker();
            CB_DietAdd = new ComboBox();
            label4 = new Label();
            CB_TypeBoxAdd = new ComboBox();
            TB_NameAdd = new TextBox();
            label6 = new Label();
            label7 = new Label();
            CB_SpeciesBoxAdd = new ComboBox();
            label11 = new Label();
            label14 = new Label();
            label13 = new Label();
            groupBox2 = new GroupBox();
            label2 = new Label();
            CB_DeathDateBox = new DateTimePicker();
            CHB_Sick = new CheckBox();
            groupBox3 = new GroupBox();
            label26 = new Label();
            TB_BirthPlace = new TextBox();
            TB_Father = new TextBox();
            label25 = new Label();
            lbl_Phonenumber = new Label();
            TB_Mother = new TextBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            TB_Species = new TextBox();
            label21 = new Label();
            lbl_Job = new Label();
            TB_Diet = new TextBox();
            TB_Type = new TextBox();
            lbl_BSN = new Label();
            lbl_firstname = new Label();
            CB_BirthDateBoxHR = new DateTimePicker();
            TB_Name = new TextBox();
            lbl_birthdate = new Label();
            TB_Location = new TextBox();
            btn_ViewDetails = new Button();
            label3 = new Label();
            PictureBoxAddEmployee = new PictureBox();
            tabControl1.SuspendLayout();
            tab_welcome.SuspendLayout();
            tab_Overview.SuspendLayout();
            artanPanel1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            tab_AddAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox4.SuspendLayout();
            Gb_Details_employee.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAddEmployee).BeginInit();
            SuspendLayout();
            // 
            // Spiece
            // 
            Spiece.Text = "Spiece";
            Spiece.Width = 200;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tab_welcome);
            tabControl1.Controls.Add(tab_Overview);
            tabControl1.Controls.Add(tab_AddAnimal);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1647, 592);
            tabControl1.TabIndex = 0;
            // 
            // tab_welcome
            // 
            tab_welcome.BackgroundImage = (Image)resources.GetObject("tab_welcome.BackgroundImage");
            tab_welcome.BackgroundImageLayout = ImageLayout.Stretch;
            tab_welcome.Controls.Add(welcome_txt);
            tab_welcome.Location = new Point(4, 32);
            tab_welcome.Margin = new Padding(2);
            tab_welcome.Name = "tab_welcome";
            tab_welcome.Padding = new Padding(2);
            tab_welcome.Size = new Size(1639, 556);
            tab_welcome.TabIndex = 0;
            tab_welcome.Text = "Welcome";
            tab_welcome.UseVisualStyleBackColor = true;
            // 
            // welcome_txt
            // 
            welcome_txt.AutoSize = true;
            welcome_txt.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            welcome_txt.ForeColor = Color.Maroon;
            welcome_txt.Location = new Point(470, 142);
            welcome_txt.Margin = new Padding(2, 0, 2, 0);
            welcome_txt.Name = "welcome_txt";
            welcome_txt.Size = new Size(300, 86);
            welcome_txt.TabIndex = 1;
            welcome_txt.Text = "Welcome";
            // 
            // tab_Overview
            // 
            tab_Overview.BackColor = Color.FromArgb(94, 78, 64);
            tab_Overview.Controls.Add(Btn_LogOut);
            tab_Overview.Controls.Add(label30);
            tab_Overview.Controls.Add(typesCB);
            tab_Overview.Controls.Add(label29);
            tab_Overview.Controls.Add(label28);
            tab_Overview.Controls.Add(artanPanel1);
            tab_Overview.Controls.Add(btn_search_Animal);
            tab_Overview.Controls.Add(lbl_SearchAnimal);
            tab_Overview.Controls.Add(nameTB);
            tab_Overview.Controls.Add(lv_Animals);
            tab_Overview.Controls.Add(speciesCB);
            tab_Overview.Location = new Point(4, 32);
            tab_Overview.Margin = new Padding(2);
            tab_Overview.Name = "tab_Overview";
            tab_Overview.Padding = new Padding(2);
            tab_Overview.Size = new Size(1639, 556);
            tab_Overview.TabIndex = 1;
            tab_Overview.Text = "Overview";
            // 
            // Btn_LogOut
            // 
            Btn_LogOut.BackColor = Color.FromArgb(221, 66, 76);
            Btn_LogOut.ForeColor = Color.White;
            Btn_LogOut.Location = new Point(1487, 16);
            Btn_LogOut.Margin = new Padding(3, 2, 3, 2);
            Btn_LogOut.Name = "Btn_LogOut";
            Btn_LogOut.Size = new Size(118, 32);
            Btn_LogOut.TabIndex = 31;
            Btn_LogOut.Text = "Logout";
            Btn_LogOut.UseVisualStyleBackColor = false;
            Btn_LogOut.Click += Btn_LogOut_Click_1;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.ForeColor = SystemColors.ControlLightLight;
            label30.Location = new Point(535, 43);
            label30.Name = "label30";
            label30.Size = new Size(53, 25);
            label30.TabIndex = 44;
            label30.Text = "Type:";
            // 
            // typesCB
            // 
            typesCB.FormattingEnabled = true;
            typesCB.Location = new Point(597, 41);
            typesCB.Margin = new Padding(3, 2, 3, 2);
            typesCB.Name = "typesCB";
            typesCB.Size = new Size(133, 31);
            typesCB.TabIndex = 43;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.ForeColor = SystemColors.ControlLightLight;
            label29.Location = new Point(297, 43);
            label29.Name = "label29";
            label29.Size = new Size(75, 25);
            label29.TabIndex = 42;
            label29.Text = "Species:";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.ForeColor = SystemColors.ControlLightLight;
            label28.Location = new Point(47, 44);
            label28.Name = "label28";
            label28.Size = new Size(63, 25);
            label28.TabIndex = 40;
            label28.Text = "Name:";
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.FromArgb(160, 157, 149);
            artanPanel1.BorderRadius = 15;
            artanPanel1.Controls.Add(BTN_updateAnimal);
            artanPanel1.Controls.Add(button1);
            artanPanel1.Controls.Add(label12);
            artanPanel1.Controls.Add(groupBox6);
            artanPanel1.Controls.Add(groupBox7);
            artanPanel1.Controls.Add(groupBox8);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.FromArgb(164, 156, 159);
            artanPanel1.GradientTopColor = Color.FromArgb(164, 156, 159);
            artanPanel1.Location = new Point(901, 86);
            artanPanel1.Margin = new Padding(3, 2, 3, 2);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(717, 450);
            artanPanel1.TabIndex = 39;
            // 
            // BTN_updateAnimal
            // 
            BTN_updateAnimal.BackColor = Color.FromArgb(221, 66, 76);
            BTN_updateAnimal.ForeColor = Color.White;
            BTN_updateAnimal.Location = new Point(460, 407);
            BTN_updateAnimal.Margin = new Padding(3, 2, 3, 2);
            BTN_updateAnimal.Name = "BTN_updateAnimal";
            BTN_updateAnimal.Size = new Size(118, 32);
            BTN_updateAnimal.TabIndex = 30;
            BTN_updateAnimal.Text = "Update";
            BTN_updateAnimal.UseVisualStyleBackColor = false;
            BTN_updateAnimal.Click += BTN_updateAnimal_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(300, 515);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(161, 35);
            button1.TabIndex = 29;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(258, 14);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(198, 30);
            label12.TabIndex = 28;
            label12.Text = "Animal Information";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(txt_Gender);
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(CB_Father1);
            groupBox6.Controls.Add(CB_Mother1);
            groupBox6.Controls.Add(TB_BirthPlace1);
            groupBox6.Controls.Add(label18);
            groupBox6.Controls.Add(label22);
            groupBox6.Controls.Add(label23);
            groupBox6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox6.Location = new Point(388, 51);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(270, 270);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Extra details";
            // 
            // txt_Gender
            // 
            txt_Gender.Enabled = false;
            txt_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Gender.Location = new Point(18, 221);
            txt_Gender.Margin = new Padding(3, 2, 3, 2);
            txt_Gender.Name = "txt_Gender";
            txt_Gender.ReadOnly = true;
            txt_Gender.Size = new Size(243, 29);
            txt_Gender.TabIndex = 35;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 198);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 34;
            label5.Text = "Gender";
            // 
            // CB_Father1
            // 
            CB_Father1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Father1.FormattingEnabled = true;
            CB_Father1.Location = new Point(18, 111);
            CB_Father1.Margin = new Padding(3, 2, 3, 2);
            CB_Father1.Name = "CB_Father1";
            CB_Father1.Size = new Size(243, 29);
            CB_Father1.TabIndex = 33;
            // 
            // CB_Mother1
            // 
            CB_Mother1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Mother1.FormattingEnabled = true;
            CB_Mother1.Location = new Point(18, 56);
            CB_Mother1.Margin = new Padding(3, 2, 3, 2);
            CB_Mother1.Name = "CB_Mother1";
            CB_Mother1.Size = new Size(243, 29);
            CB_Mother1.TabIndex = 32;
            // 
            // TB_BirthPlace1
            // 
            TB_BirthPlace1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_BirthPlace1.Location = new Point(18, 167);
            TB_BirthPlace1.Margin = new Padding(3, 2, 3, 2);
            TB_BirthPlace1.Name = "TB_BirthPlace1";
            TB_BirthPlace1.Size = new Size(243, 29);
            TB_BirthPlace1.TabIndex = 27;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 31);
            label18.Name = "label18";
            label18.Size = new Size(70, 21);
            label18.TabIndex = 6;
            label18.Text = "Mother:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(18, 141);
            label22.Name = "label22";
            label22.Size = new Size(87, 21);
            label22.TabIndex = 14;
            label22.Text = "Birth Place";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(18, 86);
            label23.Name = "label23";
            label23.Size = new Size(55, 21);
            label23.TabIndex = 16;
            label23.Text = "Father";
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Transparent;
            groupBox7.Controls.Add(CB_Diet1);
            groupBox7.Controls.Add(CB_Type1);
            groupBox7.Controls.Add(CB_Species1);
            groupBox7.Controls.Add(CB_Location1);
            groupBox7.Controls.Add(DT_Birthdate);
            groupBox7.Controls.Add(label19);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(label17);
            groupBox7.Controls.Add(label20);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(TB_name1);
            groupBox7.Controls.Add(label24);
            groupBox7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox7.Location = new Point(16, 51);
            groupBox7.Margin = new Padding(3, 2, 3, 2);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(3, 2, 3, 2);
            groupBox7.Size = new Size(332, 388);
            groupBox7.TabIndex = 26;
            groupBox7.TabStop = false;
            groupBox7.Text = "Animal";
            // 
            // CB_Diet1
            // 
            CB_Diet1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Diet1.FormattingEnabled = true;
            CB_Diet1.Location = new Point(16, 331);
            CB_Diet1.Margin = new Padding(3, 2, 3, 2);
            CB_Diet1.Name = "CB_Diet1";
            CB_Diet1.Size = new Size(300, 29);
            CB_Diet1.TabIndex = 31;
            // 
            // CB_Type1
            // 
            CB_Type1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Type1.FormattingEnabled = true;
            CB_Type1.Location = new Point(16, 275);
            CB_Type1.Margin = new Padding(3, 2, 3, 2);
            CB_Type1.Name = "CB_Type1";
            CB_Type1.Size = new Size(300, 29);
            CB_Type1.TabIndex = 30;
            // 
            // CB_Species1
            // 
            CB_Species1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Species1.FormattingEnabled = true;
            CB_Species1.Location = new Point(16, 219);
            CB_Species1.Margin = new Padding(3, 2, 3, 2);
            CB_Species1.Name = "CB_Species1";
            CB_Species1.Size = new Size(300, 29);
            CB_Species1.TabIndex = 29;
            CB_Species1.SelectedIndexChanged += CB_Species1_SelectedIndexChanged;
            // 
            // CB_Location1
            // 
            CB_Location1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_Location1.FormattingEnabled = true;
            CB_Location1.Location = new Point(16, 166);
            CB_Location1.Margin = new Padding(3, 2, 3, 2);
            CB_Location1.Name = "CB_Location1";
            CB_Location1.Size = new Size(300, 29);
            CB_Location1.TabIndex = 28;
            // 
            // DT_Birthdate
            // 
            DT_Birthdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DT_Birthdate.Location = new Point(16, 111);
            DT_Birthdate.Margin = new Padding(3, 2, 3, 2);
            DT_Birthdate.Name = "DT_Birthdate";
            DT_Birthdate.Size = new Size(300, 29);
            DT_Birthdate.TabIndex = 27;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(16, 306);
            label19.Name = "label19";
            label19.Size = new Size(44, 21);
            label19.TabIndex = 8;
            label19.Text = "Diet:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(16, 194);
            label16.Name = "label16";
            label16.Size = new Size(70, 21);
            label16.TabIndex = 2;
            label16.Text = "Species:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(16, 31);
            label17.Name = "label17";
            label17.Size = new Size(57, 21);
            label17.TabIndex = 0;
            label17.Text = "Name:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(16, 140);
            label20.Name = "label20";
            label20.Size = new Size(77, 21);
            label20.TabIndex = 10;
            label20.Text = "Location:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 250);
            label15.Name = "label15";
            label15.Size = new Size(49, 21);
            label15.TabIndex = 12;
            label15.Text = "Type:";
            // 
            // TB_name1
            // 
            TB_name1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_name1.Location = new Point(16, 56);
            TB_name1.Margin = new Padding(3, 2, 3, 2);
            TB_name1.Name = "TB_name1";
            TB_name1.Size = new Size(300, 29);
            TB_name1.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(16, 86);
            label24.Name = "label24";
            label24.Size = new Size(87, 21);
            label24.TabIndex = 4;
            label24.Text = "Birth Date:";
            // 
            // groupBox8
            // 
            groupBox8.BackColor = Color.Transparent;
            groupBox8.Controls.Add(checkBox1);
            groupBox8.Controls.Add(label27);
            groupBox8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox8.Location = new Point(388, 325);
            groupBox8.Margin = new Padding(3, 2, 3, 2);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(3, 2, 3, 2);
            groupBox8.Size = new Size(270, 79);
            groupBox8.TabIndex = 24;
            groupBox8.TabStop = false;
            groupBox8.Text = "Condition";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(24, 47);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 25);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Animal is Sick";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(24, 24);
            label27.Name = "label27";
            label27.Size = new Size(62, 21);
            label27.TabIndex = 18;
            label27.Text = "Health:";
            // 
            // btn_search_Animal
            // 
            btn_search_Animal.ForeColor = Color.Black;
            btn_search_Animal.Location = new Point(733, 39);
            btn_search_Animal.Margin = new Padding(2);
            btn_search_Animal.Name = "btn_search_Animal";
            btn_search_Animal.Size = new Size(78, 31);
            btn_search_Animal.TabIndex = 33;
            btn_search_Animal.Text = "Search";
            btn_search_Animal.UseVisualStyleBackColor = true;
            btn_search_Animal.Click += btn_search_Animal_Click_1;
            // 
            // lbl_SearchAnimal
            // 
            lbl_SearchAnimal.AutoSize = true;
            lbl_SearchAnimal.BackColor = Color.Transparent;
            lbl_SearchAnimal.Font = new Font("Segoe UI", 13F, FontStyle.Italic, GraphicsUnit.Point);
            lbl_SearchAnimal.ForeColor = Color.White;
            lbl_SearchAnimal.Location = new Point(47, 16);
            lbl_SearchAnimal.Margin = new Padding(1, 0, 1, 0);
            lbl_SearchAnimal.Name = "lbl_SearchAnimal";
            lbl_SearchAnimal.Size = new Size(125, 25);
            lbl_SearchAnimal.TabIndex = 32;
            lbl_SearchAnimal.Text = "Search Animal";
            // 
            // nameTB
            // 
            nameTB.Location = new Point(117, 42);
            nameTB.Margin = new Padding(1);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(169, 31);
            nameTB.TabIndex = 31;
            // 
            // lv_Animals
            // 
            lv_Animals.BackColor = Color.FromArgb(164, 156, 159);
            lv_Animals.BorderStyle = BorderStyle.None;
            lv_Animals.Columns.AddRange(new ColumnHeader[] { Namez, Type, Spiece, Location });
            lv_Animals.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lv_Animals.ForeColor = Color.Black;
            lv_Animals.FullRowSelect = true;
            lv_Animals.Location = new Point(47, 86);
            lv_Animals.Name = "lv_Animals";
            lv_Animals.Size = new Size(805, 454);
            lv_Animals.TabIndex = 21;
            lv_Animals.UseCompatibleStateImageBehavior = false;
            lv_Animals.View = View.Details;
            lv_Animals.SelectedIndexChanged += lv_Animals_SelectedIndexChanged_1;
            // 
            // Namez
            // 
            Namez.Text = "Name";
            Namez.Width = 200;
            // 
            // Type
            // 
            Type.Text = "Type";
            Type.Width = 200;
            // 
            // Location
            // 
            Location.Text = "Location";
            Location.Width = 200;
            // 
            // speciesCB
            // 
            speciesCB.FormattingEnabled = true;
            speciesCB.Location = new Point(382, 40);
            speciesCB.Margin = new Padding(3, 2, 3, 2);
            speciesCB.Name = "speciesCB";
            speciesCB.Size = new Size(133, 31);
            speciesCB.TabIndex = 41;
            speciesCB.SelectedIndexChanged += speciesCB_SelectedIndexChanged_1;
            // 
            // tab_AddAnimal
            // 
            tab_AddAnimal.BackColor = Color.FromArgb(96, 214, 255);
            tab_AddAnimal.Controls.Add(button2);
            tab_AddAnimal.Controls.Add(Btn_AddAnimal);
            tab_AddAnimal.Controls.Add(pictureBox1);
            tab_AddAnimal.Controls.Add(groupBox4);
            tab_AddAnimal.Controls.Add(Gb_Details_employee);
            tab_AddAnimal.Location = new Point(4, 32);
            tab_AddAnimal.Margin = new Padding(2);
            tab_AddAnimal.Name = "tab_AddAnimal";
            tab_AddAnimal.Size = new Size(1639, 556);
            tab_AddAnimal.TabIndex = 2;
            tab_AddAnimal.Text = "Add Animal";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(221, 66, 76);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1430, 30);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 32);
            button2.TabIndex = 85;
            button2.Text = "Logout";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Btn_AddAnimal
            // 
            Btn_AddAnimal.BackColor = Color.Black;
            Btn_AddAnimal.ForeColor = Color.White;
            Btn_AddAnimal.Location = new Point(820, 405);
            Btn_AddAnimal.Margin = new Padding(1);
            Btn_AddAnimal.Name = "Btn_AddAnimal";
            Btn_AddAnimal.Size = new Size(127, 38);
            Btn_AddAnimal.TabIndex = 84;
            Btn_AddAnimal.Text = "Add Animal";
            Btn_AddAnimal.UseVisualStyleBackColor = false;
            Btn_AddAnimal.Click += Btn_AddAnimal_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DimGray;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(228, 66);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 413);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 82;
            pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(255, 209, 159);
            groupBox4.Controls.Add(CB_GenderAdd);
            groupBox4.Controls.Add(lbl_Gender);
            groupBox4.Controls.Add(CB_FatherAdd);
            groupBox4.Controls.Add(CB_MotherAdd);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(TB_BirthPlaceAdd);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(741, 100);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(285, 283);
            groupBox4.TabIndex = 81;
            groupBox4.TabStop = false;
            groupBox4.Text = "Extra Details";
            // 
            // CB_GenderAdd
            // 
            CB_GenderAdd.FormattingEnabled = true;
            CB_GenderAdd.Location = new Point(17, 236);
            CB_GenderAdd.Name = "CB_GenderAdd";
            CB_GenderAdd.Size = new Size(251, 29);
            CB_GenderAdd.TabIndex = 39;
            // 
            // lbl_Gender
            // 
            lbl_Gender.AutoSize = true;
            lbl_Gender.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gender.ForeColor = Color.Black;
            lbl_Gender.Location = new Point(17, 213);
            lbl_Gender.Name = "lbl_Gender";
            lbl_Gender.Size = new Size(59, 20);
            lbl_Gender.TabIndex = 38;
            lbl_Gender.Text = "Gender";
            // 
            // CB_FatherAdd
            // 
            CB_FatherAdd.BackColor = Color.WhiteSmoke;
            CB_FatherAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_FatherAdd.ForeColor = Color.Black;
            CB_FatherAdd.FormattingEnabled = true;
            CB_FatherAdd.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CB_FatherAdd.Location = new Point(17, 110);
            CB_FatherAdd.Margin = new Padding(3, 2, 3, 2);
            CB_FatherAdd.Name = "CB_FatherAdd";
            CB_FatherAdd.Size = new Size(253, 29);
            CB_FatherAdd.TabIndex = 37;
            // 
            // CB_MotherAdd
            // 
            CB_MotherAdd.BackColor = Color.WhiteSmoke;
            CB_MotherAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_MotherAdd.ForeColor = Color.Black;
            CB_MotherAdd.FormattingEnabled = true;
            CB_MotherAdd.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CB_MotherAdd.Location = new Point(17, 49);
            CB_MotherAdd.Margin = new Padding(3, 2, 3, 2);
            CB_MotherAdd.Name = "CB_MotherAdd";
            CB_MotherAdd.Size = new Size(253, 29);
            CB_MotherAdd.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(17, 28);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 2;
            label8.Text = "Mother";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(17, 90);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 4;
            label9.Text = "Father";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(19, 150);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 11;
            label10.Text = "Birthplace";
            // 
            // TB_BirthPlaceAdd
            // 
            TB_BirthPlaceAdd.BackColor = Color.WhiteSmoke;
            TB_BirthPlaceAdd.BorderStyle = BorderStyle.FixedSingle;
            TB_BirthPlaceAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_BirthPlaceAdd.ForeColor = Color.Black;
            TB_BirthPlaceAdd.Location = new Point(17, 171);
            TB_BirthPlaceAdd.Margin = new Padding(3, 2, 3, 2);
            TB_BirthPlaceAdd.Name = "TB_BirthPlaceAdd";
            TB_BirthPlaceAdd.Size = new Size(253, 29);
            TB_BirthPlaceAdd.TabIndex = 26;
            // 
            // Gb_Details_employee
            // 
            Gb_Details_employee.BackColor = Color.FromArgb(255, 209, 159);
            Gb_Details_employee.Controls.Add(CB_LocationAdd);
            Gb_Details_employee.Controls.Add(DT_BirthDateAdd);
            Gb_Details_employee.Controls.Add(CB_DietAdd);
            Gb_Details_employee.Controls.Add(label4);
            Gb_Details_employee.Controls.Add(CB_TypeBoxAdd);
            Gb_Details_employee.Controls.Add(TB_NameAdd);
            Gb_Details_employee.Controls.Add(label6);
            Gb_Details_employee.Controls.Add(label7);
            Gb_Details_employee.Controls.Add(CB_SpeciesBoxAdd);
            Gb_Details_employee.Controls.Add(label11);
            Gb_Details_employee.Controls.Add(label14);
            Gb_Details_employee.Controls.Add(label13);
            Gb_Details_employee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Gb_Details_employee.ForeColor = Color.Black;
            Gb_Details_employee.Location = new Point(434, 66);
            Gb_Details_employee.Margin = new Padding(3, 2, 3, 2);
            Gb_Details_employee.Name = "Gb_Details_employee";
            Gb_Details_employee.Padding = new Padding(3, 2, 3, 2);
            Gb_Details_employee.Size = new Size(287, 413);
            Gb_Details_employee.TabIndex = 80;
            Gb_Details_employee.TabStop = false;
            Gb_Details_employee.Text = "Animal Details";
            // 
            // CB_LocationAdd
            // 
            CB_LocationAdd.BackColor = Color.WhiteSmoke;
            CB_LocationAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_LocationAdd.ForeColor = Color.Black;
            CB_LocationAdd.FormattingEnabled = true;
            CB_LocationAdd.Location = new Point(14, 121);
            CB_LocationAdd.Margin = new Padding(3, 2, 3, 2);
            CB_LocationAdd.Name = "CB_LocationAdd";
            CB_LocationAdd.Size = new Size(253, 29);
            CB_LocationAdd.TabIndex = 86;
            // 
            // DT_BirthDateAdd
            // 
            DT_BirthDateAdd.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            DT_BirthDateAdd.CalendarMonthBackground = SystemColors.ButtonFace;
            DT_BirthDateAdd.CalendarTitleBackColor = SystemColors.ControlText;
            DT_BirthDateAdd.CalendarTitleForeColor = SystemColors.ControlLightLight;
            DT_BirthDateAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DT_BirthDateAdd.Format = DateTimePickerFormat.Short;
            DT_BirthDateAdd.Location = new Point(14, 179);
            DT_BirthDateAdd.Name = "DT_BirthDateAdd";
            DT_BirthDateAdd.Size = new Size(253, 29);
            DT_BirthDateAdd.TabIndex = 85;
            // 
            // CB_DietAdd
            // 
            CB_DietAdd.BackColor = Color.WhiteSmoke;
            CB_DietAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_DietAdd.ForeColor = Color.Black;
            CB_DietAdd.FormattingEnabled = true;
            CB_DietAdd.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CB_DietAdd.Location = new Point(14, 361);
            CB_DietAdd.Margin = new Padding(3, 2, 3, 2);
            CB_DietAdd.Name = "CB_DietAdd";
            CB_DietAdd.Size = new Size(253, 29);
            CB_DietAdd.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 339);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 34;
            label4.Text = "Diet";
            // 
            // CB_TypeBoxAdd
            // 
            CB_TypeBoxAdd.BackColor = Color.WhiteSmoke;
            CB_TypeBoxAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_TypeBoxAdd.ForeColor = Color.Black;
            CB_TypeBoxAdd.FormattingEnabled = true;
            CB_TypeBoxAdd.Location = new Point(14, 300);
            CB_TypeBoxAdd.Margin = new Padding(3, 2, 3, 2);
            CB_TypeBoxAdd.Name = "CB_TypeBoxAdd";
            CB_TypeBoxAdd.Size = new Size(253, 29);
            CB_TypeBoxAdd.TabIndex = 33;
            // 
            // TB_NameAdd
            // 
            TB_NameAdd.BackColor = Color.WhiteSmoke;
            TB_NameAdd.BorderStyle = BorderStyle.FixedSingle;
            TB_NameAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_NameAdd.ForeColor = Color.Black;
            TB_NameAdd.Location = new Point(15, 64);
            TB_NameAdd.Margin = new Padding(3, 2, 3, 2);
            TB_NameAdd.Name = "TB_NameAdd";
            TB_NameAdd.Size = new Size(253, 29);
            TB_NameAdd.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 43);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 2;
            label6.Text = "Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(15, 100);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 4;
            label7.Text = "Location";
            // 
            // CB_SpeciesBoxAdd
            // 
            CB_SpeciesBoxAdd.BackColor = Color.WhiteSmoke;
            CB_SpeciesBoxAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CB_SpeciesBoxAdd.ForeColor = Color.Black;
            CB_SpeciesBoxAdd.FormattingEnabled = true;
            CB_SpeciesBoxAdd.Location = new Point(15, 247);
            CB_SpeciesBoxAdd.Margin = new Padding(3, 2, 3, 2);
            CB_SpeciesBoxAdd.Name = "CB_SpeciesBoxAdd";
            CB_SpeciesBoxAdd.Size = new Size(253, 29);
            CB_SpeciesBoxAdd.TabIndex = 32;
            CB_SpeciesBoxAdd.SelectedIndexChanged += CB_SpeciesBoxAdd_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(9, 158);
            label11.Name = "label11";
            label11.Size = new Size(72, 20);
            label11.TabIndex = 11;
            label11.Text = "Birthdate";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.Black;
            label14.Location = new Point(9, 225);
            label14.Name = "label14";
            label14.Size = new Size(59, 20);
            label14.TabIndex = 14;
            label14.Text = "Species";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(9, 278);
            label13.Name = "label13";
            label13.Size = new Size(41, 20);
            label13.TabIndex = 13;
            label13.Text = "Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(CB_DeathDateBox);
            groupBox2.Controls.Add(CHB_Sick);
            groupBox2.Location = new Point(887, 828);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(5);
            groupBox2.Size = new Size(733, 328);
            groupBox2.TabIndex = 79;
            groupBox2.TabStop = false;
            groupBox2.Text = "Health status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 144);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 75;
            label2.Text = "DeathDate";
            // 
            // CB_DeathDateBox
            // 
            CB_DeathDateBox.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CB_DeathDateBox.CalendarMonthBackground = SystemColors.ButtonFace;
            CB_DeathDateBox.CalendarTitleBackColor = SystemColors.ControlText;
            CB_DeathDateBox.CalendarTitleForeColor = SystemColors.ControlLightLight;
            CB_DeathDateBox.Format = DateTimePickerFormat.Short;
            CB_DeathDateBox.Location = new Point(34, 202);
            CB_DeathDateBox.Margin = new Padding(7);
            CB_DeathDateBox.Name = "CB_DeathDateBox";
            CB_DeathDateBox.Size = new Size(609, 23);
            CB_DeathDateBox.TabIndex = 75;
            // 
            // CHB_Sick
            // 
            CHB_Sick.AutoSize = true;
            CHB_Sick.Location = new Point(34, 76);
            CHB_Sick.Margin = new Padding(4);
            CHB_Sick.Name = "CHB_Sick";
            CHB_Sick.Size = new Size(98, 19);
            CHB_Sick.TabIndex = 69;
            CHB_Sick.Text = "Animal is sick";
            CHB_Sick.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(TB_BirthPlace);
            groupBox3.Controls.Add(TB_Father);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(lbl_Phonenumber);
            groupBox3.Controls.Add(TB_Mother);
            groupBox3.Location = new Point(887, 210);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(733, 590);
            groupBox3.TabIndex = 78;
            groupBox3.TabStop = false;
            groupBox3.Text = "Extra Details";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(31, 344);
            label26.Margin = new Padding(5, 0, 5, 0);
            label26.Name = "label26";
            label26.Size = new Size(63, 15);
            label26.TabIndex = 40;
            label26.Text = "Birth Place";
            // 
            // TB_BirthPlace
            // 
            TB_BirthPlace.BackColor = SystemColors.ButtonFace;
            TB_BirthPlace.Location = new Point(34, 408);
            TB_BirthPlace.Margin = new Padding(5);
            TB_BirthPlace.Name = "TB_BirthPlace";
            TB_BirthPlace.Size = new Size(609, 23);
            TB_BirthPlace.TabIndex = 39;
            // 
            // TB_Father
            // 
            TB_Father.BackColor = SystemColors.ButtonFace;
            TB_Father.Location = new Point(34, 271);
            TB_Father.Margin = new Padding(5);
            TB_Father.Name = "TB_Father";
            TB_Father.Size = new Size(609, 23);
            TB_Father.TabIndex = 38;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(34, 207);
            label25.Margin = new Padding(5, 0, 5, 0);
            label25.Name = "label25";
            label25.Size = new Size(40, 15);
            label25.TabIndex = 37;
            label25.Text = "Father";
            // 
            // lbl_Phonenumber
            // 
            lbl_Phonenumber.AutoSize = true;
            lbl_Phonenumber.Location = new Point(31, 69);
            lbl_Phonenumber.Margin = new Padding(5, 0, 5, 0);
            lbl_Phonenumber.Name = "lbl_Phonenumber";
            lbl_Phonenumber.Size = new Size(46, 15);
            lbl_Phonenumber.TabIndex = 36;
            lbl_Phonenumber.Text = "Mother";
            // 
            // TB_Mother
            // 
            TB_Mother.BackColor = SystemColors.ButtonFace;
            TB_Mother.Location = new Point(34, 133);
            TB_Mother.Margin = new Padding(5);
            TB_Mother.Name = "TB_Mother";
            TB_Mother.Size = new Size(609, 23);
            TB_Mother.TabIndex = 35;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TB_Species);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(lbl_Job);
            groupBox1.Controls.Add(TB_Diet);
            groupBox1.Controls.Add(TB_Type);
            groupBox1.Controls.Add(lbl_BSN);
            groupBox1.Controls.Add(lbl_firstname);
            groupBox1.Controls.Add(CB_BirthDateBoxHR);
            groupBox1.Controls.Add(TB_Name);
            groupBox1.Controls.Add(lbl_birthdate);
            groupBox1.Controls.Add(TB_Location);
            groupBox1.Location = new Point(100, 210);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(709, 946);
            groupBox1.TabIndex = 70;
            groupBox1.TabStop = false;
            groupBox1.Text = "Animal Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 481);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 74;
            label1.Text = "Type";
            // 
            // TB_Species
            // 
            TB_Species.BackColor = SystemColors.ButtonFace;
            TB_Species.Location = new Point(29, 682);
            TB_Species.Margin = new Padding(5);
            TB_Species.Name = "TB_Species";
            TB_Species.Size = new Size(609, 23);
            TB_Species.TabIndex = 73;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(29, 618);
            label21.Margin = new Padding(5, 0, 5, 0);
            label21.Name = "label21";
            label21.Size = new Size(46, 15);
            label21.TabIndex = 34;
            label21.Text = "Species";
            // 
            // lbl_Job
            // 
            lbl_Job.AutoSize = true;
            lbl_Job.Location = new Point(32, 207);
            lbl_Job.Margin = new Padding(5, 0, 5, 0);
            lbl_Job.Name = "lbl_Job";
            lbl_Job.Size = new Size(53, 15);
            lbl_Job.TabIndex = 72;
            lbl_Job.Text = "Location";
            // 
            // TB_Diet
            // 
            TB_Diet.BackColor = SystemColors.ButtonFace;
            TB_Diet.Location = new Point(29, 820);
            TB_Diet.Margin = new Padding(5);
            TB_Diet.Name = "TB_Diet";
            TB_Diet.Size = new Size(609, 23);
            TB_Diet.TabIndex = 71;
            // 
            // TB_Type
            // 
            TB_Type.BackColor = SystemColors.ButtonFace;
            TB_Type.Location = new Point(29, 544);
            TB_Type.Margin = new Padding(5);
            TB_Type.Name = "TB_Type";
            TB_Type.Size = new Size(609, 23);
            TB_Type.TabIndex = 39;
            // 
            // lbl_BSN
            // 
            lbl_BSN.AutoSize = true;
            lbl_BSN.Location = new Point(32, 756);
            lbl_BSN.Margin = new Padding(5, 0, 5, 0);
            lbl_BSN.Name = "lbl_BSN";
            lbl_BSN.Size = new Size(28, 15);
            lbl_BSN.TabIndex = 40;
            lbl_BSN.Text = "Diet";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Location = new Point(31, 69);
            lbl_firstname.Margin = new Padding(5, 0, 5, 0);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(39, 15);
            lbl_firstname.TabIndex = 28;
            lbl_firstname.Text = "Name";
            // 
            // CB_BirthDateBoxHR
            // 
            CB_BirthDateBoxHR.CalendarFont = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            CB_BirthDateBoxHR.CalendarMonthBackground = SystemColors.ButtonFace;
            CB_BirthDateBoxHR.CalendarTitleBackColor = SystemColors.ControlText;
            CB_BirthDateBoxHR.CalendarTitleForeColor = SystemColors.ControlLightLight;
            CB_BirthDateBoxHR.Format = DateTimePickerFormat.Short;
            CB_BirthDateBoxHR.Location = new Point(31, 405);
            CB_BirthDateBoxHR.Margin = new Padding(7);
            CB_BirthDateBoxHR.Name = "CB_BirthDateBoxHR";
            CB_BirthDateBoxHR.Size = new Size(609, 23);
            CB_BirthDateBoxHR.TabIndex = 69;
            // 
            // TB_Name
            // 
            TB_Name.BackColor = SystemColors.ButtonFace;
            TB_Name.Location = new Point(31, 133);
            TB_Name.Margin = new Padding(5);
            TB_Name.Name = "TB_Name";
            TB_Name.Size = new Size(609, 23);
            TB_Name.TabIndex = 29;
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.Location = new Point(29, 339);
            lbl_birthdate.Margin = new Padding(5, 0, 5, 0);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(56, 15);
            lbl_birthdate.TabIndex = 38;
            lbl_birthdate.Text = "BirthDate";
            // 
            // TB_Location
            // 
            TB_Location.BackColor = SystemColors.ButtonFace;
            TB_Location.Location = new Point(29, 266);
            TB_Location.Margin = new Padding(5);
            TB_Location.Name = "TB_Location";
            TB_Location.Size = new Size(611, 23);
            TB_Location.TabIndex = 33;
            // 
            // btn_ViewDetails
            // 
            btn_ViewDetails.BackColor = Color.Black;
            btn_ViewDetails.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewDetails.ForeColor = Color.White;
            btn_ViewDetails.Location = new Point(719, 1368);
            btn_ViewDetails.Name = "btn_ViewDetails";
            btn_ViewDetails.Size = new Size(391, 90);
            btn_ViewDetails.TabIndex = 0;
            btn_ViewDetails.Text = "Update";
            btn_ViewDetails.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(615, 33);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(492, 72);
            label3.TabIndex = 27;
            label3.Text = "Animal Information";
            // 
            // PictureBoxAddEmployee
            // 
            PictureBoxAddEmployee.BackColor = Color.Transparent;
            PictureBoxAddEmployee.BackgroundImageLayout = ImageLayout.None;
            PictureBoxAddEmployee.Location = new Point(80, 66);
            PictureBoxAddEmployee.Margin = new Padding(7, 5, 7, 5);
            PictureBoxAddEmployee.Name = "PictureBoxAddEmployee";
            PictureBoxAddEmployee.Size = new Size(534, 458);
            PictureBoxAddEmployee.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxAddEmployee.TabIndex = 79;
            PictureBoxAddEmployee.TabStop = false;
            // 
            // Animal_Management
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(158, 143, 132);
            ClientSize = new Size(1647, 592);
            Controls.Add(tabControl1);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Animal_Management";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tab_welcome.ResumeLayout(false);
            tab_welcome.PerformLayout();
            tab_Overview.ResumeLayout(false);
            tab_Overview.PerformLayout();
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            tab_AddAnimal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            Gb_Details_employee.ResumeLayout(false);
            Gb_Details_employee.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxAddEmployee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tab_welcome;
        private TabPage tab_Overview;
        private TabPage tab_AddAnimal;
        private ListView lv_Animals;
        private ColumnHeader Namez;
        private ColumnHeader Location;
        private ColumnHeader Type;
        private Button btn_search_Animal;
        private Label lbl_SearchAnimal;
        private TextBox nameTB;
        private ArtanPanel artanPanel4;
        private GroupBox groupBox3;
        private Label label26;
        private TextBox TB_BirthPlace;
        private TextBox TB_Father;
        private Label label25;
        private Label lbl_Phonenumber;
        private TextBox TB_Mother;
        private GroupBox groupBox1;
        private Label lbl_Job;
        private TextBox TB_Diet;
        private TextBox TB_Type;
        private Label lbl_BSN;
        private Label lbl_firstname;
        private DateTimePicker CB_BirthDateBoxHR;
        private TextBox TB_Name;
        private Label lbl_birthdate;
        private TextBox TB_Location;
        private Label label21;
        private Button btn_ViewDetails;
        private Label label3;
        private Label label1;
        private TextBox TB_Species;
        private GroupBox groupBox2;
        private GroupBox Gb_Details_employee;
        private ComboBox CB_TypeBoxAdd;
        private TextBox TB_NameAdd;
        private Label label6;
        private Label label7;
        private ComboBox CB_SpeciesBoxAdd;
        private Label label11;
        private Label label14;
        private Label label13;
        private ArtanPanel artanPanel1;
        private PictureBox PictureBoxAddEmployee;
        private Label welcome_txt;
        private CheckBox CHB_Sick;
        private Label label2;
        private DateTimePicker CB_DeathDateBox;
        private Label label4;
        private Button Btn_AddAnimal;
        private GroupBox groupBox4;
        private ComboBox CB_FatherAdd;
        private ComboBox CB_MotherAdd;
        private Label label8;
        private Label label9;
        private TextBox TB_BirthPlaceAdd;
        private ComboBox CB_DietAdd;
        private DateTimePicker DT_BirthDateAdd;
        private ComboBox CB_LocationAdd;
        private Button button1;
        private Label label12;
        private GroupBox groupBox6;
        private TextBox TB_BirthPlace1;
        private Label label18;
        private Label label22;
        private Label label23;
        private GroupBox groupBox7;
        private Label label19;
        private Label label16;
        private Label label20;
        private Label label15;
        private TextBox TB_name1;
        private Label label24;
        private GroupBox groupBox8;
        private Label label27;
        private ColumnHeader Spiece;
        private Button BTN_updateAnimal;
        private ComboBox CB_Father1;
        private ComboBox CB_Mother1;
        private ComboBox CB_Diet1;
        private ComboBox CB_Type1;
        private ComboBox CB_Species1;
        private ComboBox CB_Location1;
        private DateTimePicker DT_Birthdate;
        private CheckBox checkBox1;
        private Label label29;
        private ComboBox speciesCB;
        private Label label28;
        private Label label30;
        private ComboBox typesCB;
        private Label label17;
        private PictureBox pictureBox1;
        private Button Btn_LogOut;
        private Button button2;
        private Label lbl_Gender;
        private Label label10;
        private ComboBox CB_GenderAdd;
        private TextBox txt_Gender;
        private Label label5;
    }
}