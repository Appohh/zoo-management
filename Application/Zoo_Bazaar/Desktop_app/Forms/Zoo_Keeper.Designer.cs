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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.artanPanel2 = new Desktop_app.ArtanPanel();
            this.btn_details_zookeeper = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(4, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.label4.Location = new System.Drawing.Point(193, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Home";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
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
            this.lv_Animals.Location = new System.Drawing.Point(4, 122);
            this.lv_Animals.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lv_Animals.Name = "lv_Animals";
            this.lv_Animals.Size = new System.Drawing.Size(761, 360);
            this.lv_Animals.TabIndex = 28;
            this.lv_Animals.UseCompatibleStateImageBehavior = false;
            this.lv_Animals.View = System.Windows.Forms.View.Details;
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
            this.AnimalNameLabel.Location = new System.Drawing.Point(66, 27);
            this.AnimalNameLabel.Name = "AnimalNameLabel";
            this.AnimalNameLabel.Size = new System.Drawing.Size(0, 20);
            this.AnimalNameLabel.TabIndex = 27;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.Black;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Controls.Add(this.button1);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.artanPanel1.Location = new System.Drawing.Point(4, 42);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(761, 74);
            this.artanPanel1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(596, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 24);
            this.button1.TabIndex = 35;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
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
            this.artanPanel2.Location = new System.Drawing.Point(785, 78);
            this.artanPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.artanPanel2.Name = "artanPanel2";
            this.artanPanel2.Size = new System.Drawing.Size(268, 404);
            this.artanPanel2.TabIndex = 35;
            // 
            // btn_details_zookeeper
            // 
            this.btn_details_zookeeper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(66)))), ((int)(((byte)(76)))));
            this.btn_details_zookeeper.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_details_zookeeper.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_details_zookeeper.Location = new System.Drawing.Point(58, 332);
            this.btn_details_zookeeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_details_zookeeper.Name = "btn_details_zookeeper";
            this.btn_details_zookeeper.Size = new System.Drawing.Size(162, 24);
            this.btn_details_zookeeper.TabIndex = 36;
            this.btn_details_zookeeper.Text = "View Details";
            this.btn_details_zookeeper.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(843, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Selected Animal info";
            // 
            // Zoo_Keeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1060, 488);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artanPanel2);
            this.Controls.Add(this.artanPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_Animals);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Text = "Zoo_Keeper";
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.artanPanel2.ResumeLayout(false);
            this.artanPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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