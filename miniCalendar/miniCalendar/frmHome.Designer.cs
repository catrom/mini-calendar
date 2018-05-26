﻿namespace miniCalendar
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuSlide = new System.Windows.Forms.Panel();
            this.lbminiCalendar = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnNotifications = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTodoList = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSchedule = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAppointment = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ibtnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibtnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibtnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.frmNotifications1 = new miniCalendar.frmNotifications();
            this.frmAppointment1 = new miniCalendar.frmAppointment();
            this.frmSettings1 = new miniCalendar.frmSettings();
            this.frmTodoList1 = new miniCalendar.frmTodoList();
            this.frmSchedule1 = new miniCalendar.frmSchedule();
            this.panel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.menuSlide.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ibtnMinimize);
            this.panel1.Controls.Add(this.ibtnExit);
            this.panel1.Controls.Add(this.ibtnMenu);
            this.menuTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 26);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.White;
            this.menuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuPanel.Controls.Add(this.menuSlide);
            this.menuPanel.Controls.Add(this.btnNotifications);
            this.menuPanel.Controls.Add(this.bunifuFlatButton1);
            this.menuPanel.Controls.Add(this.btnTodoList);
            this.menuPanel.Controls.Add(this.btnSchedule);
            this.menuPanel.Controls.Add(this.btnAppointment);
            this.menuTransition.SetDecoration(this.menuPanel, BunifuAnimatorNS.DecorationType.None);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 26);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(214, 535);
            this.menuPanel.TabIndex = 3;
            // 
            // menuSlide
            // 
            this.menuSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.menuSlide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuSlide.Controls.Add(this.lbminiCalendar);
            this.menuSlide.Controls.Add(this.logo);
            this.menuTransition.SetDecoration(this.menuSlide, BunifuAnimatorNS.DecorationType.None);
            this.menuSlide.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuSlide.Location = new System.Drawing.Point(0, 0);
            this.menuSlide.Name = "menuSlide";
            this.menuSlide.Size = new System.Drawing.Size(212, 135);
            this.menuSlide.TabIndex = 0;
            // 
            // lbminiCalendar
            // 
            this.lbminiCalendar.AutoSize = true;
            this.menuTransition.SetDecoration(this.lbminiCalendar, BunifuAnimatorNS.DecorationType.None);
            this.lbminiCalendar.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbminiCalendar.ForeColor = System.Drawing.Color.White;
            this.lbminiCalendar.Location = new System.Drawing.Point(39, 82);
            this.lbminiCalendar.Name = "lbminiCalendar";
            this.lbminiCalendar.Size = new System.Drawing.Size(135, 30);
            this.lbminiCalendar.TabIndex = 1;
            this.lbminiCalendar.Text = "miniCalendar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.frmNotifications1);
            this.panel4.Controls.Add(this.frmAppointment1);
            this.panel4.Controls.Add(this.frmSettings1);
            this.panel4.Controls.Add(this.frmTodoList1);
            this.panel4.Controls.Add(this.frmSchedule1);
            this.menuTransition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(214, 26);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(670, 535);
            this.panel4.TabIndex = 4;
            // 
            // menuTransition
            // 
            this.menuTransition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.menuTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.menuTransition.DefaultAnimation = animation1;
            this.menuTransition.MaxAnimationTime = 2000;
            // 
            // logo
            // 
            this.menuTransition.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Image = global::miniCalendar.Properties.Resources.icons8_Today_64;
            this.logo.Location = new System.Drawing.Point(71, 15);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(60, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            // 
            // btnNotifications
            // 
            this.btnNotifications.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnNotifications.BackColor = System.Drawing.Color.Gainsboro;
            this.btnNotifications.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotifications.BorderRadius = 5;
            this.btnNotifications.ButtonText = "     Notifications";
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransition.SetDecoration(this.btnNotifications, BunifuAnimatorNS.DecorationType.None);
            this.btnNotifications.DisabledColor = System.Drawing.Color.Gray;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNotifications.Iconimage = global::miniCalendar.Properties.Resources.icons8_Google_Alerts_32;
            this.btnNotifications.Iconimage_right = null;
            this.btnNotifications.Iconimage_right_Selected = null;
            this.btnNotifications.Iconimage_Selected = null;
            this.btnNotifications.IconMarginLeft = 10;
            this.btnNotifications.IconMarginRight = 0;
            this.btnNotifications.IconRightVisible = true;
            this.btnNotifications.IconRightZoom = 0D;
            this.btnNotifications.IconVisible = true;
            this.btnNotifications.IconZoom = 50D;
            this.btnNotifications.IsTab = true;
            this.btnNotifications.Location = new System.Drawing.Point(0, 160);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Normalcolor = System.Drawing.Color.White;
            this.btnNotifications.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnNotifications.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnNotifications.selected = true;
            this.btnNotifications.Size = new System.Drawing.Size(214, 49);
            this.btnNotifications.TabIndex = 1;
            this.btnNotifications.Text = "     Notifications";
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnNotifications.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotifications.Click += new System.EventHandler(this.btnNotifications_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gainsboro;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 5;
            this.bunifuFlatButton1.ButtonText = "     Settings";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransition.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::miniCalendar.Properties.Resources.icons8_Settings_32;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 10;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(0, 479);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(214, 49);
            this.bunifuFlatButton1.TabIndex = 5;
            this.bunifuFlatButton1.Text = "     Settings";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnTodoList
            // 
            this.btnTodoList.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnTodoList.BackColor = System.Drawing.Color.White;
            this.btnTodoList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTodoList.BorderRadius = 5;
            this.btnTodoList.ButtonText = "     Todo List";
            this.btnTodoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransition.SetDecoration(this.btnTodoList, BunifuAnimatorNS.DecorationType.None);
            this.btnTodoList.DisabledColor = System.Drawing.Color.Gray;
            this.btnTodoList.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoList.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTodoList.Iconimage = global::miniCalendar.Properties.Resources.icons8_Todo_List_32;
            this.btnTodoList.Iconimage_right = null;
            this.btnTodoList.Iconimage_right_Selected = null;
            this.btnTodoList.Iconimage_Selected = null;
            this.btnTodoList.IconMarginLeft = 10;
            this.btnTodoList.IconMarginRight = 0;
            this.btnTodoList.IconRightVisible = true;
            this.btnTodoList.IconRightZoom = 0D;
            this.btnTodoList.IconVisible = true;
            this.btnTodoList.IconZoom = 50D;
            this.btnTodoList.IsTab = true;
            this.btnTodoList.Location = new System.Drawing.Point(0, 325);
            this.btnTodoList.Name = "btnTodoList";
            this.btnTodoList.Normalcolor = System.Drawing.Color.White;
            this.btnTodoList.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnTodoList.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnTodoList.selected = false;
            this.btnTodoList.Size = new System.Drawing.Size(214, 49);
            this.btnTodoList.TabIndex = 4;
            this.btnTodoList.Text = "     Todo List";
            this.btnTodoList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodoList.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnTodoList.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodoList.Click += new System.EventHandler(this.btnTodoList_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnSchedule.BackColor = System.Drawing.Color.White;
            this.btnSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSchedule.BorderRadius = 5;
            this.btnSchedule.ButtonText = "     Schedule";
            this.btnSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransition.SetDecoration(this.btnSchedule, BunifuAnimatorNS.DecorationType.None);
            this.btnSchedule.DisabledColor = System.Drawing.Color.Gray;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSchedule.Iconimage = global::miniCalendar.Properties.Resources.icons8_Schedule_32;
            this.btnSchedule.Iconimage_right = null;
            this.btnSchedule.Iconimage_right_Selected = null;
            this.btnSchedule.Iconimage_Selected = null;
            this.btnSchedule.IconMarginLeft = 10;
            this.btnSchedule.IconMarginRight = 0;
            this.btnSchedule.IconRightVisible = true;
            this.btnSchedule.IconRightZoom = 0D;
            this.btnSchedule.IconVisible = true;
            this.btnSchedule.IconZoom = 50D;
            this.btnSchedule.IsTab = true;
            this.btnSchedule.Location = new System.Drawing.Point(0, 215);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Normalcolor = System.Drawing.Color.White;
            this.btnSchedule.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnSchedule.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnSchedule.selected = false;
            this.btnSchedule.Size = new System.Drawing.Size(214, 49);
            this.btnSchedule.TabIndex = 2;
            this.btnSchedule.Text = "     Schedule";
            this.btnSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSchedule.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnSchedule.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnAppointment
            // 
            this.btnAppointment.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnAppointment.BackColor = System.Drawing.Color.White;
            this.btnAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAppointment.BorderRadius = 5;
            this.btnAppointment.ButtonText = "     Appointment";
            this.btnAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuTransition.SetDecoration(this.btnAppointment, BunifuAnimatorNS.DecorationType.None);
            this.btnAppointment.DisabledColor = System.Drawing.Color.Gray;
            this.btnAppointment.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAppointment.Iconimage = global::miniCalendar.Properties.Resources.icons8_Planner_32;
            this.btnAppointment.Iconimage_right = null;
            this.btnAppointment.Iconimage_right_Selected = null;
            this.btnAppointment.Iconimage_Selected = null;
            this.btnAppointment.IconMarginLeft = 10;
            this.btnAppointment.IconMarginRight = 0;
            this.btnAppointment.IconRightVisible = true;
            this.btnAppointment.IconRightZoom = 0D;
            this.btnAppointment.IconVisible = true;
            this.btnAppointment.IconZoom = 50D;
            this.btnAppointment.IsTab = true;
            this.btnAppointment.Location = new System.Drawing.Point(0, 270);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Normalcolor = System.Drawing.Color.White;
            this.btnAppointment.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAppointment.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnAppointment.selected = false;
            this.btnAppointment.Size = new System.Drawing.Size(214, 49);
            this.btnAppointment.TabIndex = 3;
            this.btnAppointment.Text = "     Appointment";
            this.btnAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppointment.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.btnAppointment.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // ibtnMinimize
            // 
            this.ibtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.menuTransition.SetDecoration(this.ibtnMinimize, BunifuAnimatorNS.DecorationType.None);
            this.ibtnMinimize.Image = global::miniCalendar.Properties.Resources.icons8_Compress_32;
            this.ibtnMinimize.ImageActive = null;
            this.ibtnMinimize.Location = new System.Drawing.Point(825, 0);
            this.ibtnMinimize.Name = "ibtnMinimize";
            this.ibtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.ibtnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnMinimize.TabIndex = 2;
            this.ibtnMinimize.TabStop = false;
            this.ibtnMinimize.Zoom = 15;
            // 
            // ibtnExit
            // 
            this.ibtnExit.BackColor = System.Drawing.Color.Transparent;
            this.menuTransition.SetDecoration(this.ibtnExit, BunifuAnimatorNS.DecorationType.None);
            this.ibtnExit.Image = global::miniCalendar.Properties.Resources.icons8_Delete_32;
            this.ibtnExit.ImageActive = null;
            this.ibtnExit.Location = new System.Drawing.Point(856, 0);
            this.ibtnExit.Name = "ibtnExit";
            this.ibtnExit.Size = new System.Drawing.Size(25, 25);
            this.ibtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnExit.TabIndex = 1;
            this.ibtnExit.TabStop = false;
            this.ibtnExit.Zoom = 15;
            this.ibtnExit.Click += new System.EventHandler(this.ibtnExit_Click);
            // 
            // ibtnMenu
            // 
            this.ibtnMenu.BackColor = System.Drawing.Color.Transparent;
            this.menuTransition.SetDecoration(this.ibtnMenu, BunifuAnimatorNS.DecorationType.None);
            this.ibtnMenu.Image = global::miniCalendar.Properties.Resources.icons8_Menu_32;
            this.ibtnMenu.ImageActive = null;
            this.ibtnMenu.Location = new System.Drawing.Point(9, 0);
            this.ibtnMenu.Name = "ibtnMenu";
            this.ibtnMenu.Size = new System.Drawing.Size(25, 25);
            this.ibtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnMenu.TabIndex = 0;
            this.ibtnMenu.TabStop = false;
            this.ibtnMenu.Zoom = 15;
            this.ibtnMenu.Click += new System.EventHandler(this.ibtnMenu_Click);
            // 
            // frmNotifications1
            // 
            this.frmNotifications1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuTransition.SetDecoration(this.frmNotifications1, BunifuAnimatorNS.DecorationType.None);
            this.frmNotifications1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmNotifications1.Location = new System.Drawing.Point(0, 0);
            this.frmNotifications1.Name = "frmNotifications1";
            this.frmNotifications1.Size = new System.Drawing.Size(670, 535);
            this.frmNotifications1.TabIndex = 1;
            // 
            // frmAppointment1
            // 
            this.frmAppointment1.BackColor = System.Drawing.Color.Gainsboro;
            this.frmAppointment1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.menuTransition.SetDecoration(this.frmAppointment1, BunifuAnimatorNS.DecorationType.None);
            this.frmAppointment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmAppointment1.Location = new System.Drawing.Point(0, 0);
            this.frmAppointment1.Name = "frmAppointment1";
            this.frmAppointment1.Size = new System.Drawing.Size(670, 535);
            this.frmAppointment1.TabIndex = 0;
            // 
            // frmSettings1
            // 
            this.frmSettings1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuTransition.SetDecoration(this.frmSettings1, BunifuAnimatorNS.DecorationType.None);
            this.frmSettings1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSettings1.Location = new System.Drawing.Point(0, 0);
            this.frmSettings1.Name = "frmSettings1";
            this.frmSettings1.Size = new System.Drawing.Size(670, 535);
            this.frmSettings1.TabIndex = 4;
            // 
            // frmTodoList1
            // 
            this.frmTodoList1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuTransition.SetDecoration(this.frmTodoList1, BunifuAnimatorNS.DecorationType.None);
            this.frmTodoList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmTodoList1.Location = new System.Drawing.Point(0, 0);
            this.frmTodoList1.Name = "frmTodoList1";
            this.frmTodoList1.Size = new System.Drawing.Size(670, 535);
            this.frmTodoList1.TabIndex = 3;
            // 
            // frmSchedule1
            // 
            this.frmSchedule1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menuTransition.SetDecoration(this.frmSchedule1, BunifuAnimatorNS.DecorationType.None);
            this.frmSchedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSchedule1.Location = new System.Drawing.Point(0, 0);
            this.frmSchedule1.Name = "frmSchedule1";
            this.frmSchedule1.Size = new System.Drawing.Size(670, 535);
            this.frmSchedule1.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.panel1);
            this.menuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "miniCalendar";
            this.panel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuSlide.ResumeLayout(false);
            this.menuSlide.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnNotifications;
        private Bunifu.Framework.UI.BunifuFlatButton btnTodoList;
        private Bunifu.Framework.UI.BunifuFlatButton btnAppointment;
        private Bunifu.Framework.UI.BunifuFlatButton btnSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel menuSlide;
        private System.Windows.Forms.Label lbminiCalendar;
        private System.Windows.Forms.PictureBox logo;
        private Bunifu.Framework.UI.BunifuImageButton ibtnMenu;
        private Bunifu.Framework.UI.BunifuImageButton ibtnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton ibtnExit;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private BunifuAnimatorNS.BunifuTransition menuTransition;
        private frmAppointment frmAppointment1;
        private frmNotifications frmNotifications1;
        private frmSettings frmSettings1;
        private frmTodoList frmTodoList1;
        private frmSchedule frmSchedule1;
    }
}
