namespace miniCalendar.Schedule
{
    partial class frmNewTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewTimeTable));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.tbTitle = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlEnableWeekDay = new System.Windows.Forms.Panel();
            this.chkSaturday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkFriday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkThursday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkWednesday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkTuesday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkMonday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkSunday = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblSaturday = new System.Windows.Forms.Label();
            this.lblFriday = new System.Windows.Forms.Label();
            this.lblThursday = new System.Windows.Forms.Label();
            this.lblWednesday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblSunday = new System.Windows.Forms.Label();
            this.lblEnableWeekday = new System.Windows.Forms.Label();
            this.pbEnableWeekday = new System.Windows.Forms.PictureBox();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.cbEndMin = new System.Windows.Forms.ComboBox();
            this.cbEndHour = new System.Windows.Forms.ComboBox();
            this.cbStartMin = new System.Windows.Forms.ComboBox();
            this.cbStartHour = new System.Windows.Forms.ComboBox();
            this.pbTime = new System.Windows.Forms.PictureBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblEndMin = new System.Windows.Forms.Label();
            this.lblStartMin = new System.Windows.Forms.Label();
            this.lblHourEnd = new System.Windows.Forms.Label();
            this.lblStartHour = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlTitle.SuspendLayout();
            this.pnlEnableWeekDay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableWeekday)).BeginInit();
            this.pnlTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).BeginInit();
            this.pnlControl.SuspendLayout();
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
            this.tbTitle.TabIndex = 0;
            this.tbTitle.Text = "Enter Title";
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            this.tbTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTitle_KeyPress);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // pnlEnableWeekDay
            // 
            this.pnlEnableWeekDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEnableWeekDay.Controls.Add(this.chkSaturday);
            this.pnlEnableWeekDay.Controls.Add(this.chkFriday);
            this.pnlEnableWeekDay.Controls.Add(this.chkThursday);
            this.pnlEnableWeekDay.Controls.Add(this.chkWednesday);
            this.pnlEnableWeekDay.Controls.Add(this.chkTuesday);
            this.pnlEnableWeekDay.Controls.Add(this.chkMonday);
            this.pnlEnableWeekDay.Controls.Add(this.chkSunday);
            this.pnlEnableWeekDay.Controls.Add(this.lblSaturday);
            this.pnlEnableWeekDay.Controls.Add(this.lblFriday);
            this.pnlEnableWeekDay.Controls.Add(this.lblThursday);
            this.pnlEnableWeekDay.Controls.Add(this.lblWednesday);
            this.pnlEnableWeekDay.Controls.Add(this.lblTuesday);
            this.pnlEnableWeekDay.Controls.Add(this.lblMonday);
            this.pnlEnableWeekDay.Controls.Add(this.lblSunday);
            this.pnlEnableWeekDay.Controls.Add(this.lblEnableWeekday);
            this.pnlEnableWeekDay.Controls.Add(this.pbEnableWeekday);
            this.pnlEnableWeekDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEnableWeekDay.Location = new System.Drawing.Point(0, 122);
            this.pnlEnableWeekDay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlEnableWeekDay.Name = "pnlEnableWeekDay";
            this.pnlEnableWeekDay.Size = new System.Drawing.Size(334, 345);
            this.pnlEnableWeekDay.TabIndex = 0;
            // 
            // chkSaturday
            // 
            this.chkSaturday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSaturday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSaturday.Checked = true;
            this.chkSaturday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSaturday.ForeColor = System.Drawing.Color.White;
            this.chkSaturday.Location = new System.Drawing.Point(126, 222);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(20, 20);
            this.chkSaturday.TabIndex = 4;
            // 
            // chkFriday
            // 
            this.chkFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkFriday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFriday.Checked = true;
            this.chkFriday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkFriday.ForeColor = System.Drawing.Color.White;
            this.chkFriday.Location = new System.Drawing.Point(126, 193);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(20, 20);
            this.chkFriday.TabIndex = 4;
            // 
            // chkThursday
            // 
            this.chkThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkThursday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkThursday.Checked = true;
            this.chkThursday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkThursday.ForeColor = System.Drawing.Color.White;
            this.chkThursday.Location = new System.Drawing.Point(126, 165);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(20, 20);
            this.chkThursday.TabIndex = 4;
            // 
            // chkWednesday
            // 
            this.chkWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkWednesday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkWednesday.Checked = true;
            this.chkWednesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkWednesday.ForeColor = System.Drawing.Color.White;
            this.chkWednesday.Location = new System.Drawing.Point(126, 136);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(20, 20);
            this.chkWednesday.TabIndex = 4;
            // 
            // chkTuesday
            // 
            this.chkTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkTuesday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkTuesday.Checked = true;
            this.chkTuesday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkTuesday.ForeColor = System.Drawing.Color.White;
            this.chkTuesday.Location = new System.Drawing.Point(126, 108);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(20, 20);
            this.chkTuesday.TabIndex = 4;
            // 
            // chkMonday
            // 
            this.chkMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkMonday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkMonday.Checked = true;
            this.chkMonday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkMonday.ForeColor = System.Drawing.Color.White;
            this.chkMonday.Location = new System.Drawing.Point(126, 80);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(20, 20);
            this.chkMonday.TabIndex = 4;
            // 
            // chkSunday
            // 
            this.chkSunday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSunday.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkSunday.Checked = true;
            this.chkSunday.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.chkSunday.ForeColor = System.Drawing.Color.White;
            this.chkSunday.Location = new System.Drawing.Point(126, 51);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(20, 20);
            this.chkSunday.TabIndex = 4;
            // 
            // lblSaturday
            // 
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSaturday.Location = new System.Drawing.Point(146, 219);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(59, 17);
            this.lblSaturday.TabIndex = 2;
            this.lblSaturday.Text = "Saturday";
            // 
            // lblFriday
            // 
            this.lblFriday.AutoSize = true;
            this.lblFriday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblFriday.Location = new System.Drawing.Point(146, 191);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(43, 17);
            this.lblFriday.TabIndex = 2;
            this.lblFriday.Text = "Friday";
            // 
            // lblThursday
            // 
            this.lblThursday.AutoSize = true;
            this.lblThursday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblThursday.Location = new System.Drawing.Point(146, 162);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(61, 17);
            this.lblThursday.TabIndex = 2;
            this.lblThursday.Text = "Thursday";
            // 
            // lblWednesday
            // 
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblWednesday.Location = new System.Drawing.Point(146, 134);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(75, 17);
            this.lblWednesday.TabIndex = 2;
            this.lblWednesday.Text = "Wednesday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTuesday.Location = new System.Drawing.Point(146, 106);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(56, 17);
            this.lblTuesday.TabIndex = 2;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblMonday
            // 
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblMonday.Location = new System.Drawing.Point(146, 77);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(56, 17);
            this.lblMonday.TabIndex = 2;
            this.lblMonday.Text = "Monday";
            // 
            // lblSunday
            // 
            this.lblSunday.AutoSize = true;
            this.lblSunday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblSunday.Location = new System.Drawing.Point(146, 49);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(50, 17);
            this.lblSunday.TabIndex = 2;
            this.lblSunday.Text = "Sunday";
            // 
            // lblEnableWeekday
            // 
            this.lblEnableWeekday.AutoSize = true;
            this.lblEnableWeekday.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEnableWeekday.Location = new System.Drawing.Point(44, 9);
            this.lblEnableWeekday.Name = "lblEnableWeekday";
            this.lblEnableWeekday.Size = new System.Drawing.Size(103, 17);
            this.lblEnableWeekday.TabIndex = 1;
            this.lblEnableWeekday.Text = "Enable Weekday";
            // 
            // pbEnableWeekday
            // 
            this.pbEnableWeekday.Image = global::miniCalendar.Properties.Resources.icons8_Planner_32;
            this.pbEnableWeekday.Location = new System.Drawing.Point(18, 5);
            this.pbEnableWeekday.Name = "pbEnableWeekday";
            this.pbEnableWeekday.Size = new System.Drawing.Size(20, 23);
            this.pbEnableWeekday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnableWeekday.TabIndex = 0;
            this.pbEnableWeekday.TabStop = false;
            // 
            // pnlTime
            // 
            this.pnlTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTime.Controls.Add(this.cbEndMin);
            this.pnlTime.Controls.Add(this.cbEndHour);
            this.pnlTime.Controls.Add(this.cbStartMin);
            this.pnlTime.Controls.Add(this.cbStartHour);
            this.pnlTime.Controls.Add(this.pbTime);
            this.pnlTime.Controls.Add(this.lblEndTime);
            this.pnlTime.Controls.Add(this.lblEndMin);
            this.pnlTime.Controls.Add(this.lblStartMin);
            this.pnlTime.Controls.Add(this.lblHourEnd);
            this.pnlTime.Controls.Add(this.lblStartHour);
            this.pnlTime.Controls.Add(this.lblStartTime);
            this.pnlTime.Controls.Add(this.lblTime);
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTime.Location = new System.Drawing.Point(334, 122);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(334, 345);
            this.pnlTime.TabIndex = 0;
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
            this.cbEndMin.Location = new System.Drawing.Point(174, 165);
            this.cbEndMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEndMin.Name = "cbEndMin";
            this.cbEndMin.Size = new System.Drawing.Size(54, 21);
            this.cbEndMin.TabIndex = 3;
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
            this.cbEndHour.Location = new System.Drawing.Point(46, 165);
            this.cbEndHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbEndHour.Name = "cbEndHour";
            this.cbEndHour.Size = new System.Drawing.Size(58, 21);
            this.cbEndHour.TabIndex = 2;
            this.cbEndHour.SelectedIndexChanged += new System.EventHandler(this.cbEndHour_SelectedIndexChanged);
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
            this.cbStartMin.Location = new System.Drawing.Point(174, 80);
            this.cbStartMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStartMin.Name = "cbStartMin";
            this.cbStartMin.Size = new System.Drawing.Size(54, 21);
            this.cbStartMin.TabIndex = 3;
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
            this.cbStartHour.Location = new System.Drawing.Point(46, 80);
            this.cbStartHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStartHour.Name = "cbStartHour";
            this.cbStartHour.Size = new System.Drawing.Size(58, 21);
            this.cbStartHour.TabIndex = 2;
            // 
            // pbTime
            // 
            this.pbTime.Image = global::miniCalendar.Properties.Resources.icons8_Clock_32;
            this.pbTime.Location = new System.Drawing.Point(18, 5);
            this.pbTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbTime.Name = "pbTime";
            this.pbTime.Size = new System.Drawing.Size(20, 20);
            this.pbTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTime.TabIndex = 0;
            this.pbTime.TabStop = false;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEndTime.Location = new System.Drawing.Point(44, 134);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(30, 17);
            this.lblEndTime.TabIndex = 1;
            this.lblEndTime.Text = "End";
            // 
            // lblEndMin
            // 
            this.lblEndMin.AutoSize = true;
            this.lblEndMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblEndMin.Location = new System.Drawing.Point(232, 166);
            this.lblEndMin.Name = "lblEndMin";
            this.lblEndMin.Size = new System.Drawing.Size(48, 17);
            this.lblEndMin.TabIndex = 1;
            this.lblEndMin.Text = "Minute";
            // 
            // lblStartMin
            // 
            this.lblStartMin.AutoSize = true;
            this.lblStartMin.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartMin.Location = new System.Drawing.Point(232, 80);
            this.lblStartMin.Name = "lblStartMin";
            this.lblStartMin.Size = new System.Drawing.Size(48, 17);
            this.lblStartMin.TabIndex = 1;
            this.lblStartMin.Text = "Minute";
            // 
            // lblHourEnd
            // 
            this.lblHourEnd.AutoSize = true;
            this.lblHourEnd.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblHourEnd.Location = new System.Drawing.Point(109, 166);
            this.lblHourEnd.Name = "lblHourEnd";
            this.lblHourEnd.Size = new System.Drawing.Size(37, 17);
            this.lblHourEnd.TabIndex = 1;
            this.lblHourEnd.Text = "Hour";
            // 
            // lblStartHour
            // 
            this.lblStartHour.AutoSize = true;
            this.lblStartHour.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartHour.Location = new System.Drawing.Point(109, 80);
            this.lblStartHour.Name = "lblStartHour";
            this.lblStartHour.Size = new System.Drawing.Size(37, 17);
            this.lblStartHour.TabIndex = 1;
            this.lblStartHour.Text = "Hour";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblStartTime.Location = new System.Drawing.Point(44, 51);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(35, 17);
            this.lblStartTime.TabIndex = 1;
            this.lblStartTime.Text = "Start";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTime.Location = new System.Drawing.Point(44, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(36, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Time";
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
            this.btnCancel.Location = new System.Drawing.Point(552, 5);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 47);
            this.btnCancel.TabIndex = 9;
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
            this.btnSave.Location = new System.Drawing.Point(18, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 47);
            this.btnSave.TabIndex = 10;
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmNewTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTime);
            this.Controls.Add(this.pnlEnableWeekDay);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNewTimeTable";
            this.Size = new System.Drawing.Size(668, 533);
            this.pnlTitle.ResumeLayout(false);
            this.pnlEnableWeekDay.ResumeLayout(false);
            this.pnlEnableWeekDay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnableWeekday)).EndInit();
            this.pnlTime.ResumeLayout(false);
            this.pnlTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTime)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlEnableWeekDay;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbTitle;
        private System.Windows.Forms.PictureBox pbEnableWeekday;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.PictureBox pbTime;
        private System.Windows.Forms.Panel pnlControl;
        private Bunifu.Framework.UI.BunifuCheckbox chkSunday;
        private System.Windows.Forms.Label lblSunday;
        private Bunifu.Framework.UI.BunifuCheckbox chkSaturday;
        private Bunifu.Framework.UI.BunifuCheckbox chkFriday;
        private Bunifu.Framework.UI.BunifuCheckbox chkThursday;
        private Bunifu.Framework.UI.BunifuCheckbox chkWednesday;
        private Bunifu.Framework.UI.BunifuCheckbox chkTuesday;
        private Bunifu.Framework.UI.BunifuCheckbox chkMonday;
        private System.Windows.Forms.Label lblSaturday;
        private System.Windows.Forms.Label lblFriday;
        private System.Windows.Forms.Label lblThursday;
        private System.Windows.Forms.Label lblWednesday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.ComboBox cbEndMin;
        private System.Windows.Forms.ComboBox cbEndHour;
        private System.Windows.Forms.ComboBox cbStartMin;
        private System.Windows.Forms.ComboBox cbStartHour;
        private System.Windows.Forms.Label lblEndMin;
        private System.Windows.Forms.Label lblStartMin;
        private System.Windows.Forms.Label lblHourEnd;
        private System.Windows.Forms.Label lblStartHour;
        private System.Windows.Forms.Label lblEnableWeekday;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCancel;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSave;
    }
}
