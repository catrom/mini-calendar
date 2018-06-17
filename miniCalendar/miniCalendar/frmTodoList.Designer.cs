namespace miniCalendar
{
    partial class frmTodoList
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
            this.pnlTaskDetail = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbAddTask = new System.Windows.Forms.TextBox();
            this.fpTaskList = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTaskDetail
            // 
            this.pnlTaskDetail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlTaskDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTaskDetail.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTaskDetail.Location = new System.Drawing.Point(337, 0);
            this.pnlTaskDetail.Name = "pnlTaskDetail";
            this.pnlTaskDetail.Size = new System.Drawing.Size(329, 531);
            this.pnlTaskDetail.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbAddTask);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 74);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::miniCalendar.Properties.Resources.icons8_Plus_Math_32;
            this.pictureBox1.Location = new System.Drawing.Point(3, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tbAddTask
            // 
            this.tbAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddTask.ForeColor = System.Drawing.Color.Silver;
            this.tbAddTask.Location = new System.Drawing.Point(34, 21);
            this.tbAddTask.Name = "tbAddTask";
            this.tbAddTask.Size = new System.Drawing.Size(286, 32);
            this.tbAddTask.TabIndex = 3;
            this.tbAddTask.Enter += new System.EventHandler(this.tbAddTask_Enter);
            this.tbAddTask.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAddTask_KeyDown);
            // 
            // fpTaskList
            // 
            this.fpTaskList.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fpTaskList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpTaskList.Dock = System.Windows.Forms.DockStyle.Top;
            this.fpTaskList.Location = new System.Drawing.Point(0, 74);
            this.fpTaskList.Name = "fpTaskList";
            this.fpTaskList.Size = new System.Drawing.Size(337, 457);
            this.fpTaskList.TabIndex = 2;
            // 
            // frmTodoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.fpTaskList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlTaskDetail);
            this.Name = "frmTodoList";
            this.Size = new System.Drawing.Size(666, 531);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbAddTask;
        public System.Windows.Forms.FlowLayoutPanel fpTaskList;
        public System.Windows.Forms.Panel pnlTaskDetail;
    }
}