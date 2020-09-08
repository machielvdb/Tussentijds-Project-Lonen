namespace Tussentijds_Project_Lonen.Forms
{
    partial class Employees
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
            this.lbEmployees = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblJoindate = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbEmployees
            // 
            this.lbEmployees.FormattingEnabled = true;
            this.lbEmployees.Location = new System.Drawing.Point(12, 12);
            this.lbEmployees.Name = "lbEmployees";
            this.lbEmployees.Size = new System.Drawing.Size(196, 251);
            this.lbEmployees.TabIndex = 0;
            this.lbEmployees.SelectedIndexChanged += new System.EventHandler(this.lbEmployees_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(214, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(144, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New Employee";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(214, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Employee";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(214, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(144, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(211, 107);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(35, 13);
            this.lblSex.TabIndex = 5;
            this.lblSex.Text = "label2";
            // 
            // lblJoindate
            // 
            this.lblJoindate.AutoSize = true;
            this.lblJoindate.Location = new System.Drawing.Point(211, 130);
            this.lblJoindate.Name = "lblJoindate";
            this.lblJoindate.Size = new System.Drawing.Size(35, 13);
            this.lblJoindate.TabIndex = 6;
            this.lblJoindate.Text = "label3";
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(211, 152);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(35, 13);
            this.lbltest.TabIndex = 7;
            this.lbltest.Text = "label3";
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 274);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.lblJoindate);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lbEmployees);
            this.Name = "Employees";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbEmployees;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblJoindate;
        private System.Windows.Forms.Label lbltest;
    }
}