namespace WinFormsApp1.Forms
{
    partial class StudentDocuments
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
            label2 = new Label();
            studentsTable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentsTable).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(44, 62, 80);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(1101, 9);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Документы";
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
            studentsTable.Size = new Size(1029, 490);
            studentsTable.TabIndex = 4;
            // 
            // StudentDocuments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1183, 508);
            Controls.Add(studentsTable);
            Controls.Add(label2);
            Name = "StudentDocuments";
            Text = "StudentDocuments";
            ((System.ComponentModel.ISupportInitialize)studentsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView studentsTable;
    }
}