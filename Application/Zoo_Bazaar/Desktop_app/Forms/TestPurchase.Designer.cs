namespace Desktop_app.Forms
{
	partial class TestPurchase
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			TB_FirstName = new TextBox();
			TB_LastName = new TextBox();
			TB_Email = new TextBox();
			TB_PhoneNumber = new TextBox();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			TB_BabyTicket = new NumericUpDown();
			TB_KidTicket = new NumericUpDown();
			TB_AdultTicket = new NumericUpDown();
			btn_buy = new Button();
			((System.ComponentModel.ISupportInitialize)TB_BabyTicket).BeginInit();
			((System.ComponentModel.ISupportInitialize)TB_KidTicket).BeginInit();
			((System.ComponentModel.ISupportInitialize)TB_AdultTicket).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(88, 27);
			label1.Name = "label1";
			label1.Size = new Size(64, 15);
			label1.TabIndex = 0;
			label1.Text = "First Name";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(96, 126);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 1;
			label2.Text = "Email";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(88, 187);
			label3.Name = "label3";
			label3.Size = new Size(88, 15);
			label3.TabIndex = 2;
			label3.Text = "Phone Number";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(88, 78);
			label4.Name = "label4";
			label4.Size = new Size(63, 15);
			label4.TabIndex = 3;
			label4.Text = "Last Name";
			// 
			// TB_FirstName
			// 
			TB_FirstName.Location = new Point(88, 44);
			TB_FirstName.Margin = new Padding(3, 2, 3, 2);
			TB_FirstName.Name = "TB_FirstName";
			TB_FirstName.Size = new Size(110, 23);
			TB_FirstName.TabIndex = 4;
			// 
			// TB_LastName
			// 
			TB_LastName.Location = new Point(88, 95);
			TB_LastName.Margin = new Padding(3, 2, 3, 2);
			TB_LastName.Name = "TB_LastName";
			TB_LastName.Size = new Size(110, 23);
			TB_LastName.TabIndex = 5;
			// 
			// TB_Email
			// 
			TB_Email.Location = new Point(88, 143);
			TB_Email.Margin = new Padding(3, 2, 3, 2);
			TB_Email.Name = "TB_Email";
			TB_Email.Size = new Size(110, 23);
			TB_Email.TabIndex = 6;
			// 
			// TB_PhoneNumber
			// 
			TB_PhoneNumber.Location = new Point(88, 211);
			TB_PhoneNumber.Margin = new Padding(3, 2, 3, 2);
			TB_PhoneNumber.Name = "TB_PhoneNumber";
			TB_PhoneNumber.Size = new Size(110, 23);
			TB_PhoneNumber.TabIndex = 7;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(307, 110);
			label5.Name = "label5";
			label5.Size = new Size(58, 15);
			label5.TabIndex = 8;
			label5.Text = "Kid Ticket";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(307, 62);
			label6.Name = "label6";
			label6.Size = new Size(67, 15);
			label6.TabIndex = 9;
			label6.Text = "Baby Ticket";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(307, 162);
			label7.Name = "label7";
			label7.Size = new Size(70, 15);
			label7.TabIndex = 10;
			label7.Text = "Adult Ticket";
			// 
			// TB_BabyTicket
			// 
			TB_BabyTicket.Location = new Point(387, 62);
			TB_BabyTicket.Margin = new Padding(3, 2, 3, 2);
			TB_BabyTicket.Name = "TB_BabyTicket";
			TB_BabyTicket.Size = new Size(85, 23);
			TB_BabyTicket.TabIndex = 11;
			// 
			// TB_KidTicket
			// 
			TB_KidTicket.Location = new Point(387, 108);
			TB_KidTicket.Margin = new Padding(3, 2, 3, 2);
			TB_KidTicket.Name = "TB_KidTicket";
			TB_KidTicket.Size = new Size(85, 23);
			TB_KidTicket.TabIndex = 12;
			// 
			// TB_AdultTicket
			// 
			TB_AdultTicket.Location = new Point(389, 162);
			TB_AdultTicket.Margin = new Padding(3, 2, 3, 2);
			TB_AdultTicket.Name = "TB_AdultTicket";
			TB_AdultTicket.Size = new Size(85, 23);
			TB_AdultTicket.TabIndex = 13;
			// 
			// btn_buy
			// 
			btn_buy.Location = new Point(392, 254);
			btn_buy.Margin = new Padding(3, 2, 3, 2);
			btn_buy.Name = "btn_buy";
			btn_buy.Size = new Size(82, 22);
			btn_buy.TabIndex = 14;
			btn_buy.Text = "buy";
			btn_buy.UseVisualStyleBackColor = true;
			//btn_buy.Click += btn_buy_Click;
			// 
			// TestPurchase
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(btn_buy);
			Controls.Add(TB_AdultTicket);
			Controls.Add(TB_KidTicket);
			Controls.Add(TB_BabyTicket);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(TB_PhoneNumber);
			Controls.Add(TB_Email);
			Controls.Add(TB_LastName);
			Controls.Add(TB_FirstName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Margin = new Padding(3, 2, 3, 2);
			Name = "TestPurchase";
			Text = "TestPurchase";
			((System.ComponentModel.ISupportInitialize)TB_BabyTicket).EndInit();
			((System.ComponentModel.ISupportInitialize)TB_KidTicket).EndInit();
			((System.ComponentModel.ISupportInitialize)TB_AdultTicket).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox TB_FirstName;
		private TextBox TB_LastName;
		private TextBox TB_Email;
		private TextBox TB_PhoneNumber;
		private Label label5;
		private Label label6;
		private Label label7;
		private NumericUpDown TB_BabyTicket;
		private NumericUpDown TB_KidTicket;
		private NumericUpDown TB_AdultTicket;
		private Button btn_buy;
	}
}