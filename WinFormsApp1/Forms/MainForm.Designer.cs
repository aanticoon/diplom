namespace WinFormsApp1.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            ContentPanel = new Panel();
            greetingLabel = new Label();
            MenuPanel = new Panel();
            button8 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            button3 = new Button();
            ContentPanel.SuspendLayout();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // ContentPanel
            // 
            ContentPanel.BackColor = Color.FromArgb(189, 195, 199);
            ContentPanel.Controls.Add(greetingLabel);
            ContentPanel.Location = new Point(161, 29);
            ContentPanel.Margin = new Padding(3, 2, 3, 2);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(1000, 535);
            ContentPanel.TabIndex = 0;
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            greetingLabel.ForeColor = Color.White;
            greetingLabel.Location = new Point(385, 275);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(0, 21);
            greetingLabel.TabIndex = 2;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.White;
            MenuPanel.Controls.Add(button8);
            MenuPanel.Controls.Add(button5);
            MenuPanel.Controls.Add(button6);
            MenuPanel.Controls.Add(button7);
            MenuPanel.Controls.Add(button4);
            MenuPanel.Controls.Add(button2);
            MenuPanel.Controls.Add(button1);
            MenuPanel.Location = new Point(10, 58);
            MenuPanel.Margin = new Padding(3, 2, 3, 2);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(145, 506);
            MenuPanel.TabIndex = 1;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(41, 128, 185);
            button8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(1, 165);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(141, 23);
            button8.TabIndex = 6;
            button8.Text = "Олимпиады";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(41, 128, 185);
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(2, 83);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(141, 23);
            button5.TabIndex = 5;
            button5.Text = "Ведомость";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(41, 128, 185);
            button6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(2, 110);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(140, 24);
            button6.TabIndex = 4;
            button6.Text = "Мероприятия";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(41, 128, 185);
            button7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(2, 138);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(141, 23);
            button7.TabIndex = 3;
            button7.Text = "Инструктажи";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(41, 128, 185);
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(2, 56);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 2;
            button4.Text = "Семья студента";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(41, 128, 185);
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 28);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(140, 24);
            button2.TabIndex = 1;
            button2.Text = "Карточка студента";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(41, 128, 185);
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(2, 4);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 0;
            button1.Text = "О группе";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(44, 62, 80);
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(15, 9);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(89, 31);
            button3.TabIndex = 2;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1172, 573);
            Controls.Add(button3);
            Controls.Add(MenuPanel);
            Controls.Add(ContentPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ContentPanel.ResumeLayout(false);
            ContentPanel.PerformLayout();
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel ContentPanel;
        private Panel MenuPanel;
        private Label greetingLabel;
        private Button button1;
        private BindingSource bindingSource1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button8;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}