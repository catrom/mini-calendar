﻿namespace miniCalendar
{
    partial class frmSchedule
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
            this.tlpWeekDayDisplayArea = new System.Windows.Forms.TableLayoutPanel();
            this.lblSunday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMonday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTuesday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblWednesday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblThursday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFriday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblSaturday = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.drpTimeTable = new Bunifu.Framework.UI.BunifuDropdown();
            this.pnlTimeTableSelection = new System.Windows.Forms.Panel();
            this.pnlTimeBlockOption = new System.Windows.Forms.Panel();
            this.btnAddTimeBlock = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ibtnAddTimeTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.ibtnViewTimeTable = new Bunifu.Framework.UI.BunifuImageButton();
            this.tlpWeekDayDisplayArea.SuspendLayout();
            this.pnlTimeTableSelection.SuspendLayout();
            this.pnlTimeBlockOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnAddTimeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnViewTimeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpWeekDayDisplayArea
            // 
            this.tlpWeekDayDisplayArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpWeekDayDisplayArea.BackColor = System.Drawing.Color.White;
            this.tlpWeekDayDisplayArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tlpWeekDayDisplayArea.ColumnCount = 8;
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblSunday, 1, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblMonday, 2, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblTuesday, 3, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblWednesday, 4, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblThursday, 5, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblFriday, 6, 0);
            this.tlpWeekDayDisplayArea.Controls.Add(this.lblSaturday, 7, 0);
            this.tlpWeekDayDisplayArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpWeekDayDisplayArea.Location = new System.Drawing.Point(0, 50);
            this.tlpWeekDayDisplayArea.Margin = new System.Windows.Forms.Padding(0);
            this.tlpWeekDayDisplayArea.Name = "tlpWeekDayDisplayArea";
            this.tlpWeekDayDisplayArea.RowCount = 2;
            this.tlpWeekDayDisplayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlpWeekDayDisplayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWeekDayDisplayArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpWeekDayDisplayArea.Size = new System.Drawing.Size(891, 556);
            this.tlpWeekDayDisplayArea.TabIndex = 1;
            // 
            // lblSunday
            // 
            this.lblSunday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSunday.AutoSize = true;
            this.lblSunday.BackColor = System.Drawing.Color.Azure;
            this.lblSunday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSunday.Location = new System.Drawing.Point(113, 2);
            this.lblSunday.Margin = new System.Windows.Forms.Padding(0);
            this.lblSunday.Name = "lblSunday";
            this.lblSunday.Size = new System.Drawing.Size(109, 50);
            this.lblSunday.TabIndex = 0;
            this.lblSunday.Text = "Sunday";
            this.lblSunday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonday
            // 
            this.lblMonday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMonday.AutoSize = true;
            this.lblMonday.BackColor = System.Drawing.Color.Azure;
            this.lblMonday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblMonday.Location = new System.Drawing.Point(224, 2);
            this.lblMonday.Margin = new System.Windows.Forms.Padding(0);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(109, 50);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Monday";
            this.lblMonday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTuesday
            // 
            this.lblTuesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.BackColor = System.Drawing.Color.Azure;
            this.lblTuesday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTuesday.Location = new System.Drawing.Point(335, 2);
            this.lblTuesday.Margin = new System.Windows.Forms.Padding(0);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(109, 50);
            this.lblTuesday.TabIndex = 0;
            this.lblTuesday.Text = "Tuesday";
            this.lblTuesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWednesday
            // 
            this.lblWednesday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWednesday.AutoSize = true;
            this.lblWednesday.BackColor = System.Drawing.Color.Azure;
            this.lblWednesday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblWednesday.Location = new System.Drawing.Point(446, 2);
            this.lblWednesday.Margin = new System.Windows.Forms.Padding(0);
            this.lblWednesday.Name = "lblWednesday";
            this.lblWednesday.Size = new System.Drawing.Size(109, 50);
            this.lblWednesday.TabIndex = 0;
            this.lblWednesday.Text = "Wednesday";
            this.lblWednesday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThursday
            // 
            this.lblThursday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblThursday.AutoSize = true;
            this.lblThursday.BackColor = System.Drawing.Color.Azure;
            this.lblThursday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblThursday.Location = new System.Drawing.Point(557, 2);
            this.lblThursday.Margin = new System.Windows.Forms.Padding(0);
            this.lblThursday.Name = "lblThursday";
            this.lblThursday.Size = new System.Drawing.Size(109, 50);
            this.lblThursday.TabIndex = 0;
            this.lblThursday.Text = "Thursday";
            this.lblThursday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFriday
            // 
            this.lblFriday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFriday.AutoSize = true;
            this.lblFriday.BackColor = System.Drawing.Color.Azure;
            this.lblFriday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblFriday.Location = new System.Drawing.Point(668, 2);
            this.lblFriday.Margin = new System.Windows.Forms.Padding(0);
            this.lblFriday.Name = "lblFriday";
            this.lblFriday.Size = new System.Drawing.Size(109, 50);
            this.lblFriday.TabIndex = 0;
            this.lblFriday.Text = "Friday";
            this.lblFriday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSaturday
            // 
            this.lblSaturday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSaturday.AutoSize = true;
            this.lblSaturday.BackColor = System.Drawing.Color.Azure;
            this.lblSaturday.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblSaturday.Location = new System.Drawing.Point(779, 2);
            this.lblSaturday.Margin = new System.Windows.Forms.Padding(0);
            this.lblSaturday.Name = "lblSaturday";
            this.lblSaturday.Size = new System.Drawing.Size(110, 50);
            this.lblSaturday.TabIndex = 0;
            this.lblSaturday.Text = "Saturday";
            this.lblSaturday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drpTimeTable
            // 
            this.drpTimeTable.BackColor = System.Drawing.Color.Transparent;
            this.drpTimeTable.BorderRadius = 3;
            this.drpTimeTable.DisabledColor = System.Drawing.Color.Gray;
            this.drpTimeTable.ForeColor = System.Drawing.Color.White;
            this.drpTimeTable.Items = new string[0];
            this.drpTimeTable.Location = new System.Drawing.Point(4, 4);
            this.drpTimeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpTimeTable.Name = "drpTimeTable";
            this.drpTimeTable.NomalColor = System.Drawing.Color.Silver;
            this.drpTimeTable.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.drpTimeTable.selectedIndex = -1;
            this.drpTimeTable.Size = new System.Drawing.Size(787, 43);
            this.drpTimeTable.TabIndex = 0;
            // 
            // pnlTimeTableSelection
            // 
            this.pnlTimeTableSelection.Controls.Add(this.drpTimeTable);
            this.pnlTimeTableSelection.Controls.Add(this.ibtnAddTimeTable);
            this.pnlTimeTableSelection.Controls.Add(this.ibtnViewTimeTable);
            this.pnlTimeTableSelection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTimeTableSelection.Location = new System.Drawing.Point(0, 0);
            this.pnlTimeTableSelection.Name = "pnlTimeTableSelection";
            this.pnlTimeTableSelection.Size = new System.Drawing.Size(891, 50);
            this.pnlTimeTableSelection.TabIndex = 2;
            // 
            // pnlTimeBlockOption
            // 
            this.pnlTimeBlockOption.Controls.Add(this.btnAddTimeBlock);
            this.pnlTimeBlockOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTimeBlockOption.Location = new System.Drawing.Point(0, 606);
            this.pnlTimeBlockOption.Name = "pnlTimeBlockOption";
            this.pnlTimeBlockOption.Size = new System.Drawing.Size(891, 50);
            this.pnlTimeBlockOption.TabIndex = 3;
            // 
            // btnAddTimeBlock
            // 
            this.btnAddTimeBlock.Activecolor = System.Drawing.Color.Gainsboro;
            this.btnAddTimeBlock.BackColor = System.Drawing.Color.Silver;
            this.btnAddTimeBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTimeBlock.BorderRadius = 5;
            this.btnAddTimeBlock.ButtonText = "New Subject";
            this.btnAddTimeBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTimeBlock.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTimeBlock.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTimeBlock.Iconimage = global::miniCalendar.Properties.Resources.icons8_Positive_32;
            this.btnAddTimeBlock.Iconimage_right = null;
            this.btnAddTimeBlock.Iconimage_right_Selected = null;
            this.btnAddTimeBlock.Iconimage_Selected = null;
            this.btnAddTimeBlock.IconMarginLeft = 10;
            this.btnAddTimeBlock.IconMarginRight = 0;
            this.btnAddTimeBlock.IconRightVisible = true;
            this.btnAddTimeBlock.IconRightZoom = 0D;
            this.btnAddTimeBlock.IconVisible = true;
            this.btnAddTimeBlock.IconZoom = 70D;
            this.btnAddTimeBlock.IsTab = false;
            this.btnAddTimeBlock.Location = new System.Drawing.Point(567, 4);
            this.btnAddTimeBlock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddTimeBlock.Name = "btnAddTimeBlock";
            this.btnAddTimeBlock.Normalcolor = System.Drawing.Color.Silver;
            this.btnAddTimeBlock.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnAddTimeBlock.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(110)))));
            this.btnAddTimeBlock.selected = false;
            this.btnAddTimeBlock.Size = new System.Drawing.Size(321, 43);
            this.btnAddTimeBlock.TabIndex = 0;
            this.btnAddTimeBlock.Text = "New Subject";
            this.btnAddTimeBlock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTimeBlock.Textcolor = System.Drawing.Color.White;
            this.btnAddTimeBlock.TextFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            // 
            // ibtnAddTimeTable
            // 
            this.ibtnAddTimeTable.BackColor = System.Drawing.Color.Silver;
            this.ibtnAddTimeTable.Image = global::miniCalendar.Properties.Resources.icons8_Positive_32;
            this.ibtnAddTimeTable.ImageActive = null;
            this.ibtnAddTimeTable.Location = new System.Drawing.Point(798, 4);
            this.ibtnAddTimeTable.Name = "ibtnAddTimeTable";
            this.ibtnAddTimeTable.Size = new System.Drawing.Size(43, 43);
            this.ibtnAddTimeTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnAddTimeTable.TabIndex = 1;
            this.ibtnAddTimeTable.TabStop = false;
            this.ibtnAddTimeTable.Zoom = 10;
            // 
            // ibtnViewTimeTable
            // 
            this.ibtnViewTimeTable.BackColor = System.Drawing.Color.Silver;
            this.ibtnViewTimeTable.Image = global::miniCalendar.Properties.Resources.edit_3_64;
            this.ibtnViewTimeTable.ImageActive = null;
            this.ibtnViewTimeTable.Location = new System.Drawing.Point(845, 4);
            this.ibtnViewTimeTable.Name = "ibtnViewTimeTable";
            this.ibtnViewTimeTable.Size = new System.Drawing.Size(43, 43);
            this.ibtnViewTimeTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ibtnViewTimeTable.TabIndex = 1;
            this.ibtnViewTimeTable.TabStop = false;
            this.ibtnViewTimeTable.Zoom = 10;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tlpWeekDayDisplayArea);
            this.Controls.Add(this.pnlTimeBlockOption);
            this.Controls.Add(this.pnlTimeTableSelection);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "frmSchedule";
            this.Size = new System.Drawing.Size(891, 656);
            this.tlpWeekDayDisplayArea.ResumeLayout(false);
            this.tlpWeekDayDisplayArea.PerformLayout();
            this.pnlTimeTableSelection.ResumeLayout(false);
            this.pnlTimeBlockOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ibtnAddTimeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibtnViewTimeTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tlpWeekDayDisplayArea;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSunday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMonday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTuesday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWednesday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblThursday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFriday;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSaturday;
        private Bunifu.Framework.UI.BunifuImageButton ibtnAddTimeTable;
        private Bunifu.Framework.UI.BunifuImageButton ibtnViewTimeTable;
        private Bunifu.Framework.UI.BunifuDropdown drpTimeTable;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTimeBlock;
        private System.Windows.Forms.Panel pnlTimeTableSelection;
        private System.Windows.Forms.Panel pnlTimeBlockOption;
    }
}
