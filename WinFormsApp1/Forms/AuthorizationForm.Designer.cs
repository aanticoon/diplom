namespace WinFormsApp1
{
	partial class AuthorizationForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			loginInput = new TextBox();
			passwordInput = new TextBox();
			button1 = new Button();
			groupBox1 = new GroupBox();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = Color.White;
			label1.Location = new Point(539, 41);
			label1.Name = "label1";
			label1.Size = new Size(223, 46);
			label1.TabIndex = 0;
			label1.Text = "Авторизация";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.FromArgb(52, 73, 94);
			label2.BorderStyle = BorderStyle.FixedSingle;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.White;
			label2.Location = new Point(88, 55);
			label2.Name = "label2";
			label2.Size = new Size(62, 25);
			label2.TabIndex = 1;
			label2.Text = "Логин";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.FromArgb(52, 73, 94);
			label3.BorderStyle = BorderStyle.FixedSingle;
			label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			label3.ForeColor = Color.White;
			label3.Location = new Point(75, 105);
			label3.Name = "label3";
			label3.Size = new Size(75, 25);
			label3.TabIndex = 2;
			label3.Text = "Пароль";
			// 
			// loginInput
			// 
			loginInput.BorderStyle = BorderStyle.FixedSingle;
			loginInput.Location = new Point(562, 199);
			loginInput.Name = "loginInput";
			loginInput.Size = new Size(252, 27);
			loginInput.TabIndex = 3;
			// 
			// passwordInput
			// 
			passwordInput.BorderStyle = BorderStyle.FixedSingle;
			passwordInput.Location = new Point(562, 249);
			passwordInput.Name = "passwordInput";
			passwordInput.Size = new Size(252, 27);
			passwordInput.TabIndex = 4;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(46, 204, 113);
			button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.White;
			button1.Location = new Point(133, 222);
			button1.Name = "button1";
			button1.Size = new Size(248, 39);
			button1.TabIndex = 5;
			button1.Text = "Войти в систему";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// groupBox1
			// 
			groupBox1.BackColor = SystemColors.Window;
			groupBox1.Controls.Add(button1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(label3);
			groupBox1.FlatStyle = FlatStyle.Flat;
			groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
			groupBox1.ForeColor = Color.Gray;
			groupBox1.Location = new Point(406, 144);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(513, 286);
			groupBox1.TabIndex = 6;
			groupBox1.TabStop = false;
			groupBox1.Text = "Введите ваши данные";
			// 
			// AuthorizationForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(52, 152, 219);
			ClientSize = new Size(1368, 769);
			Controls.Add(passwordInput);
			Controls.Add(loginInput);
			Controls.Add(label1);
			Controls.Add(groupBox1);
			Name = "AuthorizationForm";
			Text = "Form1";
			Load += Form1_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox loginInput;
		private TextBox passwordInput;
		private Button button1;
		private GroupBox groupBox1;
	}
}