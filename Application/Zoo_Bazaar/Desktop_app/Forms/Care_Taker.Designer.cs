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
            ColumnHeader BirthDateAnimal;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Care_Taker));
            tabControl1 = new TabControl();
            Welcome = new TabPage();
            welcome_txt = new Label();
            Overview = new TabPage();
            artanPanel1 = new ArtanPanel();
            btn_ViewDetails = new Button();
            label3 = new Label();
            groupBox6 = new GroupBox();
            label16 = new Label();
            TB_Species = new TextBox();
            label20 = new Label();
            label19 = new Label();
            TB_Diet = new TextBox();
            TB_Location = new TextBox();
            TB_Type = new TextBox();
            label21 = new Label();
            groupBox4 = new GroupBox();
            TB_BirthDate = new TextBox();
            label15 = new Label();
            TB_Mother = new TextBox();
            TB_Father = new TextBox();
            label18 = new Label();
            TB_Name = new TextBox();
            label23 = new Label();
            label22 = new Label();
            label17 = new Label();
            TB_BirthPlace = new TextBox();
            groupBox3 = new GroupBox();
            CHB_Sick = new CheckBox();
            TB_Notes = new RichTextBox();
            label24 = new Label();
            label26 = new Label();
            btn_search_Animal = new Button();
            button3 = new Button();
            label5 = new Label();
            txt_search = new TextBox();
            lv_Animals = new ListView();
            Namez = new ColumnHeader();
            TypeAnimal = new ColumnHeader();
            AnimalLocation = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            BirthDateAnimal = new ColumnHeader();
            tabControl1.SuspendLayout();
            Welcome.SuspendLayout();
            Overview.SuspendLayout();
            artanPanel1.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // BirthDateAnimal
            // 
            BirthDateAnimal.Text = "BirthDate";
            BirthDateAnimal.Width = 250;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Welcome);
            tabControl1.Controls.Add(Overview);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1603, 696);
            tabControl1.TabIndex = 0;
            // 
            // Welcome
            // 
            Welcome.BackgroundImage = (Image)resources.GetObject("Welcome.BackgroundImage");
            Welcome.BackgroundImageLayout = ImageLayout.Stretch;
            Welcome.Controls.Add(welcome_txt);
            Welcome.Location = new Point(4, 24);
            Welcome.Margin = new Padding(3, 2, 3, 2);
            Welcome.Name = "Welcome";
            Welcome.Size = new Size(1595, 668);
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
            // Overview
            // 
            Overview.BackColor = Color.FromArgb(96, 214, 255);
            Overview.BackgroundImageLayout = ImageLayout.Stretch;
            Overview.Controls.Add(artanPanel1);
            Overview.Controls.Add(btn_search_Animal);
            Overview.Controls.Add(button3);
            Overview.Controls.Add(label5);
            Overview.Controls.Add(txt_search);
            Overview.Controls.Add(lv_Animals);
            Overview.Location = new Point(4, 24);
            Overview.Margin = new Padding(3, 2, 3, 2);
            Overview.Name = "Overview";
            Overview.Padding = new Padding(3, 2, 3, 2);
            Overview.Size = new Size(1595, 668);
            Overview.TabIndex = 0;
            Overview.Text = "Overview";
            Overview.Click += Overview_Click;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.DimGray;
            artanPanel1.BorderRadius = 15;
            artanPanel1.Controls.Add(btn_ViewDetails);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(groupBox6);
            artanPanel1.Controls.Add(groupBox4);
            artanPanel1.Controls.Add(groupBox3);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.FromArgb(255, 209, 159);
            artanPanel1.GradientTopColor = Color.FromArgb(255, 209, 159);
            artanPanel1.Location = new Point(872, 97);
            artanPanel1.Margin = new Padding(3, 2, 3, 2);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(677, 564);
            artanPanel1.TabIndex = 38;
            // 
            // btn_ViewDetails
            // 
            btn_ViewDetails.BackColor = Color.FromArgb(221, 66, 76);
            btn_ViewDetails.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ViewDetails.ForeColor = Color.White;
            btn_ViewDetails.Location = new Point(501, 508);
            btn_ViewDetails.Margin = new Padding(2);
            btn_ViewDetails.Name = "btn_ViewDetails";
            btn_ViewDetails.Size = new Size(161, 35);
            btn_ViewDetails.TabIndex = 29;
            btn_ViewDetails.Text = "Update";
            btn_ViewDetails.UseVisualStyleBackColor = false;
            btn_ViewDetails.Click += btn_ViewDetails_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(258, 14);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(198, 30);
            label3.TabIndex = 28;
            label3.Text = "Animal Information";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.Transparent;
            groupBox6.Controls.Add(label16);
            groupBox6.Controls.Add(TB_Species);
            groupBox6.Controls.Add(label20);
            groupBox6.Controls.Add(label19);
            groupBox6.Controls.Add(TB_Diet);
            groupBox6.Controls.Add(TB_Location);
            groupBox6.Controls.Add(TB_Type);
            groupBox6.Controls.Add(label21);
            groupBox6.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox6.Location = new Point(25, 310);
            groupBox6.Margin = new Padding(3, 2, 3, 2);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(3, 2, 3, 2);
            groupBox6.Size = new Size(347, 194);
            groupBox6.TabIndex = 27;
            groupBox6.TabStop = false;
            groupBox6.Text = "Category";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 34);
            label16.Name = "label16";
            label16.Size = new Size(75, 25);
            label16.TabIndex = 2;
            label16.Text = "Species:";
            // 
            // TB_Species
            // 
            TB_Species.BackColor = SystemColors.ControlDark;
            TB_Species.Location = new Point(5, 59);
            TB_Species.Margin = new Padding(3, 2, 3, 2);
            TB_Species.Name = "TB_Species";
            TB_Species.ReadOnly = true;
            TB_Species.Size = new Size(146, 31);
            TB_Species.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(164, 34);
            label20.Name = "label20";
            label20.Size = new Size(83, 25);
            label20.TabIndex = 10;
            label20.Text = "Location:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(15, 94);
            label19.Name = "label19";
            label19.Size = new Size(48, 25);
            label19.TabIndex = 8;
            label19.Text = "Diet:";
            // 
            // TB_Diet
            // 
            TB_Diet.BackColor = SystemColors.ControlDark;
            TB_Diet.Location = new Point(5, 120);
            TB_Diet.Margin = new Padding(3, 2, 3, 2);
            TB_Diet.Name = "TB_Diet";
            TB_Diet.ReadOnly = true;
            TB_Diet.Size = new Size(146, 31);
            TB_Diet.TabIndex = 9;
            // 
            // TB_Location
            // 
            TB_Location.BackColor = SystemColors.ControlDark;
            TB_Location.Location = new Point(172, 59);
            TB_Location.Margin = new Padding(3, 2, 3, 2);
            TB_Location.Name = "TB_Location";
            TB_Location.ReadOnly = true;
            TB_Location.Size = new Size(158, 31);
            TB_Location.TabIndex = 11;
            // 
            // TB_Type
            // 
            TB_Type.BackColor = SystemColors.ControlDark;
            TB_Type.Location = new Point(172, 120);
            TB_Type.Margin = new Padding(3, 2, 3, 2);
            TB_Type.Name = "TB_Type";
            TB_Type.ReadOnly = true;
            TB_Type.Size = new Size(158, 31);
            TB_Type.TabIndex = 13;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(164, 94);
            label21.Name = "label21";
            label21.Size = new Size(53, 25);
            label21.TabIndex = 12;
            label21.Text = "Type:";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Transparent;
            groupBox4.Controls.Add(TB_BirthDate);
            groupBox4.Controls.Add(label15);
            groupBox4.Controls.Add(TB_Mother);
            groupBox4.Controls.Add(TB_Father);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(TB_Name);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(TB_BirthPlace);
            groupBox4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(19, 69);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(354, 223);
            groupBox4.TabIndex = 26;
            groupBox4.TabStop = false;
            groupBox4.Text = "Animal";
            // 
            // TB_BirthDate
            // 
            TB_BirthDate.BackColor = SystemColors.ControlDark;
            TB_BirthDate.Location = new Point(178, 56);
            TB_BirthDate.Margin = new Padding(3, 2, 3, 2);
            TB_BirthDate.Name = "TB_BirthDate";
            TB_BirthDate.ReadOnly = true;
            TB_BirthDate.Size = new Size(158, 31);
            TB_BirthDate.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 31);
            label15.Name = "label15";
            label15.Size = new Size(63, 25);
            label15.TabIndex = 0;
            label15.Text = "Name:";
            // 
            // TB_Mother
            // 
            TB_Mother.BackColor = SystemColors.ControlDark;
            TB_Mother.Location = new Point(178, 124);
            TB_Mother.Margin = new Padding(3, 2, 3, 2);
            TB_Mother.Name = "TB_Mother";
            TB_Mother.ReadOnly = true;
            TB_Mother.Size = new Size(158, 31);
            TB_Mother.TabIndex = 7;
            // 
            // TB_Father
            // 
            TB_Father.BackColor = SystemColors.ControlDark;
            TB_Father.Location = new Point(8, 124);
            TB_Father.Margin = new Padding(3, 2, 3, 2);
            TB_Father.Name = "TB_Father";
            TB_Father.ReadOnly = true;
            TB_Father.Size = new Size(149, 31);
            TB_Father.TabIndex = 17;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(178, 99);
            label18.Name = "label18";
            label18.Size = new Size(74, 25);
            label18.TabIndex = 6;
            label18.Text = "Mother:";
            // 
            // TB_Name
            // 
            TB_Name.BackColor = SystemColors.ControlDark;
            TB_Name.Location = new Point(5, 56);
            TB_Name.Margin = new Padding(3, 2, 3, 2);
            TB_Name.Name = "TB_Name";
            TB_Name.ReadOnly = true;
            TB_Name.Size = new Size(152, 31);
            TB_Name.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(8, 99);
            label23.Name = "label23";
            label23.Size = new Size(60, 25);
            label23.TabIndex = 16;
            label23.Text = "Father";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(8, 158);
            label22.Name = "label22";
            label22.Size = new Size(93, 25);
            label22.TabIndex = 14;
            label22.Text = "Birth Place";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(178, 31);
            label17.Name = "label17";
            label17.Size = new Size(94, 25);
            label17.TabIndex = 4;
            label17.Text = "Birth Date:";
            // 
            // TB_BirthPlace
            // 
            TB_BirthPlace.BackColor = SystemColors.ControlDark;
            TB_BirthPlace.Location = new Point(8, 185);
            TB_BirthPlace.Margin = new Padding(3, 2, 3, 2);
            TB_BirthPlace.Name = "TB_BirthPlace";
            TB_BirthPlace.ReadOnly = true;
            TB_BirthPlace.Size = new Size(329, 31);
            TB_BirthPlace.TabIndex = 15;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(CHB_Sick);
            groupBox3.Controls.Add(TB_Notes);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label26);
            groupBox3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(403, 69);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(259, 435);
            groupBox3.TabIndex = 24;
            groupBox3.TabStop = false;
            groupBox3.Text = "Condition";
            // 
            // CHB_Sick
            // 
            CHB_Sick.AutoSize = true;
            CHB_Sick.Location = new Point(24, 75);
            CHB_Sick.Margin = new Padding(2);
            CHB_Sick.Name = "CHB_Sick";
            CHB_Sick.Size = new Size(137, 29);
            CHB_Sick.TabIndex = 68;
            CHB_Sick.Text = "Animal is sick";
            CHB_Sick.UseVisualStyleBackColor = true;
            // 
            // TB_Notes
            // 
            TB_Notes.Location = new Point(24, 185);
            TB_Notes.Margin = new Padding(3, 2, 3, 2);
            TB_Notes.Name = "TB_Notes";
            TB_Notes.Size = new Size(206, 198);
            TB_Notes.TabIndex = 23;
            TB_Notes.Text = "";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(24, 44);
            label24.Name = "label24";
            label24.Size = new Size(67, 25);
            label24.TabIndex = 18;
            label24.Text = "Health:";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(24, 148);
            label26.Name = "label26";
            label26.Size = new Size(63, 25);
            label26.TabIndex = 22;
            label26.Text = "Notes:";
            // 
            // btn_search_Animal
            // 
            btn_search_Animal.ForeColor = Color.Black;
            btn_search_Animal.Location = new Point(223, 54);
            btn_search_Animal.Margin = new Padding(3, 2, 3, 2);
            btn_search_Animal.Name = "btn_search_Animal";
            btn_search_Animal.Size = new Size(82, 22);
            btn_search_Animal.TabIndex = 36;
            btn_search_Animal.Text = "Search";
            btn_search_Animal.UseVisualStyleBackColor = true;
            btn_search_Animal.Click += btn_search_Animal_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(221, 66, 76);
            button3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(1385, 44);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(149, 34);
            button3.TabIndex = 33;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(32, 32);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 21);
            label5.TabIndex = 35;
            label5.Text = "Search Animal";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(32, 56);
            txt_search.Margin = new Padding(2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(169, 23);
            txt_search.TabIndex = 34;
            // 
            // lv_Animals
            // 
            lv_Animals.BackColor = Color.FromArgb(255, 209, 159);
            lv_Animals.BorderStyle = BorderStyle.None;
            lv_Animals.Columns.AddRange(new ColumnHeader[] { Namez, BirthDateAnimal, TypeAnimal, AnimalLocation, columnHeader1 });
            lv_Animals.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lv_Animals.ForeColor = Color.Black;
            lv_Animals.FullRowSelect = true;
            lv_Animals.Location = new Point(32, 99);
            lv_Animals.Margin = new Padding(4, 3, 4, 3);
            lv_Animals.Name = "lv_Animals";
            lv_Animals.Size = new Size(805, 562);
            lv_Animals.TabIndex = 30;
            lv_Animals.UseCompatibleStateImageBehavior = false;
            lv_Animals.View = View.Details;
            lv_Animals.SelectedIndexChanged += lv_Animals_SelectedIndexChanged_1;
            // 
            // Namez
            // 
            Namez.Text = "Name";
            Namez.Width = 200;
            // 
            // TypeAnimal
            // 
            TypeAnimal.Text = "Type";
            TypeAnimal.Width = 200;
            // 
            // AnimalLocation
            // 
            AnimalLocation.DisplayIndex = 4;
            AnimalLocation.Text = "Location";
            AnimalLocation.Width = 250;
            // 
            // columnHeader1
            // 
            columnHeader1.DisplayIndex = 3;
            columnHeader1.Text = "Species";
            columnHeader1.Width = 200;
            // 
            // Care_Taker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1603, 696);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Care_Taker";
            Text = "Zoo_Keeper";
            WindowState = FormWindowState.Maximized;
            Load += Care_Taker_Load;
            tabControl1.ResumeLayout(false);
            Welcome.ResumeLayout(false);
            Welcome.PerformLayout();
            Overview.ResumeLayout(false);
            Overview.PerformLayout();
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Overview;
        private Button button3;
        private Label label5;
        private TextBox txt_search;
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
    }
}