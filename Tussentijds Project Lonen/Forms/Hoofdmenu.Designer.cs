﻿namespace Tussentijds_Project_Lonen
{
    partial class Hoofdmenu
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
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnEndMonth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(12, 12);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(131, 23);
            this.btnEmployees.TabIndex = 0;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnEndMonth
            // 
            this.btnEndMonth.Location = new System.Drawing.Point(12, 41);
            this.btnEndMonth.Name = "btnEndMonth";
            this.btnEndMonth.Size = new System.Drawing.Size(131, 23);
            this.btnEndMonth.TabIndex = 1;
            this.btnEndMonth.Text = "End Month";
            this.btnEndMonth.UseVisualStyleBackColor = true;
            this.btnEndMonth.Click += new System.EventHandler(this.btnEndMonth_Click);
            // 
            // Hoofdmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(151, 73);
            this.Controls.Add(this.btnEndMonth);
            this.Controls.Add(this.btnEmployees);
            this.Name = "Hoofdmenu";
            this.Text = "Hoofdmenu";
            this.Load += new System.EventHandler(this.Hoofdmenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnEndMonth;
    }
}

