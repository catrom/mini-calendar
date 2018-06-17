namespace miniCalendar
{
    partial class frmViewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAppointment));
            this.panelView = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelDescription = new System.Windows.Forms.Panel();
            this.lbDescription = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelNoti = new System.Windows.Forms.Panel();
            this.lbNoti = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelLocation = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTime = new System.Windows.Forms.Panel();
            this.lbEndHour = new System.Windows.Forms.Label();
            this.lbStartHour = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnModify = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panelModify = new System.Windows.Forms.Panel();
            this.panelView.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelNoti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelView
            // 
            this.panelView.Controls.Add(this.panelInfo);
            this.panelView.Controls.Add(this.panel6);
            this.panelView.Controls.Add(this.panelTitle);
            this.panelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelView.Location = new System.Drawing.Point(0, 0);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(426, 537);
            this.panelView.TabIndex = 16;
            // 
            // panelInfo
            // 
            this.panelInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.panelDescription);
            this.panelInfo.Controls.Add(this.panelNoti);
            this.panelInfo.Controls.Add(this.panelLocation);
            this.panelInfo.Controls.Add(this.panelTime);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo.Location = new System.Drawing.Point(0, 122);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(426, 349);
            this.panelInfo.TabIndex = 25;
            // 
            // panelDescription
            // 
            this.panelDescription.BackColor = System.Drawing.SystemColors.Control;
            this.panelDescription.Controls.Add(this.lbDescription);
            this.panelDescription.Controls.Add(this.pictureBox3);
            this.panelDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDescription.Location = new System.Drawing.Point(0, 150);
            this.panelDescription.Name = "panelDescription";
            this.panelDescription.Size = new System.Drawing.Size(424, 133);
            this.panelDescription.TabIndex = 7;
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbDescription.ForeColor = System.Drawing.Color.Black;
            this.lbDescription.Location = new System.Drawing.Point(62, 18);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(43, 17);
            this.lbDescription.TabIndex = 4;
            this.lbDescription.Text = "label1";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::miniCalendar.Properties.Resources.icons8_Note_32;
            this.pictureBox3.Location = new System.Drawing.Point(18, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panelNoti
            // 
            this.panelNoti.BackColor = System.Drawing.SystemColors.Control;
            this.panelNoti.Controls.Add(this.lbNoti);
            this.panelNoti.Controls.Add(this.pictureBox4);
            this.panelNoti.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNoti.Location = new System.Drawing.Point(0, 100);
            this.panelNoti.Name = "panelNoti";
            this.panelNoti.Size = new System.Drawing.Size(424, 50);
            this.panelNoti.TabIndex = 6;
            // 
            // lbNoti
            // 
            this.lbNoti.AutoSize = true;
            this.lbNoti.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbNoti.ForeColor = System.Drawing.Color.Black;
            this.lbNoti.Location = new System.Drawing.Point(62, 18);
            this.lbNoti.Name = "lbNoti";
            this.lbNoti.Size = new System.Drawing.Size(43, 17);
            this.lbNoti.TabIndex = 4;
            this.lbNoti.Text = "label1";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::miniCalendar.Properties.Resources.icons8_Alarm_Clock_32;
            this.pictureBox4.Location = new System.Drawing.Point(18, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // panelLocation
            // 
            this.panelLocation.BackColor = System.Drawing.SystemColors.Control;
            this.panelLocation.Controls.Add(this.lbLocation);
            this.panelLocation.Controls.Add(this.pictureBox2);
            this.panelLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLocation.Location = new System.Drawing.Point(0, 50);
            this.panelLocation.Name = "panelLocation";
            this.panelLocation.Size = new System.Drawing.Size(424, 50);
            this.panelLocation.TabIndex = 4;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbLocation.ForeColor = System.Drawing.Color.Black;
            this.lbLocation.Location = new System.Drawing.Point(62, 18);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(43, 17);
            this.lbLocation.TabIndex = 4;
            this.lbLocation.Text = "label1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::miniCalendar.Properties.Resources.icons8_Marker_32;
            this.pictureBox2.Location = new System.Drawing.Point(18, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panelTime
            // 
            this.panelTime.BackColor = System.Drawing.SystemColors.Control;
            this.panelTime.Controls.Add(this.lbEndHour);
            this.panelTime.Controls.Add(this.lbStartHour);
            this.panelTime.Controls.Add(this.pictureBox1);
            this.panelTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTime.Location = new System.Drawing.Point(0, 0);
            this.panelTime.Name = "panelTime";
            this.panelTime.Size = new System.Drawing.Size(424, 50);
            this.panelTime.TabIndex = 3;
            // 
            // lbEndHour
            // 
            this.lbEndHour.AutoSize = true;
            this.lbEndHour.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbEndHour.ForeColor = System.Drawing.Color.Black;
            this.lbEndHour.Location = new System.Drawing.Point(62, 25);
            this.lbEndHour.Name = "lbEndHour";
            this.lbEndHour.Size = new System.Drawing.Size(43, 17);
            this.lbEndHour.TabIndex = 4;
            this.lbEndHour.Text = "label1";
            // 
            // lbStartHour
            // 
            this.lbStartHour.AutoSize = true;
            this.lbStartHour.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lbStartHour.ForeColor = System.Drawing.Color.Black;
            this.lbStartHour.Location = new System.Drawing.Point(62, 6);
            this.lbStartHour.Name = "lbStartHour";
            this.lbStartHour.Size = new System.Drawing.Size(43, 17);
            this.lbStartHour.TabIndex = 4;
            this.lbStartHour.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniCalendar.Properties.Resources.icons8_Clock_32;
            this.pictureBox1.Location = new System.Drawing.Point(18, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnModify);
            this.panel6.Controls.Add(this.btnDelete);
            this.panel6.Controls.Add(this.btnBack);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 471);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(426, 66);
            this.panel6.TabIndex = 26;
            // 
            // btnModify
            // 
            this.btnModify.ActiveBorderThickness = 1;
            this.btnModify.ActiveCornerRadius = 20;
            this.btnModify.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModify.ActiveForecolor = System.Drawing.Color.White;
            this.btnModify.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModify.BackColor = System.Drawing.SystemColors.Control;
            this.btnModify.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModify.BackgroundImage")));
            this.btnModify.ButtonText = "MODIFY";
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnModify.IdleBorderThickness = 1;
            this.btnModify.IdleCornerRadius = 20;
            this.btnModify.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnModify.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModify.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnModify.Location = new System.Drawing.Point(18, 10);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(85, 47);
            this.btnModify.TabIndex = 6;
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.Red;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.White;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Red;
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "DELETE";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnDelete.IdleForecolor = System.Drawing.Color.Red;
            this.btnDelete.IdleLineColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(166, 10);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 47);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.ActiveBorderThickness = 1;
            this.btnBack.ActiveCornerRadius = 20;
            this.btnBack.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnBack.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.ButtonText = "BACK";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.IdleBorderThickness = 1;
            this.btnBack.IdleCornerRadius = 20;
            this.btnBack.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnBack.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBack.Location = new System.Drawing.Point(314, 10);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 47);
            this.btnBack.TabIndex = 6;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTitle.Controls.Add(this.lbTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(426, 122);
            this.panelTitle.TabIndex = 24;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(60, 67);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(61, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "label1";
            // 
            // panelModify
            // 
            this.panelModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelModify.Location = new System.Drawing.Point(0, 0);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(426, 537);
            this.panelModify.TabIndex = 17;
            // 
            // frmViewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panelModify);
            this.Name = "frmViewAppointment";
            this.Size = new System.Drawing.Size(426, 537);
            this.panelView.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelDescription.ResumeLayout(false);
            this.panelDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelNoti.ResumeLayout(false);
            this.panelNoti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelLocation.ResumeLayout(false);
            this.panelLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTime.ResumeLayout(false);
            this.panelTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModify;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelDescription;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panelNoti;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelLocation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbNoti;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Label lbEndHour;
        private System.Windows.Forms.Label lbStartHour;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panelModify;
    }
}
