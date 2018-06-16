namespace miniCalendar
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
            this.cbIsDone = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnTaskName = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDayLeft = new System.Windows.Forms.Label();
            this.pnlDayPast = new System.Windows.Forms.Panel();
            this.pnlNumTask = new System.Windows.Forms.Panel();
            this.lbTaskDone = new System.Windows.Forms.Label();
            this.pnlTaskDone = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.pnlNumTask.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbIsDone
            // 
            this.cbIsDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbIsDone.Checked = false;
            this.cbIsDone.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbIsDone.ForeColor = System.Drawing.Color.White;
            this.cbIsDone.Location = new System.Drawing.Point(7, 9);
            this.cbIsDone.Name = "cbIsDone";
            this.cbIsDone.Size = new System.Drawing.Size(20, 20);
            this.cbIsDone.TabIndex = 6;
            this.cbIsDone.OnChange += new System.EventHandler(this.cbIsDone_OnChange);
            // 
            // btnTaskName
            // 
            this.btnTaskName.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnTaskName.BackColor = System.Drawing.Color.White;
            this.btnTaskName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTaskName.BorderRadius = 5;
            this.btnTaskName.ButtonText = "     Todo List";
            this.btnTaskName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaskName.DisabledColor = System.Drawing.Color.Gray;
            this.btnTaskName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskName.ForeColor = System.Drawing.Color.Black;
            this.btnTaskName.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTaskName.Iconimage = null;
            this.btnTaskName.Iconimage_right = null;
            this.btnTaskName.Iconimage_right_Selected = null;
            this.btnTaskName.Iconimage_Selected = null;
            this.btnTaskName.IconMarginLeft = 10;
            this.btnTaskName.IconMarginRight = 0;
            this.btnTaskName.IconRightVisible = true;
            this.btnTaskName.IconRightZoom = 0D;
            this.btnTaskName.IconVisible = true;
            this.btnTaskName.IconZoom = 50D;
            this.btnTaskName.IsTab = true;
            this.btnTaskName.Location = new System.Drawing.Point(33, -2);
            this.btnTaskName.Name = "btnTaskName";
            this.btnTaskName.Normalcolor = System.Drawing.Color.White;
            this.btnTaskName.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTaskName.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnTaskName.selected = false;
            this.btnTaskName.Size = new System.Drawing.Size(300, 40);
            this.btnTaskName.TabIndex = 5;
            this.btnTaskName.Text = "     Todo List";
            this.btnTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaskName.Textcolor = System.Drawing.Color.Black;
            this.btnTaskName.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbDayLeft);
            this.panel2.Controls.Add(this.pnlDayPast);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(331, 20);
            this.panel2.TabIndex = 7;
            // 
            // lbDayLeft
            // 
            this.lbDayLeft.AutoSize = true;
            this.lbDayLeft.Location = new System.Drawing.Point(130, 2);
            this.lbDayLeft.Name = "lbDayLeft";
            this.lbDayLeft.Size = new System.Drawing.Size(46, 13);
            this.lbDayLeft.TabIndex = 1;
            this.lbDayLeft.Text = "days left";
            // 
            // pnlDayPast
            // 
            this.pnlDayPast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlDayPast.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDayPast.Location = new System.Drawing.Point(0, 0);
            this.pnlDayPast.Name = "pnlDayPast";
            this.pnlDayPast.Size = new System.Drawing.Size(78, 18);
            this.pnlDayPast.TabIndex = 0;
            // 
            // pnlNumTask
            // 
            this.pnlNumTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNumTask.Controls.Add(this.lbTaskDone);
            this.pnlNumTask.Controls.Add(this.pnlTaskDone);
            this.pnlNumTask.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlNumTask.Location = new System.Drawing.Point(0, 36);
            this.pnlNumTask.Name = "pnlNumTask";
            this.pnlNumTask.Size = new System.Drawing.Size(331, 20);
            this.pnlNumTask.TabIndex = 8;
            // 
            // lbTaskDone
            // 
            this.lbTaskDone.AutoSize = true;
            this.lbTaskDone.Location = new System.Drawing.Point(130, 3);
            this.lbTaskDone.Name = "lbTaskDone";
            this.lbTaskDone.Size = new System.Drawing.Size(35, 13);
            this.lbTaskDone.TabIndex = 1;
            this.lbTaskDone.Text = "label1";
            // 
            // pnlTaskDone
            // 
            this.pnlTaskDone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTaskDone.Location = new System.Drawing.Point(0, 0);
            this.pnlTaskDone.Name = "pnlTaskDone";
            this.pnlTaskDone.Size = new System.Drawing.Size(78, 18);
            this.pnlTaskDone.TabIndex = 0;
            // 
            // frmTask
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlNumTask);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTaskName);
            this.Controls.Add(this.cbIsDone);
            this.Name = "frmTask";
            this.Size = new System.Drawing.Size(331, 76);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlNumTask.ResumeLayout(false);
            this.pnlNumTask.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuCheckbox cbIsDone;
        public Bunifu.Framework.UI.BunifuFlatButton btnTaskName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbDayLeft;
        private System.Windows.Forms.Panel pnlDayPast;
        private System.Windows.Forms.Panel pnlNumTask;
        private System.Windows.Forms.Label lbTaskDone;
        private System.Windows.Forms.Panel pnlTaskDone;
    }
}
