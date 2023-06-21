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
            artanPanel1 = new ArtanPanel();
            Btn_Login = new Button();
            label4 = new Label();
            TB_PasswordLogin = new TextBox();
            label3 = new Label();
            TB_UsernameLogin = new TextBox();
            label2 = new Label();
            label1 = new Label();
            artanPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // artanPanel1
            // 
            artanPanel1.BackColor = Color.FromArgb(234, 234, 234);
            artanPanel1.BorderRadius = 100;
            artanPanel1.Controls.Add(Btn_Login);
            artanPanel1.Controls.Add(label4);
            artanPanel1.Controls.Add(TB_PasswordLogin);
            artanPanel1.Controls.Add(label3);
            artanPanel1.Controls.Add(TB_UsernameLogin);
            artanPanel1.Controls.Add(label2);
            artanPanel1.Controls.Add(label1);
            artanPanel1.ForeColor = Color.Black;
            artanPanel1.GradientAngle = 90F;
            artanPanel1.GradientBottomColor = Color.DarkGray;
            artanPanel1.GradientTopColor = Color.FromArgb(234, 234, 234);
            artanPanel1.Location = new Point(236, 97);
            artanPanel1.Margin = new Padding(2);
            artanPanel1.Name = "artanPanel1";
            artanPanel1.Size = new Size(416, 331);
            artanPanel1.TabIndex = 1;
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.Black;
            Btn_Login.ForeColor = Color.White;
            Btn_Login.Location = new Point(117, 211);
            Btn_Login.Margin = new Padding(2);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(188, 22);
            Btn_Login.TabIndex = 6;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(108, 160);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // TB_PasswordLogin
            // 
            TB_PasswordLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TB_PasswordLogin.Location = new Point(108, 178);
            TB_PasswordLogin.Margin = new Padding(2);
            TB_PasswordLogin.Name = "TB_PasswordLogin";
            TB_PasswordLogin.PasswordChar = '*';
            TB_PasswordLogin.Size = new Size(209, 25);
            TB_PasswordLogin.TabIndex = 4;
            TB_PasswordLogin.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(108, 112);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // TB_UsernameLogin
            // 
            TB_UsernameLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            TB_UsernameLogin.Location = new Point(108, 128);
            TB_UsernameLogin.Margin = new Padding(2);
            TB_UsernameLogin.Name = "TB_UsernameLogin";
            TB_UsernameLogin.Size = new Size(209, 25);
            TB_UsernameLogin.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(149, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Login with your details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 48);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 21);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Zoo Bazaar!";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(864, 524);
            Controls.Add(artanPanel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            artanPanel1.ResumeLayout(false);
            artanPanel1.PerformLayout();
            ResumeLayout(false);
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