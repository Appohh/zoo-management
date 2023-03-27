namespace Desktop_app.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.artanPanel1 = new Desktop_app.ArtanPanel();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_PasswordLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_UsernameLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.artanPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.artanPanel1.BorderRadius = 100;
            this.artanPanel1.Controls.Add(this.Btn_Login);
            this.artanPanel1.Controls.Add(this.label4);
            this.artanPanel1.Controls.Add(this.TB_PasswordLogin);
            this.artanPanel1.Controls.Add(this.label3);
            this.artanPanel1.Controls.Add(this.TB_UsernameLogin);
            this.artanPanel1.Controls.Add(this.label2);
            this.artanPanel1.Controls.Add(this.label1);
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.DarkGray;
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.artanPanel1.Location = new System.Drawing.Point(270, 129);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(475, 441);
            this.artanPanel1.TabIndex = 1;
            // 
            // Btn_Login
            // 
            this.Btn_Login.BackColor = System.Drawing.Color.Black;
            this.Btn_Login.ForeColor = System.Drawing.Color.White;
            this.Btn_Login.Location = new System.Drawing.Point(134, 281);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(215, 30);
            this.Btn_Login.TabIndex = 6;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = false;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(124, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Password";
            // 
            // TB_PasswordLogin
            // 
            this.TB_PasswordLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_PasswordLogin.Location = new System.Drawing.Point(124, 237);
            this.TB_PasswordLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_PasswordLogin.Name = "TB_PasswordLogin";
            this.TB_PasswordLogin.PasswordChar = '*';
            this.TB_PasswordLogin.Size = new System.Drawing.Size(238, 30);
            this.TB_PasswordLogin.TabIndex = 4;
            this.TB_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(124, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Username";
            // 
            // TB_UsernameLogin
            // 
            this.TB_UsernameLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TB_UsernameLogin.Location = new System.Drawing.Point(124, 171);
            this.TB_UsernameLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB_UsernameLogin.Name = "TB_UsernameLogin";
            this.TB_UsernameLogin.Size = new System.Drawing.Size(238, 30);
            this.TB_UsernameLogin.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(170, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login with your details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Zoo Bazaar!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(987, 698);
            this.Controls.Add(this.artanPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.artanPanel1.ResumeLayout(false);
            this.artanPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ArtanPanel artanPanel1;
        private Label label1;
        private TextBox TB_UsernameLogin;
        private Label label2;
        private Button Btn_Login;
        private Label label4;
        private TextBox TB_PasswordLogin;
        private Label label3;
    }
}