﻿namespace Names
{
    partial class Form1
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
            lstNames = new ListBox();
            txtName = new TextBox();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Names";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.ItemHeight = 21;
            lstNames.Location = new Point(12, 32);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(120, 88);
            lstNames.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 29);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(138, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 33);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Name";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(250, 133);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Names";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNames;
        private TextBox txtName;
        private Button btnAdd;
    }
}