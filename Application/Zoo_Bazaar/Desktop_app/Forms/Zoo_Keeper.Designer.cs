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
            System.Windows.Forms.ColumnHeader AnimalSpecies;
            this.btn_add_animal_HR = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_Animals = new System.Windows.Forms.ListView();
            this.Name = new System.Windows.Forms.ColumnHeader();
            this.Birthdate = new System.Windows.Forms.ColumnHeader();
            this.AnimalType = new System.Windows.Forms.ColumnHeader();
            this.AnimalLocation = new System.Windows.Forms.ColumnHeader();
            this.Birthplace = new System.Windows.Forms.ColumnHeader();
            this.AnimalNameLabel = new System.Windows.Forms.Label();
            this.artanPanel1 = new Desktop_app.ArtanPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.artanPanel2 = new Desktop_app.ArtanPanel();
            this.btn_details_zookeeper = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Lbl_search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            AnimalSpecies = new System.Windows.Forms.ColumnHeader();
            this.artanPanel1.SuspendLayout();
            this.artanPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimalSpecies
            // 
            AnimalSpecies.Text = "Species";
            AnimalSpecies.Width = 150;
            // 
            // btn_add_animal_HR
            // 
            this.btn_add_animal_HR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_add_animal_HR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add_animal_HR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_add_animal_HR.Location = new System.Drawing.Point(821, 69);
            this.btn_add_animal_HR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_animal_HR.Name = "btn_add_animal_HR";
            this.btn_add_animal_HR.Size = new System.Drawing.Size(231, 40);
            this.btn_add_animal_HR.TabIndex = 33;
            this.btn_add_animal_HR.Text = "Add Animal";
            this.btn_add_animal_HR.UseVisualStyleBackColor = false;
            this.btn_add_animal_HR.Click += new System.EventHandler(this.btn_add_animal_HR_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 30);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(276, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 30;
            this.label4.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Zoo Bazaar - ZooKeeper /";
            // 
            // lv_Animals
            // 
            this.lv_Animals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.lv_Animals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Animals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Birthdate,
            this.AnimalType,
            AnimalSpecies,
            this.AnimalLocation,
            this.Birthplace});
            this.lv_Animals.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Animals.ForeColor = System.Drawing.Color.White;
            this.lv_Animals.FullRowSelect = true;
            this.lv_Animals.Location = new System.Drawing.Point(5, 202);
            this.lv_Animals.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lv_Animals.Name = "lv_Animals";
            this.lv_Animals.Size = new System.Drawing.Size(1088, 600);
            this.lv_Animals.TabIndex = 28;
            this.lv_Animals.UseCompatibleStateImageBehavior = false;
            this.lv_Animals.View = System.Windows.Forms.View.Details;
            this.lv_Animals.SelectedIndexChanged += new System.EventHandler(this.lv_Animals_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Name";
            this.Name.Width = 150;
            // 
            // Birthdate
            // 
            this.Birthdate.Text = "Birthdate";
            this.Birthdate.Width = 150;
            // 
            // AnimalType
            // 
            this.AnimalType.Text = "Type";
            this.AnimalType.Width = 150;
            // 
            // AnimalLocation
            // 
            this.AnimalLocation.Text = "Location";
            this.AnimalLocation.Width = 150;
            // 
            // Birthplace
            // 
            this.Birthplace.Text = "Birthplace";
            this.Birthplace.Width = 150;
            // 
            // AnimalNameLabel
            // 
            this.AnimalNameLabel.AutoSize = true;
            this.AnimalNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AnimalNameLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AnimalNameLabel.ForeColor = System.Drawing.Color.White;
            this.AnimalNameLabel.Location = new System.Drawing.Point(165, 48);
            this.AnimalNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AnimalNameLabel.Name = "AnimalNameLabel";
            this.AnimalNameLabel.Size = new System.Drawing.Size(0, 31);
            this.AnimalNameLabel.TabIndex = 27;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.Black;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.Controls.Add(this.btn_add_animal_HR);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel1.Location = new System.Drawing.Point(6, 70);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(1088, 124);
            this.artanPanel1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 34;
            this.label2.Text = "Welcome";
            // 
            // artanPanel2
            // 
            this.artanPanel2.BackColor = System.Drawing.Color.Black;
            this.artanPanel2.BorderRadius = 40;
            this.artanPanel2.Controls.Add(this.btn_details_zookeeper);
            this.artanPanel2.Controls.Add(this.AnimalNameLabel);
            this.artanPanel2.ForeColor = System.Drawing.Color.Black;
            this.artanPanel2.GradientAngle = 90F;
            this.artanPanel2.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel2.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.artanPanel2.Location = new System.Drawing.Point(1121, 130);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(382, 672);
            this.artanPanel2.TabIndex = 35;
            // 
            // btn_details_zookeeper
            // 
            this.btn_details_zookeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_details_zookeeper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_details_zookeeper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_details_zookeeper.Location = new System.Drawing.Point(83, 554);
            this.btn_details_zookeeper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_details_zookeeper.Name = "btn_details_zookeeper";
            this.btn_details_zookeeper.Size = new System.Drawing.Size(231, 40);
            this.btn_details_zookeeper.TabIndex = 36;
            this.btn_details_zookeeper.Text = "View Details";
            this.btn_details_zookeeper.UseVisualStyleBackColor = false;
            this.btn_details_zookeeper.Click += new System.EventHandler(this.btn_details_zookeeper_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1204, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 31);
            this.label3.TabIndex = 37;
            this.label3.Text = "Selected Animal info";
            // 
            // Lbl_search
            // 
            this.Lbl_search.AutoSize = true;
            this.Lbl_search.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_search.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lbl_search.ForeColor = System.Drawing.Color.White;
            this.Lbl_search.Location = new System.Drawing.Point(576, 16);
            this.Lbl_search.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_search.Name = "Lbl_search";
            this.Lbl_search.Size = new System.Drawing.Size(74, 28);
            this.Lbl_search.TabIndex = 39;
            this.Lbl_search.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.textBox1.Location = new System.Drawing.Point(674, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 31);
            this.textBox1.TabIndex = 38;
            // 
            // Zoo_Keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1480, 824);
            this.Controls.Add(this.Lbl_search);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Animals);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text = "Zoo_Keeper";
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label Lbl_search;
        private TextBox textBox1;
        private ColumnHeader Birthplace;
    }
}