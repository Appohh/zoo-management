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
            this.L_GetStartedLogin = new System.Windows.Forms.Label();
            this.B_ClearLogin = new System.Windows.Forms.Button();
            this.B_LoginLogin = new System.Windows.Forms.Button();
            this.CB_ShowPasswordLogin = new System.Windows.Forms.CheckBox();
            this.TB_PasswordLogin = new System.Windows.Forms.TextBox();
            this.L_PasswordLogin = new System.Windows.Forms.Label();
            this.L_UsernameLogin = new System.Windows.Forms.Label();
            this.TB_UsernameLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // L_GetStartedLogin
            // 
            this.L_GetStartedLogin.AutoSize = true;
            this.L_GetStartedLogin.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_GetStartedLogin.ForeColor = System.Drawing.Color.White;
            this.L_GetStartedLogin.Location = new System.Drawing.Point(357, 22);
            this.L_GetStartedLogin.Name = "L_GetStartedLogin";
            this.L_GetStartedLogin.Size = new System.Drawing.Size(164, 37);
            this.L_GetStartedLogin.TabIndex = 34;
            this.L_GetStartedLogin.Text = "Get Started";
            // 
            // B_ClearLogin
            // 
            this.B_ClearLogin.BackColor = System.Drawing.Color.Black;
            this.B_ClearLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.B_ClearLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_ClearLogin.ForeColor = System.Drawing.Color.White;
            this.B_ClearLogin.Location = new System.Drawing.Point(327, 326);
            this.B_ClearLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_ClearLogin.Name = "B_ClearLogin";
            this.B_ClearLogin.Size = new System.Drawing.Size(230, 38);
            this.B_ClearLogin.TabIndex = 33;
            this.B_ClearLogin.Text = "CLEAR";
            this.B_ClearLogin.UseVisualStyleBackColor = false;
            // 
            // B_LoginLogin
            // 
            this.B_LoginLogin.BackColor = System.Drawing.Color.Black;
            this.B_LoginLogin.FlatAppearance.BorderSize = 0;
            this.B_LoginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_LoginLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.B_LoginLogin.ForeColor = System.Drawing.Color.White;
            this.B_LoginLogin.Location = new System.Drawing.Point(327, 275);
            this.B_LoginLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.B_LoginLogin.Name = "B_LoginLogin";
            this.B_LoginLogin.Size = new System.Drawing.Size(230, 38);
            this.B_LoginLogin.TabIndex = 32;
            this.B_LoginLogin.Text = "LOG IN";
            this.B_LoginLogin.UseVisualStyleBackColor = false;
            this.B_LoginLogin.Click += new System.EventHandler(this.B_LoginLogin_Click);
            // 
            // CB_ShowPasswordLogin
            // 
            this.CB_ShowPasswordLogin.AutoSize = true;
            this.CB_ShowPasswordLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CB_ShowPasswordLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_ShowPasswordLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CB_ShowPasswordLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.CB_ShowPasswordLogin.Location = new System.Drawing.Point(425, 229);
            this.CB_ShowPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CB_ShowPasswordLogin.Name = "CB_ShowPasswordLogin";
            this.CB_ShowPasswordLogin.Size = new System.Drawing.Size(130, 24);
            this.CB_ShowPasswordLogin.TabIndex = 31;
            this.CB_ShowPasswordLogin.Text = "Show Password";
            this.CB_ShowPasswordLogin.UseVisualStyleBackColor = true;
            // 
            // TB_PasswordLogin
            // 
            this.TB_PasswordLogin.BackColor = System.Drawing.Color.Black;
            this.TB_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_PasswordLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_PasswordLogin.Location = new System.Drawing.Point(327, 199);
            this.TB_PasswordLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_PasswordLogin.Name = "TB_PasswordLogin";
            this.TB_PasswordLogin.PasswordChar = '*';
            this.TB_PasswordLogin.Size = new System.Drawing.Size(230, 16);
            this.TB_PasswordLogin.TabIndex = 30;
            // 
            // L_PasswordLogin
            // 
            this.L_PasswordLogin.AutoSize = true;
            this.L_PasswordLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_PasswordLogin.ForeColor = System.Drawing.Color.White;
            this.L_PasswordLogin.Location = new System.Drawing.Point(327, 179);
            this.L_PasswordLogin.Name = "L_PasswordLogin";
            this.L_PasswordLogin.Size = new System.Drawing.Size(77, 20);
            this.L_PasswordLogin.TabIndex = 29;
            this.L_PasswordLogin.Text = "Password:";
            // 
            // L_UsernameLogin
            // 
            this.L_UsernameLogin.AutoSize = true;
            this.L_UsernameLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L_UsernameLogin.ForeColor = System.Drawing.Color.White;
            this.L_UsernameLogin.Location = new System.Drawing.Point(327, 104);
            this.L_UsernameLogin.Name = "L_UsernameLogin";
            this.L_UsernameLogin.Size = new System.Drawing.Size(82, 20);
            this.L_UsernameLogin.TabIndex = 27;
            this.L_UsernameLogin.Text = "Username:";
            // 
            // TB_UsernameLogin
            // 
            this.TB_UsernameLogin.BackColor = System.Drawing.Color.Black;
            this.TB_UsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_UsernameLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TB_UsernameLogin.Location = new System.Drawing.Point(327, 124);
            this.TB_UsernameLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TB_UsernameLogin.Name = "TB_UsernameLogin";
            this.TB_UsernameLogin.Size = new System.Drawing.Size(230, 16);
            this.TB_UsernameLogin.TabIndex = 28;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(74)))), ((int)(((byte)(29)))));
            this.ClientSize = new System.Drawing.Size(864, 524);
            this.Controls.Add(this.L_GetStartedLogin);
            this.Controls.Add(this.B_ClearLogin);
            this.Controls.Add(this.B_LoginLogin);
            this.Controls.Add(this.CB_ShowPasswordLogin);
            this.Controls.Add(this.TB_PasswordLogin);
            this.Controls.Add(this.L_PasswordLogin);
            this.Controls.Add(this.TB_UsernameLogin);
            this.Controls.Add(this.L_UsernameLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label L_GetStartedLogin;
        private Button B_ClearLogin;
        private Button B_LoginLogin;
        private CheckBox CB_ShowPasswordLogin;
        private TextBox TB_PasswordLogin;
        private Label L_PasswordLogin;
        private Label L_UsernameLogin;
        private TextBox TB_UsernameLogin;
    }
}