namespace Desktop_app
{
    partial class Zoo_Keeper
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
            ColumnHeader AnimalSpecies;
            btn_add_animal_HR = new Button();
            label5 = new Label();
            label4 = new Label();
            label1 = new Label();
            lv_Animals = new ListView();
            Name = new ColumnHeader();
            Birthdate = new ColumnHeader();
            AnimalType = new ColumnHeader();
            AnimalLocation = new ColumnHeader();
            Birthplace = new ColumnHeader();
            AnimalNameLabel = new Label();
            artanPanel1 = new ArtanPanel();
            button1 = new Button();
            label2 = new Label();
            artanPanel2 = new ArtanPanel();
            btn_details_zookeeper = new Button();
            label3 = new Label();
            AnimalSpecies = new ColumnHeader();
            artanPanel1.SuspendLayout();
            artanPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // AnimalSpecies
            // 
            AnimalSpecies.Text = "Species";
            AnimalSpecies.Width = 150;
            // 
            // btn_add_animal_HR
            // 
            btn_add_animal_HR.BackColor = Color.FromArgb(221, 66, 76);
            btn_add_animal_HR.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_animal_HR.ForeColor = SystemColors.ActiveCaptionText;
            btn_add_animal_HR.Location = new Point(657, 55);
            btn_add_animal_HR.Name = "btn_add_animal_HR";
            btn_add_animal_HR.Size = new Size(185, 32);
            btn_add_animal_HR.TabIndex = 33;
            btn_add_animal_HR.Text = "Add Animal";
            btn_add_animal_HR.UseVisualStyleBackColor = false;
            btn_add_animal_HR.Click += btn_add_animal_HR_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(5, 62);
            label5.Name = "label5";
            label5.Size = new Size(61, 25);
            label5.TabIndex = 31;
            label5.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(221, 66, 76);
            label4.Location = new Point(221, 8);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 30;
            label4.Text = "Home";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 6);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 29;
            label1.Text = "Zoo Bazaar - ZooKeeper /";
            // 
            // lv_Animals
            // 
            lv_Animals.BackColor = Color.FromArgb(44, 44, 44);
            lv_Animals.BorderStyle = BorderStyle.None;
            lv_Animals.Columns.AddRange(new ColumnHeader[] { Name, Birthdate, AnimalType, AnimalSpecies, AnimalLocation, Birthplace });
            lv_Animals.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lv_Animals.ForeColor = Color.White;
            lv_Animals.FullRowSelect = true;
            lv_Animals.Location = new Point(4, 162);
            lv_Animals.Margin = new Padding(4, 4, 4, 4);
            lv_Animals.Name = "lv_Animals";
            lv_Animals.Size = new Size(870, 480);
            lv_Animals.TabIndex = 28;
            lv_Animals.UseCompatibleStateImageBehavior = false;
            lv_Animals.View = View.Details;
            lv_Animals.SelectedIndexChanged += lv_Animals_SelectedIndexChanged;
            // 
            // Name
            // 
            Name.Text = "Name";
            Name.Width = 150;
            // 
            // Birthdate
            // 
            Birthdate.Text = "Birthdate";
            Birthdate.Width = 150;
            // 
            // AnimalType
            // 
            AnimalType.Text = "Type";
            AnimalType.Width = 150;
            // 
            // AnimalLocation
            // 
            AnimalLocation.Text = "Location";
            AnimalLocation.Width = 150;
            // 
            // Birthplace
            // 
            Birthplace.Text = "Birthplace";
            Birthplace.Width = 150;
            // 
            // AnimalNameLabel
            // 
            AnimalNameLabel.AutoSize = true;
            AnimalNameLabel.BackColor = Color.Transparent;
            AnimalNameLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            AnimalNameLabel.ForeColor = Color.White;
            AnimalNameLabel.Location = new Point(75, 36);
            AnimalNameLabel.Name = "AnimalNameLabel";
            AnimalNameLabel.Size = new Size(0, 25);
            AnimalNameLabel.TabIndex = 27;
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.Black;
            artanPanel1.BorderRadius = 30;
            artanPanel1.Controls.Add(button1);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(btn_add_animal_HR);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.FromArgb(44, 44, 44);
            artanPanel1.GradientTopColor = Color.FromArgb(44, 44, 44);
            artanPanel1.Location = new Point(5, 56);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(870, 99);
            artanPanel1.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(221, 66, 76);
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(441, 55);
            button1.Name = "button1";
            button1.Size = new Size(185, 32);
            button1.TabIndex = 35;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 38);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 34;
            label2.Text = "Welcome";
            // 
            // artanPanel2
            // 
            artanPanel2.BackColor = Color.Black;
            artanPanel2.BorderRadius = 40;
            artanPanel2.Controls.Add(btn_details_zookeeper);
            artanPanel2.Controls.Add(AnimalNameLabel);
            artanPanel2.ForeColor = Color.Black;
            artanPanel2.GradientAngle = 90F;
            artanPanel2.GradientBottomColor = Color.FromArgb(44, 44, 44);
            artanPanel2.GradientTopColor = Color.FromArgb(64, 64, 64);
            artanPanel2.Location = new Point(897, 104);
            artanPanel2.Name = "artanPanel2";
            artanPanel2.Size = new Size(306, 538);
            artanPanel2.TabIndex = 35;
            // 
            // btn_details_zookeeper
            // 
            btn_details_zookeeper.BackColor = Color.FromArgb(221, 66, 76);
            btn_details_zookeeper.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btn_details_zookeeper.ForeColor = SystemColors.ActiveCaptionText;
            btn_details_zookeeper.Location = new Point(66, 443);
            btn_details_zookeeper.Name = "btn_details_zookeeper";
            btn_details_zookeeper.Size = new Size(185, 32);
            btn_details_zookeeper.TabIndex = 36;
            btn_details_zookeeper.Text = "View Details";
            btn_details_zookeeper.UseVisualStyleBackColor = false;
            btn_details_zookeeper.Click += btn_details_zookeeper_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(963, 76);
            label3.Name = "label3";
            label3.Size = new Size(185, 25);
            label3.TabIndex = 37;
            label3.Text = "Selected Animal info";
            // 
            // Zoo_Keeper
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1211, 651);
            Controls.Add(label3);
            Controls.Add(artanPanel2);
            Controls.Add(artanPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(lv_Animals);
            //Name = "Zoo_Keeper";
            Text = "Zoo_Keeper";
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            artanPanel2.ResumeLayout(false);
            artanPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_add_animal_HR;
        private Label label5;
        private Label label4;
        private Label label1;
        private ListView lv_Animals;
        private ColumnHeader Name;
        private ColumnHeader AnimalType;
        private ColumnHeader AnimalLocation;
        private Label AnimalNameLabel;
        private ArtanPanel artanPanel1;
        private Label label2;
        private ArtanPanel artanPanel2;
        private Button btn_details_zookeeper;
        private ColumnHeader Birthdate;
        private Label label3;
        private ColumnHeader Birthplace;
        private Button button1;
    }
}