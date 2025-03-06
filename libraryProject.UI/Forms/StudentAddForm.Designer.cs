﻿namespace libraryProject.UI
{
    partial class StudentAddForm
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
            btnStudentDelete = new Button();
            btnStudentSave = new Button();
            txtStudentName = new TextBox();
            txtStudentSurname = new TextBox();
            txtStudentNumber = new TextBox();
            lstStudentList = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(165, 96);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(187, 39);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ ADI";
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(165, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 43);
            label2.TabIndex = 0;
            label2.Text = "ÖĞRENCİ SOYADI";
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(75, 54, 33);
            label3.Location = new Point(165, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(261, 48);
            label3.TabIndex = 0;
            label3.Text = "ÖĞRENCİ NO";
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.BackColor = Color.FromArgb(139, 94, 60);
            btnStudentDelete.FlatStyle = FlatStyle.Flat;
            btnStudentDelete.ForeColor = Color.FromArgb(75, 54, 33);
            btnStudentDelete.Location = new Point(680, 510);
            btnStudentDelete.Margin = new Padding(4);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(515, 60);
            btnStudentDelete.TabIndex = 1;
            btnStudentDelete.Text = "SİL";
            btnStudentDelete.UseVisualStyleBackColor = false;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // btnStudentSave
            // 
            btnStudentSave.BackColor = Color.FromArgb(139, 94, 60);
            btnStudentSave.FlatStyle = FlatStyle.Flat;
            btnStudentSave.ForeColor = Color.FromArgb(75, 54, 33);
            btnStudentSave.Location = new Point(28, 510);
            btnStudentSave.Margin = new Padding(4);
            btnStudentSave.Name = "btnStudentSave";
            btnStudentSave.Size = new Size(515, 60);
            btnStudentSave.TabIndex = 1;
            btnStudentSave.Text = "KAYDET";
            btnStudentSave.UseVisualStyleBackColor = false;
            btnStudentSave.Click += btnStudentSave_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentName.Location = new Point(320, 91);
            txtStudentName.Margin = new Padding(4);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(320, 41);
            txtStudentName.TabIndex = 2;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // txtStudentSurname
            // 
            txtStudentSurname.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentSurname.Location = new Point(320, 140);
            txtStudentSurname.Margin = new Padding(4);
            txtStudentSurname.Multiline = true;
            txtStudentSurname.Name = "txtStudentSurname";
            txtStudentSurname.Size = new Size(320, 41);
            txtStudentSurname.TabIndex = 2;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentNumber.Location = new Point(320, 190);
            txtStudentNumber.Margin = new Padding(4);
            txtStudentNumber.Multiline = true;
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(320, 41);
            txtStudentNumber.TabIndex = 2;
            // 
            // lstStudentList
            // 
            lstStudentList.BackColor = Color.FromArgb(234, 216, 192);
            lstStudentList.FormattingEnabled = true;
            lstStudentList.ItemHeight = 28;
            lstStudentList.Location = new Point(680, 91);
            lstStudentList.Margin = new Padding(4);
            lstStudentList.Name = "lstStudentList";
            lstStudentList.Size = new Size(320, 368);
            lstStudentList.TabIndex = 3;
            lstStudentList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(75, 54, 33);
            label4.Location = new Point(772, 39);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(146, 48);
            label4.TabIndex = 0;
            label4.Text = "ÖĞRENCİ LİSTESİ";
            label4.Click += label4_Click;
            // 
            // StudentAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
            Controls.Add(lstStudentList);
            Controls.Add(txtStudentSurname);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtStudentName);
            Controls.Add(btnStudentSave);
            Controls.Add(btnStudentDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "StudentAddForm";
            Text = "StudentAddForm";
            Load += StudentAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStudentDelete;
        private Button btnStudentSave;
        private TextBox txtStudentName;
        private TextBox txtStudentSurname;
        private TextBox txtStudentNumber;
        private ListBox lstStudentList;
        private Label label4;
    }
}