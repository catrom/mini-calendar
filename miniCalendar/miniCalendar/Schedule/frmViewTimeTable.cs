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
    public partial class frmViewTimeTable : UserControl
    {
        ScheduleDataTable dataTable = new ScheduleDataTable();
        TimeTable timeTable = new TimeTable();

        public frmViewTimeTable()
        {
            InitializeComponent();
        }

        public frmViewTimeTable(ScheduleDataTable dataTable, TimeTable timeTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.timeTable = timeTable;

            if (dataTable.timeTables.Count == 1)
            {
                btnDelete.Enabled = false;
                btnDelete.Visible = false;
            }

            DisplayInfo();
        }

        public void DisplayInfo()
        {
            lblTitle.Text = timeTable.Title;

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            chkSunday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 1:
                        {
                            chkMonday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 2:
                        {
                            chkTuesday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 3:
                        {
                            chkWednesday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 4:
                        {
                            chkThursday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 5:
                        {
                            chkFriday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                    case 6:
                        {
                            chkSaturday.Checked = timeTable.EnableWeekDay[i];
                            break;
                        }
                }
            }

            lblStartHourDisplay.Text = timeTable.StartTime.Hour.ToString();
            lblStartMinDisplay.Text = timeTable.StartTime.Minute.ToString();
            lblEndHourDisplay.Text = timeTable.EndTime.Hour.ToString();
            lblEndMinDisplay.Text = timeTable.EndTime.Minute.ToString();
        }
        
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmNewTimeTable form = new frmNewTimeTable(dataTable, timeTable, true);
            form.Disposed += new EventHandler(dispose_event);
            Controls.Add(form);
            form.Visible = true;
            form.BringToFront();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataTable.Remove(timeTable);
            Dispose();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dispose_event(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
