﻿namespace miniCalendar
{
    partial class frmTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTaskName = new System.Windows.Forms.Label();
            this.cbIsDone = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SuspendLayout();
            // 
            // lbTaskName
            // 
            this.lbTaskName.AutoSize = true;
            this.lbTaskName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaskName.Location = new System.Drawing.Point(45, 9);
            this.lbTaskName.Name = "lbTaskName";
            this.lbTaskName.Size = new System.Drawing.Size(51, 20);
            this.lbTaskName.TabIndex = 5;
            this.lbTaskName.Text = "label1";
            this.lbTaskName.Visible = false;
            // 
            // cbIsDone
            // 
            this.cbIsDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.Checked = false;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbIsDone.ForeColor = System.Drawing.Color.White;
            this.cbIsDone.Location = new System.Drawing.Point(19, 9);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(20, 20);
            this.cbIsDone.TabIndex = 4;
            // 
            // frmTask
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lbTaskName);
            this.Controls.Add(this.cbIsDone);
            this.Name = "frmTask";
            this.Size = new System.Drawing.Size(331, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCheckbox cbIsDone;
        public System.Windows.Forms.Label lbTaskName;
    }
}