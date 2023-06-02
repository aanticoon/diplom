namespace WinFormsApp1.Forms
{
    partial class StudentCardForm
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
            studentsTable = new DataGridView();
            SaveButton = new Button();
            CancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentsTable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(44, 62, 80);
            label1.Location = new Point(1085, 7);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Карта студента";
            // 
            // studentsTable
            // 
            studentsTable.BackgroundColor = Color.FromArgb(224, 224, 224);
            studentsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentsTable.GridColor = SystemColors.ActiveCaptionText;
            studentsTable.Location = new Point(12, 7);
            studentsTable.Margin = new Padding(3, 2, 3, 2);
            studentsTable.Name = "studentsTable";
            studentsTable.RowHeadersWidth = 51;
            studentsTable.RowTemplate.Height = 29;
            studentsTable.Size = new Size(1029, 447);
            studentsTable.TabIndex = 1;
            studentsTable.RowLeave += studentsTable_RowLeave;
            studentsTable.UserAddedRow += studentsTable_UserAddedRow;
            studentsTable.UserDeletedRow += studentsTable_UserDeletedRow;
            studentsTable.UserDeletingRow += studentsTable_UserDeletingRow;
            // 
            // SaveButton
            // 
            SaveButton.ForeColor = Color.Black;
            SaveButton.Location = new Point(12, 459);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(229, 23);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Сохранить изменения";
            SaveButton.UseVisualStyleBackColor = true;
            //SaveButton.Click += SaveButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.ForeColor = Color.Black;
            CancelButton.Location = new Point(270, 459);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(218, 23);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Отменить изменения";
            CancelButton.UseVisualStyleBackColor = true;
            /*CancelButton.Click += CancelButton_Click;*/
            // 
            // StudentCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1183, 508);
            Controls.Add(CancelButton);
            Controls.Add(SaveButton);
            Controls.Add(studentsTable);
            Controls.Add(label1);
            ForeColor = Color.LightGoldenrodYellow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentCardForm";
            Text = "StudentCardForm";
            ((System.ComponentModel.ISupportInitialize)studentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView studentsTable;
        private Button SaveButton;
        private Button CancelButton;
    }
}