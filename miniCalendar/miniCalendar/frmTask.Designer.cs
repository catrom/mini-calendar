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
            // frmTask
            // 
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.btnTaskName);
            this.Controls.Add(this.cbIsDone);
            this.Name = "frmTask";
            this.Size = new System.Drawing.Size(331, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuFlatButton btnTaskName;
        public Bunifu.Framework.UI.BunifuCheckbox cbIsDone;
    }
}
