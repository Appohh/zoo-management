namespace Desktop_app
{
    partial class Care_Taker
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
            System.Windows.Forms.ColumnHeader BirthDateAnimal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Care_Taker));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Welcome = new System.Windows.Forms.TabPage();
            this.welcome_txt = new System.Windows.Forms.Label();
            this.Overview = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.typesCB = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.speciesCB = new System.Windows.Forms.ComboBox();
            this.artanPanel1 = new Desktop_app.ArtanPanel();
            this.btn_ViewDetails = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TB_Species = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TB_Diet = new System.Windows.Forms.TextBox();
            this.TB_Location = new System.Windows.Forms.TextBox();
            this.TB_Type = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gender = new System.Windows.Forms.Label();
            this.TB_Gender = new System.Windows.Forms.TextBox();
            this.TB_BirthDate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_Mother = new System.Windows.Forms.TextBox();
            this.TB_Father = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TB_BirthPlace = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CHB_Sick = new System.Windows.Forms.CheckBox();
            this.TB_Notes = new System.Windows.Forms.RichTextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btn_search_Animal = new System.Windows.Forms.Button();
            this.Logout_BTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.lv_Animals = new System.Windows.Forms.ListView();
            this.Namez = new System.Windows.Forms.ColumnHeader();
            this.TypeAnimal = new System.Windows.Forms.ColumnHeader();
            this.AnimalLocation = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            BirthDateAnimal = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.Welcome.SuspendLayout();
            this.Overview.SuspendLayout();
            this.artanPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BirthDateAnimal
            // 
            BirthDateAnimal.Text = "BirthDate";
            BirthDateAnimal.Width = 250;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Welcome);
            this.tabControl1.Controls.Add(this.Overview);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1832, 928);
            this.tabControl1.TabIndex = 0;
            // 
            // Welcome
            // 
            this.Welcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Welcome.BackgroundImage")));
            this.Welcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Welcome.Controls.Add(this.welcome_txt);
            this.Welcome.Location = new System.Drawing.Point(4, 29);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(1824, 895);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "Welcome";
            this.Welcome.UseVisualStyleBackColor = true;
            // 
            // welcome_txt
            // 
            this.welcome_txt.AutoSize = true;
            this.welcome_txt.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcome_txt.ForeColor = System.Drawing.Color.Maroon;
            this.welcome_txt.Location = new System.Drawing.Point(661, 160);
            this.welcome_txt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcome_txt.Name = "welcome_txt";
            this.welcome_txt.Size = new System.Drawing.Size(373, 106);
            this.welcome_txt.TabIndex = 1;
            this.welcome_txt.Text = "Welcome";
            // 
            // Overview
            // 
            this.Overview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(78)))), ((int)(((byte)(64)))));
            this.Overview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Overview.Controls.Add(this.label1);
            this.Overview.Controls.Add(this.label30);
            this.Overview.Controls.Add(this.typesCB);
            this.Overview.Controls.Add(this.label29);
            this.Overview.Controls.Add(this.speciesCB);
            this.Overview.Controls.Add(this.artanPanel1);
            this.Overview.Controls.Add(this.btn_search_Animal);
            this.Overview.Controls.Add(this.Logout_BTN);
            this.Overview.Controls.Add(this.label5);
            this.Overview.Controls.Add(this.nameTB);
            this.Overview.Controls.Add(this.lv_Animals);
            this.Overview.Location = new System.Drawing.Point(4, 29);
            this.Overview.Name = "Overview";
            this.Overview.Padding = new System.Windows.Forms.Padding(3);
            this.Overview.Size = new System.Drawing.Size(1824, 895);
            this.Overview.TabIndex = 0;
            this.Overview.Text = "Overview";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 28);
            this.label1.TabIndex = 49;
            this.label1.Text = "Name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(625, 67);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(57, 28);
            this.label30.TabIndex = 48;
            this.label30.Text = "Type:";
            // 
            // typesCB
            // 
            this.typesCB.FormattingEnabled = true;
            this.typesCB.Location = new System.Drawing.Point(688, 67);
            this.typesCB.Name = "typesCB";
            this.typesCB.Size = new System.Drawing.Size(151, 28);
            this.typesCB.TabIndex = 47;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(355, 67);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(81, 28);
            this.label29.TabIndex = 46;
            this.label29.Text = "Species:";
            // 
            // speciesCB
            // 
            this.speciesCB.FormattingEnabled = true;
            this.speciesCB.Location = new System.Drawing.Point(442, 68);
            this.speciesCB.Name = "speciesCB";
            this.speciesCB.Size = new System.Drawing.Size(151, 28);
            this.speciesCB.TabIndex = 45;
            this.speciesCB.SelectedIndexChanged += new System.EventHandler(this.speciesCB_SelectedIndexChanged_1);
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.DimGray;
            this.artanPanel1.BorderRadius = 15;
            this.artanPanel1.Controls.Add(this.btn_ViewDetails);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.Controls.Add(this.groupBox6);
            this.artanPanel1.Controls.Add(this.groupBox4);
            this.artanPanel1.Controls.Add(this.groupBox3);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(156)))), ((int)(((byte)(159)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(156)))), ((int)(((byte)(159)))));
            this.artanPanel1.Location = new System.Drawing.Point(997, 129);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(774, 752);
            this.artanPanel1.TabIndex = 38;
            // 
            // btn_ViewDetails
            // 
            this.btn_ViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_ViewDetails.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ViewDetails.ForeColor = System.Drawing.Color.White;
            this.btn_ViewDetails.Location = new System.Drawing.Point(571, 687);
            this.btn_ViewDetails.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ViewDetails.Name = "btn_ViewDetails";
            this.btn_ViewDetails.Size = new System.Drawing.Size(184, 47);
            this.btn_ViewDetails.TabIndex = 29;
            this.btn_ViewDetails.Text = "Update";
            this.btn_ViewDetails.UseVisualStyleBackColor = false;
            this.btn_ViewDetails.Click += new System.EventHandler(this.btn_ViewDetails_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(295, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 37);
            this.label3.TabIndex = 28;
            this.label3.Text = "Animal Information";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.TB_Species);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.TB_Diet);
            this.groupBox6.Controls.Add(this.TB_Location);
            this.groupBox6.Controls.Add(this.TB_Type);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(29, 413);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(397, 259);
            this.groupBox6.TabIndex = 27;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Category";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 30);
            this.label16.TabIndex = 2;
            this.label16.Text = "Species:";
            // 
            // TB_Species
            // 
            this.TB_Species.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Species.Location = new System.Drawing.Point(6, 79);
            this.TB_Species.Name = "TB_Species";
            this.TB_Species.ReadOnly = true;
            this.TB_Species.Size = new System.Drawing.Size(166, 36);
            this.TB_Species.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(187, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 30);
            this.label20.TabIndex = 10;
            this.label20.Text = "Location:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 125);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 30);
            this.label19.TabIndex = 8;
            this.label19.Text = "Diet:";
            // 
            // TB_Diet
            // 
            this.TB_Diet.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Diet.Location = new System.Drawing.Point(6, 160);
            this.TB_Diet.Name = "TB_Diet";
            this.TB_Diet.ReadOnly = true;
            this.TB_Diet.Size = new System.Drawing.Size(166, 36);
            this.TB_Diet.TabIndex = 9;
            // 
            // TB_Location
            // 
            this.TB_Location.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Location.Location = new System.Drawing.Point(197, 79);
            this.TB_Location.Name = "TB_Location";
            this.TB_Location.ReadOnly = true;
            this.TB_Location.Size = new System.Drawing.Size(180, 36);
            this.TB_Location.TabIndex = 11;
            // 
            // TB_Type
            // 
            this.TB_Type.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Type.Location = new System.Drawing.Point(197, 160);
            this.TB_Type.Name = "TB_Type";
            this.TB_Type.ReadOnly = true;
            this.TB_Type.Size = new System.Drawing.Size(180, 36);
            this.TB_Type.TabIndex = 13;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(187, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 30);
            this.label21.TabIndex = 12;
            this.label21.Text = "Type:";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.gender);
            this.groupBox4.Controls.Add(this.TB_Gender);
            this.groupBox4.Controls.Add(this.TB_BirthDate);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TB_Mother);
            this.groupBox4.Controls.Add(this.TB_Father);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.TB_Name);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.TB_BirthPlace);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(22, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 297);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Animal";
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.Location = new System.Drawing.Point(203, 213);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(90, 30);
            this.gender.TabIndex = 28;
            this.gender.Text = "Gender:";
            // 
            // TB_Gender
            // 
            this.TB_Gender.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Gender.Location = new System.Drawing.Point(203, 247);
            this.TB_Gender.Name = "TB_Gender";
            this.TB_Gender.ReadOnly = true;
            this.TB_Gender.Size = new System.Drawing.Size(181, 36);
            this.TB_Gender.TabIndex = 27;
            // 
            // TB_BirthDate
            // 
            this.TB_BirthDate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_BirthDate.Location = new System.Drawing.Point(203, 75);
            this.TB_BirthDate.Name = "TB_BirthDate";
            this.TB_BirthDate.ReadOnly = true;
            this.TB_BirthDate.Size = new System.Drawing.Size(180, 36);
            this.TB_BirthDate.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 30);
            this.label15.TabIndex = 0;
            this.label15.Text = "Name:";
            // 
            // TB_Mother
            // 
            this.TB_Mother.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Mother.Location = new System.Drawing.Point(203, 165);
            this.TB_Mother.Name = "TB_Mother";
            this.TB_Mother.ReadOnly = true;
            this.TB_Mother.Size = new System.Drawing.Size(180, 36);
            this.TB_Mother.TabIndex = 7;
            // 
            // TB_Father
            // 
            this.TB_Father.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Father.Location = new System.Drawing.Point(9, 165);
            this.TB_Father.Name = "TB_Father";
            this.TB_Father.ReadOnly = true;
            this.TB_Father.Size = new System.Drawing.Size(170, 36);
            this.TB_Father.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(203, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 30);
            this.label18.TabIndex = 6;
            this.label18.Text = "Mother:";
            // 
            // TB_Name
            // 
            this.TB_Name.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_Name.Location = new System.Drawing.Point(6, 75);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.ReadOnly = true;
            this.TB_Name.Size = new System.Drawing.Size(173, 36);
            this.TB_Name.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 132);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(73, 30);
            this.label23.TabIndex = 16;
            this.label23.Text = "Father";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(9, 211);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 30);
            this.label22.TabIndex = 14;
            this.label22.Text = "Birth Place";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(203, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 30);
            this.label17.TabIndex = 4;
            this.label17.Text = "Birth Date:";
            // 
            // TB_BirthPlace
            // 
            this.TB_BirthPlace.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_BirthPlace.Location = new System.Drawing.Point(9, 247);
            this.TB_BirthPlace.Name = "TB_BirthPlace";
            this.TB_BirthPlace.ReadOnly = true;
            this.TB_BirthPlace.Size = new System.Drawing.Size(170, 36);
            this.TB_BirthPlace.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.CHB_Sick);
            this.groupBox3.Controls.Add(this.TB_Notes);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(461, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 580);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condition";
            // 
            // CHB_Sick
            // 
            this.CHB_Sick.AutoSize = true;
            this.CHB_Sick.Location = new System.Drawing.Point(27, 100);
            this.CHB_Sick.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.CHB_Sick.Name = "CHB_Sick";
            this.CHB_Sick.Size = new System.Drawing.Size(162, 34);
            this.CHB_Sick.TabIndex = 68;
            this.CHB_Sick.Text = "Animal is sick";
            this.CHB_Sick.UseVisualStyleBackColor = true;
            // 
            // TB_Notes
            // 
            this.TB_Notes.Location = new System.Drawing.Point(27, 247);
            this.TB_Notes.Name = "TB_Notes";
            this.TB_Notes.Size = new System.Drawing.Size(235, 263);
            this.TB_Notes.TabIndex = 23;
            this.TB_Notes.Text = "";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(27, 59);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 30);
            this.label24.TabIndex = 18;
            this.label24.Text = "Health:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(27, 197);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 30);
            this.label26.TabIndex = 22;
            this.label26.Text = "Notes:";
            // 
            // btn_search_Animal
            // 
            this.btn_search_Animal.ForeColor = System.Drawing.Color.Black;
            this.btn_search_Animal.Location = new System.Drawing.Point(863, 69);
            this.btn_search_Animal.Name = "btn_search_Animal";
            this.btn_search_Animal.Size = new System.Drawing.Size(94, 29);
            this.btn_search_Animal.TabIndex = 36;
            this.btn_search_Animal.Text = "Search";
            this.btn_search_Animal.UseVisualStyleBackColor = true;
            this.btn_search_Animal.Click += new System.EventHandler(this.btn_search_Animal_Click);
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.Logout_BTN.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Logout_BTN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Logout_BTN.Location = new System.Drawing.Point(1583, 59);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Size = new System.Drawing.Size(170, 45);
            this.Logout_BTN.TabIndex = 33;
            this.Logout_BTN.Text = "Logout";
            this.Logout_BTN.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "Search Animal";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(137, 69);
            this.nameTB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(193, 27);
            this.nameTB.TabIndex = 34;
            // 
            // lv_Animals
            // 
            this.lv_Animals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(156)))), ((int)(((byte)(159)))));
            this.lv_Animals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Animals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Namez,
            BirthDateAnimal,
            this.TypeAnimal,
            this.AnimalLocation,
            this.columnHeader1});
            this.lv_Animals.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Animals.ForeColor = System.Drawing.Color.Black;
            this.lv_Animals.FullRowSelect = true;
            this.lv_Animals.Location = new System.Drawing.Point(37, 132);
            this.lv_Animals.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lv_Animals.Name = "lv_Animals";
            this.lv_Animals.Size = new System.Drawing.Size(920, 749);
            this.lv_Animals.TabIndex = 30;
            this.lv_Animals.UseCompatibleStateImageBehavior = false;
            this.lv_Animals.View = System.Windows.Forms.View.Details;
            this.lv_Animals.SelectedIndexChanged += new System.EventHandler(this.lv_Animals_SelectedIndexChanged_1);
            // 
            // Namez
            // 
            this.Namez.Text = "Name";
            this.Namez.Width = 200;
            // 
            // TypeAnimal
            // 
            this.TypeAnimal.Text = "Type";
            this.TypeAnimal.Width = 200;
            // 
            // AnimalLocation
            // 
            this.AnimalLocation.DisplayIndex = 4;
            this.AnimalLocation.Text = "Location";
            this.AnimalLocation.Width = 250;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 3;
            this.columnHeader1.Text = "Species";
            this.columnHeader1.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Care_Taker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(143)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1832, 928);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "Care_Taker";
            this.Text = "Care Taker";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.Welcome.ResumeLayout(false);
            this.Welcome.PerformLayout();
            this.Overview.ResumeLayout(false);
            this.Overview.PerformLayout();
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage Overview;
        private Button Logout_BTN;
        private Label label5;
        private TextBox nameTB;
        private ListView lv_Animals;
        private ColumnHeader Namez;
        private ColumnHeader TypeAnimal;
        private Button btn_search_Animal;
        private TabPage Welcome;
        private Label welcome_txt;
        private ColumnHeader AnimalLocation;
        private Label label26;
        private Label label24;
        private TextBox TB_Father;
        private Label label23;
        private TextBox TB_BirthPlace;
        private Label label22;
        private TextBox TB_Type;
        private Label label21;
        private TextBox TB_Location;
        private Label label20;
        private TextBox TB_Diet;
        private Label label19;
        private TextBox TB_Mother;
        private Label label18;
        private Label label17;
        private TextBox TB_Species;
        private Label label16;
        private TextBox TB_Name;
        private Label label15;
        private GroupBox groupBox3;
        private RichTextBox TB_Notes;
        private ArtanPanel artanPanel1;
        private GroupBox groupBox6;
        private GroupBox groupBox4;
        private Label label3;
        private Button btn_ViewDetails;
        private CheckBox CHB_Sick;
        private ColumnHeader columnHeader1;
        private TextBox TB_BirthDate;
        private Label gender;
        private TextBox TB_Gender;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label30;
        private ComboBox typesCB;
        private Label label29;
        private ComboBox speciesCB;
    }
}