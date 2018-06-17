using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniCalendar.Schedule;

namespace miniCalendar
{
    public partial class frmSchedule : UserControl
    {
        ScheduleDataTable dataTable = new ScheduleDataTable();
        TimeTable selectedTimeTable;
        TimeBlock selectedTimeBlock;

        //static properties cho vẽ bảng
        static float pixelPer5Min = 0;
        static int addRow = 0;
        static int timeSpanInMinute = 0;
        static int tempTimeSpan = 0;
        static int head = 0;
        static int tail = 0;
        static PointF timeDrawing;

        public frmSchedule()
        {
            InitializeComponent();
        }

        public frmSchedule(ScheduleDataTable dataTable)
        {
            InitializeComponent();

            this.dataTable = dataTable;
            if (dataTable.timeTables.Count == 0)
            {
                if (selectedTimeTable == null)
                {
                    selectedTimeTable = new TimeTable("Default", new bool[7] { true, true, true, true, true, true, true },
                                        new DateTime(1, 1, 1, 7, 0, 0), new DateTime(1, 1, 1, 16, 0, 0), null);
                }
                dataTable.Add(selectedTimeTable);
            }

            tlpWeekDayDisplayArea.Visible = false;

            drpTimeTableUpdate();

            tlpWeekDayDisplayArea.Visible = true;

        }

        //Khởi tạo giá trị cho các biến static dựa vào TimeTable đang được chọn
        public static void InitParameter(TimeTable timeTable)
        {
            timeSpanInMinute = (int)(timeTable.EndTime.TimeOfDay.TotalMinutes - timeTable.StartTime.TimeOfDay.TotalMinutes);
            pixelPer5Min = 498 / (float)(timeSpanInMinute / 5);
            tempTimeSpan = timeSpanInMinute;

            if (timeSpanInMinute <= 60)
            {
                addRow = (timeSpanInMinute / 5) - 1;
            }
            else
            {
                if (timeTable.StartTime.Minute != 0)
                {
                    head = 60 - timeTable.StartTime.Minute;
                    tempTimeSpan = tempTimeSpan + timeTable.StartTime.Minute;
                }
                else
                {
                    head = 0;
                }

                if (timeTable.EndTime.Minute != 0)
                {
                    tail = timeTable.EndTime.Minute;
                    tempTimeSpan = tempTimeSpan - tail;
                    addRow += 1;
                }
                else
                {
                    tail = 0;
                }
                addRow += (tempTimeSpan / 60) - 1;
            }
        }

        //Đặt về mặc định các giá trị cho các biến static 
        public static void ClearParameter()
        {
            pixelPer5Min = 0;
            addRow = 0;
            tempTimeSpan = 0;
            timeSpanInMinute = 0;
            head = 0;
            tail = 0;
        }

        //Vẽ bảng nền gồm cột số, số dòng thêm vào bảng nền
        public void drawBaseTable(TimeTable timeTable)
        {
            timeDrawing = new Point(25, 40);
            DateTime displayTime = new DateTime(1, 1, 1, timeTable.StartTime.Hour, timeTable.StartTime.Minute, 0);

            tlpWeekDayDisplayArea.RowCount += addRow;

            if (timeSpanInMinute <= 60)
            {
                for (int i = 1; i < tlpWeekDayDisplayArea.RowCount; i++)
                {
                    tlpWeekDayDisplayArea.RowStyles[i].SizeType = SizeType.Absolute;
                    tlpWeekDayDisplayArea.RowStyles[i].Height = pixelPer5Min - 2;
                }
                tlpWeekDayDisplayArea.SetRowSpan(pnlTime, tlpWeekDayDisplayArea.RowCount);
                for (int i = 1; i < tlpWeekDayDisplayArea.RowCount; i++)
                {
                    Label temp = new Label();
                    temp.Location = new Point((int)timeDrawing.X, (int)timeDrawing.Y);
                    temp.Text = displayTime.ToShortTimeString();
                    temp.BackColor = Color.White;
                    temp.AutoSize = true;
                    pnlTime.Controls.Add(temp);
                    timeDrawing.Y += pixelPer5Min + 0.5f;
                    displayTime = displayTime.AddMinutes(5);
                }
            }

            else
            {
                for (int i = 1; i < tlpWeekDayDisplayArea.RowCount; i++)
                {
                    tlpWeekDayDisplayArea.RowStyles[i].SizeType = SizeType.Absolute;
                    tlpWeekDayDisplayArea.RowStyles[i].Height = (pixelPer5Min * 12) - 2;
                    if (head != 0 && i == 1)
                    {
                        tlpWeekDayDisplayArea.RowStyles[i].SizeType = SizeType.Absolute;
                        tlpWeekDayDisplayArea.RowStyles[i].Height = (pixelPer5Min * head / 5) - 2;
                    }
                    if (tail != 0 && i == tlpWeekDayDisplayArea.RowCount - 1)
                    {
                        tlpWeekDayDisplayArea.RowStyles[i].SizeType = SizeType.Absolute;
                        tlpWeekDayDisplayArea.RowStyles[i].Height = (pixelPer5Min * tail / 5) - 2;
                    }
                }

                tlpWeekDayDisplayArea.SetRowSpan(pnlTime, tlpWeekDayDisplayArea.RowCount);
                for (int i = 1; i < tlpWeekDayDisplayArea.RowCount; i++)
                {
                    Label temp = new Label();
                    temp.Location = new Point((int)timeDrawing.X, (int)timeDrawing.Y);
                    temp.Text = displayTime.ToShortTimeString();
                    temp.BackColor = Color.White;
                    temp.AutoSize = true;
                    pnlTime.Controls.Add(temp);
                    if (head != 0 && i == 1)
                    {
                        timeDrawing.Y += (pixelPer5Min * head / 5) + 0.5f;
                        displayTime = displayTime.AddMinutes(head);
                    }
                    else
                    {
                        timeDrawing.Y += (pixelPer5Min * 12) + 0.5f;
                        displayTime = displayTime.AddHours(1);
                    }
                }
            }
        }

        //Dọn dẹp bảng nền
        public void clearBaseTable()
        {
            for (int i = pnlTime.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlTime.Controls[i] is Label)
                {
                    pnlTime.Controls.RemoveAt(i);
                }
            }

            tlpWeekDayDisplayArea.RowCount = 2;
        }

        //Vẽ các cột thứ trong tuần (dùng để tô đen những ngày không có hiệu lực)
        public void drawWeekdayTable(TimeTable timeTable)
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSunday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlSunday.Enabled = false;
                                pnlSunday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 1:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlMonday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlMonday.Enabled = false;
                                pnlMonday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 2:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlTuesday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlTuesday.Enabled = false;
                                pnlTuesday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 3:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlWednesday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlWednesday.Enabled = false;
                                pnlWednesday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 4:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlThursday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlThursday.Enabled = false;
                                pnlThursday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 5:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlFriday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlFriday.Enabled = false;
                                pnlFriday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 6:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSaturday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!timeTable.EnableWeekDay[i])
                            {
                                pnlSaturday.Enabled = false;
                                pnlSaturday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                }
            }
        }

        //Dọn dẹp các cột bị tô đen
        public void clearWeekdayTable()
        {
            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSunday, 1);
                            pnlSunday.Enabled = false;
                            pnlSunday.BackColor = Color.Transparent;
                            break;
                        }
                    case 1:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlMonday, 1);
                            pnlMonday.Enabled = false;
                            pnlMonday.BackColor = Color.Transparent;
                            break;
                        }
                    case 2:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlTuesday, 1);
                            pnlTuesday.Enabled = false;
                            pnlTuesday.BackColor = Color.Transparent;
                            break;
                        }
                    case 3:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlWednesday, 1);
                            pnlWednesday.Enabled = false;
                            pnlWednesday.BackColor = Color.Transparent;
                            break;
                        }
                    case 4:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlThursday, 1);
                            pnlThursday.Enabled = false;
                            pnlThursday.BackColor = Color.Transparent;
                            break;
                        }
                    case 5:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlFriday, 1);
                            pnlFriday.Enabled = false;
                            pnlFriday.BackColor = Color.Transparent;
                            break;
                        }
                    case 6:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSaturday, 1);
                            pnlSaturday.Enabled = false;
                            pnlSaturday.BackColor = Color.Transparent;
                            break;
                        }
                }
            }
        }

        //Vẽ các khung giờ làm việc lên bảng bằng Button (work around)
        public void drawTimeBlock(TimeTable timeTable)
        {
            float timeBlockY;
            float timeBlockX;
            float timeBlockHeight;
            float timeBlockWidth;
            Button timeBlock;

            foreach (var item in timeTable.TimeBlocks)
            {
                timeBlockX = (111 * (item.WeekDay + 1)) + 1;

                timeBlockY = 102 + (((float)(item.StartTime.TimeOfDay.TotalMinutes - timeTable.StartTime.TimeOfDay.TotalMinutes) / 5) * pixelPer5Min);

                timeBlockWidth = 110;

                timeBlockHeight = ((float)(item.EndTime.TimeOfDay.TotalMinutes - item.StartTime.TimeOfDay.TotalMinutes) / 5) * pixelPer5Min;

                timeBlock = new Button();
                timeBlock.Location = new Point((int)timeBlockX,(int)timeBlockY);
                timeBlock.Size = new Size((int)timeBlockWidth, (int)timeBlockHeight);
                timeBlock.BackColor = Helper.ColorPicker(item.Color);
                timeBlock.Text = item.SubjectTitle;
                timeBlock.Margin = new Padding(0);
                timeBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                timeBlock.ForeColor = System.Drawing.Color.White;
                Controls.Add(timeBlock);
                timeBlock.Click += btnTimeBlock_Click;
                timeBlock.Visible = true;
                timeBlock.BringToFront();
            }
        }

        //Dọn dẹp các khung giờ làm việc
        public void clearTimeBlock()
        {
                for (int j = Controls.Count - 1; j >= 0; j--)
                {
                    if (Controls[j] is Button)
                    {
                    Controls.RemoveAt(j);
                    }
                }
        }

        //Hàm cập nhật bảng
        public void updateTable()
        {
            tlpWeekDayDisplayArea.Visible = false;

            clearTimeBlock();
            clearWeekdayTable();
            clearBaseTable();
            ClearParameter();

            InitParameter(selectedTimeTable);
            drawBaseTable(selectedTimeTable);
            drawWeekdayTable(selectedTimeTable);
            drawTimeBlock(selectedTimeTable);

            tlpWeekDayDisplayArea.Visible = true;
        }

        //Hàm cập nhật dropdown chọn TimeTable
        public void drpTimeTableUpdate()
        {
            drpTimeTable.Clear();
            foreach (var item in dataTable.timeTables)
            {
                drpTimeTable.AddItem(item.Title);
            }
            if (this.drpTimeTable.selectedIndex == -1)
                drpTimeTable.selectedIndex = 0;

            drpTimeTable.selectedIndex = dataTable.timeTables.IndexOf(selectedTimeTable);
        }

        //Xử lý sự kiện chọn bảng trong dropdown
        private void drpTimeTable_onItemSelected(object sender, EventArgs e)
        {

            foreach (var item in dataTable.timeTables)
                if (drpTimeTable.selectedValue == item.Title)
                {
                    selectedTimeTable = item;
                    break;
                }

            updateTable();
        }
        
        //Xử lý sự kiện nút thêm bảng
        private void ibtnAddTimeTable_Click(object sender, EventArgs e)
        {
            Schedule.frmNewTimeTable form = new Schedule.frmNewTimeTable(dataTable, selectedTimeTable, false);
            form.Disposed += new EventHandler(dispose_event);
            this.Controls.Add(form);

            this.tlpWeekDayDisplayArea.Visible = false;
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            form.BringToFront();
        }

        //Xử lý sự kiện nút xem thông tin bảng
        private void ibtnViewTimeTable_Click(object sender, EventArgs e)
        {
            Schedule.frmViewTimeTable form = new Schedule.frmViewTimeTable(dataTable, selectedTimeTable);
            form.Disposed += new EventHandler(dispose_event);
            this.Controls.Add(form);

            this.tlpWeekDayDisplayArea.Visible = false;
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            form.BringToFront();
        }

        //Xử lý sự kiện nút thêm khung thời gian
        private void btnAddTimeBlock_Click(object sender, EventArgs e)
        {
            Schedule.frmNewTimeBlock form = new Schedule.frmNewTimeBlock(selectedTimeTable, selectedTimeBlock, false);
            form.Disposed += new EventHandler(dispose_event);
            this.Controls.Add(form);

            this.tlpWeekDayDisplayArea.Visible = false;
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            form.BringToFront();
        }

        //Xử lý sự kiện nút xem thông tin khung thời gian
        public void btnTimeBlock_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            foreach(var item in selectedTimeTable.TimeBlocks)
            {
                if (btn.Text == item.SubjectTitle)
                    selectedTimeBlock = item;
            }

            frmViewTimeBlock form = new frmViewTimeBlock(selectedTimeTable, selectedTimeBlock);
            this.Controls.Add(form);
            form.Disposed += new EventHandler(dispose_event);

            this.tlpWeekDayDisplayArea.Visible = false;
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            form.BringToFront();
        }

        //Xử lý sự kiện thoát các form con
        private void dispose_event(object sender, EventArgs e)
        {
            this.pnlTimeBlockOption.Visible = true;
            this.pnlTimeTableSelection.Visible = true;
            this.tlpWeekDayDisplayArea.Visible = true;
          

            drpTimeTableUpdate();
        }
    }
}
