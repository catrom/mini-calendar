<<<<<<< HEAD
﻿namespace miniCalendar
{
    partial class frmSubTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubTask));
            this.cbIsDone = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsDone
            // 
            this.cbIsDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.Checked = false;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbIsDone.ForeColor = System.Drawing.Color.White;
            this.cbIsDone.Location = new System.Drawing.Point(7, 2);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(20, 20);
            this.cbIsDone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(275, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbIsDone);
            this.Name = "frmSubTask";
            this.Size = new System.Drawing.Size(300, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox cbIsDone;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
=======
﻿namespace miniCalendar
{
    partial class frmSubTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSubTask));
            this.cbIsDone = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbSubtaskName = new System.Windows.Forms.Label();
            this.pbdelete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).BeginInit();
            this.SuspendLayout();
            // 
            // cbIsDone
            // 
            this.cbIsDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.Checked = false;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbIsDone.ForeColor = System.Drawing.Color.White;
            this.cbIsDone.Location = new System.Drawing.Point(7, 2);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(20, 20);
            this.cbIsDone.TabIndex = 0;
            this.cbIsDone.OnChange += new System.EventHandler(this.cbIsDone_OnChange);
            // 
            // lbSubtaskName
            // 
            this.lbSubtaskName.AutoSize = true;
            this.lbSubtaskName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubtaskName.Location = new System.Drawing.Point(33, 3);
            this.lbSubtaskName.Name = "lbSubtaskName";
            this.lbSubtaskName.Size = new System.Drawing.Size(43, 17);
            this.lbSubtaskName.TabIndex = 1;
            this.lbSubtaskName.Text = "label1";
            // 
            // pbdelete
            // 
            this.pbdelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbdelete.Image = ((System.Drawing.Image)(resources.GetObject("pbdelete.Image")));
            this.pbdelete.Location = new System.Drawing.Point(275, 4);
            this.pbdelete.Name = "pbdelete";
            this.pbdelete.Size = new System.Drawing.Size(20, 20);
            this.pbdelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbdelete.TabIndex = 2;
            this.pbdelete.TabStop = false;
            // 
            // frmSubTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbdelete);
            this.Controls.Add(this.lbSubtaskName);
            this.Controls.Add(this.cbIsDone);
            this.Name = "frmSubTask";
            this.Size = new System.Drawing.Size(300, 24);
            ((System.ComponentModel.ISupportInitialize)(this.pbdelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lbSubtaskName;
        public System.Windows.Forms.PictureBox pbdelete;
        public Bunifu.Framework.UI.BunifuCheckbox cbIsDone;
    }
}
>>>>>>> todoList
