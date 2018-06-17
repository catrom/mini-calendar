using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar.Schedule
{
    public partial class frmViewTimeBlock : UserControl
    {
        TimeTable timeTable = new TimeTable();
        TimeBlock timeBlock = new TimeBlock();

        public frmViewTimeBlock()
        {
            InitializeComponent();
        }

        public frmViewTimeBlock(TimeTable timeTable, TimeBlock timeBlock)
        {
            InitializeComponent();
            this.timeTable = timeTable;
            this.timeBlock = timeBlock;

            DisplayInfo();
        }

        public void DisplayInfo()
        {
            lbTitle.Text = timeBlock.SubjectTitle;

            switch (timeBlock.WeekDay)
            {
                case 0:
                    {
                        lblWeekdayDisplay.Text = "Sunday";
                        break;
                    }
                case 1:
                    {
                        lblWeekdayDisplay.Text = "Monday";
                        break;
                    }
                case 2:
                    {
                        lblWeekdayDisplay.Text = "Tuesday";
                        break;
                    }
                case 3:
                    {
                        lblWeekdayDisplay.Text = "Wednesday";
                        break;
                    }
                case 4:
                    {
                        lblWeekdayDisplay.Text = "Thursday";
                        break;
                    }
                case 5:
                    {
                        lblWeekdayDisplay.Text = "Friday";
                        break;
                    }
                case 6:
                    {
                        lblWeekdayDisplay.Text = "Saturday";
                        break;
                    }
            }

            lblStartHourDisplay.Text = timeBlock.StartTime.Hour.ToString();
            lblStartMinDisplay.Text = timeBlock.StartTime.Minute.ToString();
            lblEndHourDisplay.Text = timeBlock.EndTime.Hour.ToString();
            lblEndMinDisplay.Text = timeBlock.EndTime.Minute.ToString();

            lblNotiMinDisplay.Text = timeBlock.NotiValue.ToString();

            lblDescriptionDisplay.Text = timeBlock.Description;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            frmNewTimeBlock form = new frmNewTimeBlock(timeTable, timeBlock, true);
            form.Disposed += new EventHandler(dispose_event);
            Controls.Add(form);
            form.Visible = true;
            form.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            timeTable.Remove(timeBlock);
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dispose_event(object sender, EventArgs e)
        {
            Dispose();
            BringToFront();
        }
    }
}
