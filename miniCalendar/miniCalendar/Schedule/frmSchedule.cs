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
        List<TimeTable> timeTables = new List<TimeTable>();
        TimeTable selectedTimeTable = new TimeTable();
        List<TimeBlock> timeBlocks = new List<TimeBlock>();

        static float pixelPer5Min = 0;
        static int addRow = 0;
        static int timeSpanInMinute = 0;
        static int tempTimeSpan = 0;
        static int head = 0;
        static int tail = 0;
        static PointF timeDrawing;


        int[,] array = new int[8, 3]
        { { 215, 27, 95 }, { 229, 123, 114 }, { 239, 146, 1 }, { 245, 190, 44 },
            { 122, 178, 68}, {179, 157, 218 }, { 12, 155, 227}, { 6, 127, 68} };

        public frmSchedule()
        {
            InitializeComponent();
            InitParameter(selectedTimeTable);
        }

        public frmSchedule(List<TimeTable> timeTables)
        {
            InitializeComponent();
            this.timeTables = timeTables;
            drpTimeTableUpdate();
            if (selectedTimeTable == null)
                drpTimeTable.selectedIndex = 0;
            UpdateBaseTable(selectedTimeTable);
        }

        public void UpdateBaseTable(TimeTable timeTable)
        {
            InitParameter(timeTable);
            drawBaseTable(timeTable);
        }

        public static void InitParameter(TimeTable timeTable)
        {
            ClearParameter();

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

        public static void ClearParameter()
        {
            pixelPer5Min = 0;
            addRow = 0;
            addRow = 0;
            tempTimeSpan = 0;
            timeSpanInMinute = 0;
            head = 0;
            tail = 0;
        }


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
                drawWeekdayTable();
            }
        }

        public void drawWeekdayTable()
        {
            for(int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSunday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlSunday.Enabled = false;
                                pnlSunday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 1:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlMonday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlMonday.Enabled = false;
                                pnlMonday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 2:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlTuesday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlTuesday.Enabled = false;
                                pnlTuesday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 3:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlWednesday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlWednesday.Enabled = false;
                                pnlWednesday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 4:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlThursday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlThursday.Enabled = false;
                                pnlThursday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 5:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlFriday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlFriday.Enabled = false;
                                pnlFriday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                    case 6:
                        {
                            tlpWeekDayDisplayArea.SetRowSpan(pnlSaturday, tlpWeekDayDisplayArea.RowCount - 1);
                            if (!selectedTimeTable.EnableWeekDay[i])
                            {
                                pnlSaturday.Enabled = false;
                                pnlSaturday.BackColor = Color.DarkGray;
                            }
                            break;
                        }
                }
            }
        }

        private void drpTimeTable_onItemSelected(object sender, EventArgs e)
        {
            foreach (var item in timeTables)
                if (drpTimeTable.selectedValue == item.Title)
                {
                    selectedTimeTable = item;
                    break;
                }
            UpdateBaseTable(selectedTimeTable);
        }

        private void ibtnAddTimeTable_Click(object sender, EventArgs e)
        {
            Schedule.frmNewTimeTable form = new Schedule.frmNewTimeTable(timeTables);
            this.Controls.Add(form);
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            this.tlpWeekDayDisplayArea.Visible = false;
        }

        private void ibtnViewTimeTable_Click(object sender, EventArgs e)
        {
            Schedule.frmViewTimeTable form = new Schedule.frmViewTimeTable();
            this.Controls.Add(form);
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            this.tlpWeekDayDisplayArea.Visible = false;
        }

        private void btnAddTimeBlock_Click(object sender, EventArgs e)
        {
            Schedule.frmNewTimeBlock form = new Schedule.frmNewTimeBlock();
            this.Controls.Add(form);
            this.pnlTimeBlockOption.Visible = false;
            this.pnlTimeTableSelection.Visible = false;
            this.tlpWeekDayDisplayArea.Visible = false;
        }

        public class myLable : Label
        {

        }

        public class myButton : Button
        {

        }

        //drpTimeTable
        private void drpTimeTable_onItemAdded(object sender, EventArgs e) => drpTimeTableUpdate();

        private void drpTimeTable_onItemRemoved(object sender, EventArgs e) => drpTimeTableUpdate();

        public void drpTimeTableUpdate()
        {
            drpTimeTable.Clear();
            foreach (var item in timeTables)
                drpTimeTable.AddItem(item.Title);
        }
    }
}
