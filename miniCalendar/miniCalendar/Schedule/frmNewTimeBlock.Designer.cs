namespace miniCalendar.Schedule
{
    partial class frmNewTimeBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTimeBlock));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tbTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlDayTime = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.cbEndMin = new System.Windows.Forms.ComboBox();
            this.cbEndHour = new System.Windows.Forms.ComboBox();
            this.cbStartMin = new System.Windows.Forms.ComboBox();
            this.cbStartHour = new System.Windows.Forms.ComboBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblEndMin = new System.Windows.Forms.Label();
            this.lblStartMin = new System.Windows.Forms.Label();
            this.lblHourEnd = new System.Windows.Forms.Label();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.lblEnableWeekday = new System.Windows.Forms.Label();
            this.pbEnableWeekday = new System.Windows.Forms.PictureBox();
            this.cbWeekday = new System.Windows.Forms.ComboBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.lblNotiMin = new System.Windows.Forms.Label();
            this.numNotiValue = new System.Windows.Forms.NumericUpDown();
            this.pbNotification = new System.Windows.Forms.PictureBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.checkBlue = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkGreen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkYellow = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkOrange = new Bunifu.Framework.UI.BunifuCheckbox();
            this.checkRed = new Bunifu.Framework.UI.BunifuCheckbox();
            this.pbColor = new System.Windows.Forms.PictureBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.pbDescription = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.pnlDayTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableWeekday)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.pnlNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotiValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).BeginInit();
            this.pnlColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).BeginInit();
            this.pnlDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTitle.Controls.Add(this.tbTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(668, 122);
            this.pnlTitle.TabIndex = 0;
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.HintForeColor = System.Drawing.Color.Empty;
            this.tbTitle.HintText = "";
            this.tbTitle.isPassword = false;
            this.tbTitle.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbTitle.LineIdleColor = System.Drawing.Color.White;
            this.tbTitle.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbTitle.LineThickness = 2;
            this.tbTitle.Location = new System.Drawing.Point(18, 56);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(630, 33);
            this.tbTitle.TabIndex = 1;
            this.tbTitle.Text = "Enter Title";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitle_KeyPress);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // pnlDayTime
            // 
            this.pnlDayTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDayTime.Controls.Add(this.lblTime);
            this.pnlDayTime.Controls.Add(this.cbEndMin);
            this.pnlDayTime.Controls.Add(this.cbEndHour);
            this.pnlDayTime.Controls.Add(this.cbStartMin);
            this.pnlDayTime.Controls.Add(this.cbStartHour);
            this.pnlDayTime.Controls.Add(this.lblEndTime);
            this.pnlDayTime.Controls.Add(this.lblEndMin);
            this.pnlDayTime.Controls.Add(this.lblStartMin);
            this.pnlDayTime.Controls.Add(this.lblHourEnd);
            this.pnlDayTime.Controls.Add(this.lblStartHour);
            this.pnlDayTime.Controls.Add(this.lblStartTime);
            this.pnlDayTime.Controls.Add(this.pbTime);
            this.pnlDayTime.Controls.Add(this.lblEnableWeekday);
            this.pnlDayTime.Controls.Add(this.pbEnableWeekday);
            this.pnlDayTime.Controls.Add(this.cbWeekday);
            this.pnlDayTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDayTime.Location = new System.Drawing.Point(0, 122);
            this.pnlDayTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDayTime.Name = "pnlDayTime";
            this.pnlDayTime.Size = new System.Drawing.Size(668, 106);
            this.pnlDayTime.TabIndex = 0;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTime.Location = new System.Drawing.Point(356, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "Time";
            // 
            // cbEndMin
            // 
            this.cbEndMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndMin.FormattingEnabled = true;
            this.cbEndMin.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbEndMin.Location = new System.Drawing.Point(530, 71);
            this.cbEndMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEndMin.Name = "cbEndMin";
            this.cbEndMin.Size = new System.Drawing.Size(54, 21);
            this.cbEndMin.TabIndex = 15;
            // 
            // cbEndHour
            // 
            this.cbEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndHour.FormattingEnabled = true;
            this.cbEndHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cbEndHour.Location = new System.Drawing.Point(403, 71);
            this.cbEndHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEndHour.Name = "cbEndHour";
            this.cbEndHour.Size = new System.Drawing.Size(58, 21);
            this.cbEndHour.TabIndex = 13;
            // 
            // cbStartMin
            // 
            this.cbStartMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartMin.FormattingEnabled = true;
            this.cbStartMin.Items.AddRange(new object[] {
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55"});
            this.cbStartMin.Location = new System.Drawing.Point(530, 46);
            this.cbStartMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStartMin.Name = "cbStartMin";
            this.cbStartMin.Size = new System.Drawing.Size(54, 21);
            this.cbStartMin.TabIndex = 16;
            // 
            // cbStartHour
            // 
            this.cbStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartHour.FormattingEnabled = true;
            this.cbStartHour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.cbStartHour.Location = new System.Drawing.Point(403, 46);
            this.cbStartHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStartHour.Name = "cbStartHour";
            this.cbStartHour.Size = new System.Drawing.Size(58, 21);
            this.cbStartHour.TabIndex = 14;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEndTime.Location = new System.Drawing.Point(356, 72);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(30, 17);
            this.lblEndTime.TabIndex = 7;
            this.lblEndTime.Text = "End";
            // 
            // lblEndMin
            // 
            this.lblEndMin.AutoSize = true;
            this.lblEndMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEndMin.Location = new System.Drawing.Point(589, 72);
            this.lblEndMin.Name = "lblEndMin";
            this.lblEndMin.Size = new System.Drawing.Size(48, 17);
            this.lblEndMin.TabIndex = 8;
            this.lblEndMin.Text = "Minute";
            // 
            // lblStartMin
            // 
            this.lblStartMin.AutoSize = true;
            this.lblStartMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartMin.Location = new System.Drawing.Point(589, 47);
            this.lblStartMin.Name = "lblStartMin";
            this.lblStartMin.Size = new System.Drawing.Size(48, 17);
            this.lblStartMin.TabIndex = 9;
            this.lblStartMin.Text = "Minute";
            // 
            // lblHourEnd
            // 
            this.lblHourEnd.AutoSize = true;
            this.lblHourEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHourEnd.Location = new System.Drawing.Point(465, 72);
            this.lblHourEnd.Name = "lblHourEnd";
            this.lblHourEnd.Size = new System.Drawing.Size(37, 17);
            this.lblHourEnd.TabIndex = 10;
            this.lblHourEnd.Text = "Hour";
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartHour.Location = new System.Drawing.Point(465, 47);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(37, 17);
            this.lblStartHour.TabIndex = 11;
            this.lblStartHour.Text = "Hour";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartTime.Location = new System.Drawing.Point(356, 47);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 17);
            this.lblStartTime.TabIndex = 12;
            this.lblStartTime.Text = "Start";
            // 
            // pbTime
            // 
            this.pbTime.Image = global::miniCalendar.Properties.Resources.icons8_Clock_32;
            this.pbTime.Location = new System.Drawing.Point(331, 7);
            this.pbTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(20, 20);
            this.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTime.TabIndex = 6;
            this.pbTime.TabStop = false;
            // 
            // lblEnableWeekday
            // 
            this.lblEnableWeekday.AutoSize = true;
            this.lblEnableWeekday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEnableWeekday.Location = new System.Drawing.Point(44, 9);
            this.lblEnableWeekday.Name = "lblEnableWeekday";
            this.lblEnableWeekday.Size = new System.Drawing.Size(60, 17);
            this.lblEnableWeekday.TabIndex = 5;
            this.lblEnableWeekday.Text = "Weekday";
            // 
            // pbEnableWeekday
            // 
            this.pbEnableWeekday.Image = global::miniCalendar.Properties.Resources.icons8_Planner_32;
            this.pbEnableWeekday.Location = new System.Drawing.Point(18, 5);
            this.pbEnableWeekday.Name = "pbEnableWeekday";
            this.pbEnableWeekday.Size = new System.Drawing.Size(20, 23);
            this.pbEnableWeekday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnableWeekday.TabIndex = 4;
            this.pbEnableWeekday.TabStop = false;
            // 
            // cbWeekday
            // 
            this.cbWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWeekday.FormattingEnabled = true;
            this.cbWeekday.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.cbWeekday.Location = new System.Drawing.Point(47, 48);
            this.cbWeekday.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWeekday.Name = "cbWeekday";
            this.cbWeekday.Size = new System.Drawing.Size(127, 21);
            this.cbWeekday.TabIndex = 2;
            // 
            // pnlControl
            // 
            this.pnlControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControl.Controls.Add(this.btnCancel);
            this.pnlControl.Controls.Add(this.btnSave);
            this.pnlControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControl.Location = new System.Drawing.Point(0, 467);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(668, 66);
            this.pnlControl.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveBorderThickness = 1;
            this.btnCancel.ActiveCornerRadius = 20;
            this.btnCancel.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.ActiveForecolor = System.Drawing.Color.White;
            this.btnCancel.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.ButtonText = "CANCEL";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.IdleBorderThickness = 1;
            this.btnCancel.IdleCornerRadius = 20;
            this.btnCancel.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnCancel.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.Location = new System.Drawing.Point(552, 7);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.ActiveBorderThickness = 1;
            this.btnSave.ActiveCornerRadius = 20;
            this.btnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.ActiveForecolor = System.Drawing.Color.White;
            this.btnSave.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSave.BackgroundImage")));
            this.btnSave.ButtonText = "SAVE";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.IdleBorderThickness = 1;
            this.btnSave.IdleCornerRadius = 20;
            this.btnSave.IdleFillColor = System.Drawing.SystemColors.Control;
            this.btnSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.Location = new System.Drawing.Point(18, 7);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 8;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlNotification
            // 
            this.pnlNotification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNotification.Controls.Add(this.lblNotiMin);
            this.pnlNotification.Controls.Add(this.numNotiValue);
            this.pnlNotification.Controls.Add(this.pbNotification);
            this.pnlNotification.Controls.Add(this.lblNotification);
            this.pnlNotification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNotification.Location = new System.Drawing.Point(0, 228);
            this.pnlNotification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(330, 87);
            this.pnlNotification.TabIndex = 0;
            // 
            // lblNotiMin
            // 
            this.lblNotiMin.AutoSize = true;
            this.lblNotiMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblNotiMin.Location = new System.Drawing.Point(104, 40);
            this.lblNotiMin.Name = "lblNotiMin";
            this.lblNotiMin.Size = new System.Drawing.Size(48, 17);
            this.lblNotiMin.TabIndex = 19;
            this.lblNotiMin.Text = "Minute";
            // 
            // numNotiValue
            // 
            this.numNotiValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numNotiValue.Location = new System.Drawing.Point(47, 37);
            this.numNotiValue.Name = "numNotiValue";
            this.numNotiValue.Size = new System.Drawing.Size(41, 25);
            this.numNotiValue.TabIndex = 8;
            // 
            // pbNotification
            // 
            this.pbNotification.Image = global::miniCalendar.Properties.Resources.icons8_Alarm_Clock_32;
            this.pbNotification.Location = new System.Drawing.Point(18, 8);
            this.pbNotification.Name = "pbNotification";
            this.pbNotification.Size = new System.Drawing.Size(20, 20);
            this.pbNotification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNotification.TabIndex = 7;
            this.pbNotification.TabStop = false;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.Location = new System.Drawing.Point(44, 11);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(75, 17);
            this.lblNotification.TabIndex = 6;
            this.lblNotification.Text = "Notification";
            // 
            // pnlColor
            // 
            this.pnlColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlColor.Controls.Add(this.checkBlue);
            this.pnlColor.Controls.Add(this.checkGreen);
            this.pnlColor.Controls.Add(this.checkYellow);
            this.pnlColor.Controls.Add(this.checkOrange);
            this.pnlColor.Controls.Add(this.checkRed);
            this.pnlColor.Controls.Add(this.pbColor);
            this.pnlColor.Controls.Add(this.lblColor);
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlColor.Location = new System.Drawing.Point(330, 228);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(338, 87);
            this.pnlColor.TabIndex = 0;
            // 
            // checkBlue
            // 
            this.checkBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBlue.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBlue.Checked = false;
            this.checkBlue.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBlue.ForeColor = System.Drawing.Color.White;
            this.checkBlue.Location = new System.Drawing.Point(140, 42);
            this.checkBlue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBlue.Name = "checkBlue";
            this.checkBlue.Size = new System.Drawing.Size(20, 20);
            this.checkBlue.TabIndex = 12;
            this.checkBlue.OnChange += new System.EventHandler(this.checkBlue_OnChange);
            // 
            // checkGreen
            // 
            this.checkGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkGreen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkGreen.Checked = false;
            this.checkGreen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkGreen.ForeColor = System.Drawing.Color.White;
            this.checkGreen.Location = new System.Drawing.Point(116, 42);
            this.checkGreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkGreen.Name = "checkGreen";
            this.checkGreen.Size = new System.Drawing.Size(20, 20);
            this.checkGreen.TabIndex = 11;
            this.checkGreen.OnChange += new System.EventHandler(this.checkGreen_OnChange);
            // 
            // checkYellow
            // 
            this.checkYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkYellow.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkYellow.Checked = false;
            this.checkYellow.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkYellow.ForeColor = System.Drawing.Color.White;
            this.checkYellow.Location = new System.Drawing.Point(90, 42);
            this.checkYellow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkYellow.Name = "checkYellow";
            this.checkYellow.Size = new System.Drawing.Size(20, 20);
            this.checkYellow.TabIndex = 9;
            this.checkYellow.OnChange += new System.EventHandler(this.checkYellow_OnChange);
            // 
            // checkOrange
            // 
            this.checkOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkOrange.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkOrange.Checked = false;
            this.checkOrange.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkOrange.ForeColor = System.Drawing.Color.White;
            this.checkOrange.Location = new System.Drawing.Point(65, 42);
            this.checkOrange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkOrange.Name = "checkOrange";
            this.checkOrange.Size = new System.Drawing.Size(20, 20);
            this.checkOrange.TabIndex = 8;
            this.checkOrange.OnChange += new System.EventHandler(this.checkOrange_OnChange);
            // 
            // checkRed
            // 
            this.checkRed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkRed.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkRed.Checked = false;
            this.checkRed.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkRed.ForeColor = System.Drawing.Color.White;
            this.checkRed.Location = new System.Drawing.Point(40, 42);
            this.checkRed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkRed.Name = "checkRed";
            this.checkRed.Size = new System.Drawing.Size(20, 20);
            this.checkRed.TabIndex = 7;
            this.checkRed.OnChange += new System.EventHandler(this.checkRed_OnChange);
            // 
            // pbColor
            // 
            this.pbColor.Image = global::miniCalendar.Properties.Resources.icons8_Color_Wheel_32;
            this.pbColor.Location = new System.Drawing.Point(14, 8);
            this.pbColor.Name = "pbColor";
            this.pbColor.Size = new System.Drawing.Size(20, 20);
            this.pbColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbColor.TabIndex = 10;
            this.pbColor.TabStop = false;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.Location = new System.Drawing.Point(40, 11);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(40, 17);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // pnlDescription
            // 
            this.pnlDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDescription.Controls.Add(this.tbDescription);
            this.pnlDescription.Controls.Add(this.pbDescription);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDescription.Location = new System.Drawing.Point(0, 315);
            this.pnlDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Size = new System.Drawing.Size(668, 152);
            this.pnlDescription.TabIndex = 0;
            // 
            // tbDescription
            // 
            this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbDescription.ForeColor = System.Drawing.Color.DarkGray;
            this.tbDescription.Location = new System.Drawing.Point(47, 32);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(590, 91);
            this.tbDescription.TabIndex = 7;
            this.tbDescription.Text = "Add descriptions";
            this.tbDescription.Enter += new System.EventHandler(this.tbDescription_Enter);
            this.tbDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDescription_KeyPress);
            this.tbDescription.Leave += new System.EventHandler(this.tbDescription_Leave);
            // 
            // pbDescription
            // 
            this.pbDescription.Image = global::miniCalendar.Properties.Resources.icons8_Note_32;
            this.pbDescription.Location = new System.Drawing.Point(18, 6);
            this.pbDescription.Name = "pbDescription";
            this.pbDescription.Size = new System.Drawing.Size(20, 20);
            this.pbDescription.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDescription.TabIndex = 6;
            this.pbDescription.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(44, 10);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(74, 17);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // frmNewTimeBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.pnlDescription);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlDayTime);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewTimeBlock";
            this.Size = new System.Drawing.Size(668, 533);
            this.pnlTitle.ResumeLayout(false);
            this.pnlDayTime.ResumeLayout(false);
            this.pnlDayTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableWeekday)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNotiValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNotification)).EndInit();
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbColor)).EndInit();
            this.pnlDescription.ResumeLayout(false);
            this.pnlDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlDayTime;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.ComboBox cbWeekday;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTitle;
        private System.Windows.Forms.PictureBox pbEnableWeekday;
        private System.Windows.Forms.Label lblEnableWeekday;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.ComboBox cbEndMin;
        private System.Windows.Forms.ComboBox cbEndHour;
        private System.Windows.Forms.ComboBox cbStartMin;
        private System.Windows.Forms.ComboBox cbStartHour;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblEndMin;
        private System.Windows.Forms.Label lblStartMin;
        private System.Windows.Forms.Label lblHourEnd;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.NumericUpDown numNotiValue;
        private System.Windows.Forms.PictureBox pbNotification;
        private System.Windows.Forms.Label lblNotification;
        private Bunifu.Framework.UI.BunifuCheckbox checkBlue;
        private Bunifu.Framework.UI.BunifuCheckbox checkGreen;
        private Bunifu.Framework.UI.BunifuCheckbox checkYellow;
        private Bunifu.Framework.UI.BunifuCheckbox checkOrange;
        private Bunifu.Framework.UI.BunifuCheckbox checkRed;
        private System.Windows.Forms.PictureBox pbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RichTextBox tbDescription;
        private System.Windows.Forms.PictureBox pbDescription;
        private System.Windows.Forms.Label lblDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
        private System.Windows.Forms.Label lblNotiMin;
    }
}
