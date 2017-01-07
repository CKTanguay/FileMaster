﻿namespace FileMaster
{
    partial class MainWindow
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
            this.SelectRepBtn = new System.Windows.Forms.Button();
            this.ClasserBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DropDownLabel = new System.Windows.Forms.Label();
            this.ExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectRepBtn
            // 
            this.SelectRepBtn.Location = new System.Drawing.Point(14, 12);
            this.SelectRepBtn.Name = "SelectRepBtn";
            this.SelectRepBtn.Size = new System.Drawing.Size(200, 85);
            this.SelectRepBtn.TabIndex = 0;
            this.SelectRepBtn.Text = "Sélectionner répertoire";
            this.SelectRepBtn.UseVisualStyleBackColor = true;
            this.SelectRepBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClasserBtn
            // 
            this.ClasserBtn.Location = new System.Drawing.Point(263, 79);
            this.ClasserBtn.Name = "ClasserBtn";
            this.ClasserBtn.Size = new System.Drawing.Size(200, 85);
            this.ClasserBtn.TabIndex = 1;
            this.ClasserBtn.Text = "Classer";
            this.ClasserBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SelectRepBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 204);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DropDownLabel);
            this.panel2.Controls.Add(this.ExtensionComboBox);
            this.panel2.Location = new System.Drawing.Point(14, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(213, 69);
            this.panel2.TabIndex = 5;
            // 
            // DropDownLabel
            // 
            this.DropDownLabel.AutoSize = true;
            this.DropDownLabel.Location = new System.Drawing.Point(3, 12);
            this.DropDownLabel.Name = "DropDownLabel";
            this.DropDownLabel.Size = new System.Drawing.Size(154, 13);
            this.DropDownLabel.TabIndex = 4;
            this.DropDownLabel.Text = "Extension des fichiers à classer";
            // 
            // ExtensionComboBox
            // 
            this.ExtensionComboBox.FormattingEnabled = true;
            this.ExtensionComboBox.Location = new System.Drawing.Point(6, 28);
            this.ExtensionComboBox.Name = "ExtensionComboBox";
            this.ExtensionComboBox.Size = new System.Drawing.Size(194, 21);
            this.ExtensionComboBox.TabIndex = 3;
            this.ExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 229);
            this.Controls.Add(this.ClasserBtn);
            this.Controls.Add(this.panel1);
            this.Name = "MainWindow";
            this.Text = "FileMaster";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectRepBtn;
        private System.Windows.Forms.Button ClasserBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ExtensionComboBox;
        private System.Windows.Forms.Label DropDownLabel;
        private System.Windows.Forms.Panel panel2;
    }
}

