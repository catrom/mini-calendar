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
    public partial class frmNewTimeTable : UserControl
    {
        ScheduleDataTable dataTable = new ScheduleDataTable();
        public TimeTable timeTable = new TimeTable();
        public TimeTable result;
        public string title = "";
        public DateTime startTime;
        public DateTime endTime;
        public bool[] enableWeekday = new bool[7];
        public bool isModified;
        public List<TimeBlock> tempTimeBlocks = new List<TimeBlock>();

        public frmNewTimeTable()
        {
            InitializeComponent();
        }
        
        public frmNewTimeTable(ScheduleDataTable dataTable, TimeTable timeTable, bool isModified)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.timeTable = timeTable;
            this.isModified = isModified;

            if (!isModified)
            {
                cbStartHour.SelectedIndex = 0;
                cbStartMin.SelectedIndex = 0;
                cbEndHour.SelectedIndex = 0;
                cbEndMin.SelectedIndex = 0;

                chkSunday.Checked = true;
                chkMonday.Checked = true;
                chkTuesday.Checked = true;
                chkWednesday.Checked = true;
                chkThursday.Checked = true;
                chkFriday.Checked = true;
                chkSaturday.Checked = true;
            }
            else
            {
                tbTitle.Text = timeTable.Title;

                cbStartHour.SelectedIndex = timeTable.StartTime.Hour;
                cbStartMin.SelectedIndex = timeTable.StartTime.Minute / 5;

                cbEndHour.SelectedIndex = timeTable.EndTime.Hour;
                cbEndMin.SelectedIndex = timeTable.EndTime.Minute / 5;

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
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbStartHour.SelectedIndex == -1 || cbStartMin.SelectedIndex == -1
                || cbEndHour.SelectedIndex == -1 || cbEndMin.SelectedIndex == -1)
            {
                MessageBox.Show("Select start time and end time");
                return;
            }

                if (tbTitle.Text == "Enter Title" || tbTitle.Text == "")
            {
                title = "";
            }
            else
            {
                title = tbTitle.Text;
            }

            
                

            startTime = new DateTime(1, 1, 1, cbStartHour.SelectedIndex , cbStartMin.SelectedIndex * 5, 0);
            if (cbEndHour.SelectedIndex == 24)
            {
                endTime = new DateTime(1, 1, 1, 23, 55, 0);
            }
            else
            {
                endTime = new DateTime(1, 1, 1, cbEndHour.SelectedIndex, cbEndMin.SelectedIndex * 5, 0);
            }

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        {
                            enableWeekday[i] = chkSunday.Checked;
                            break;
                        }
                    case 1:
                        {
                            enableWeekday[i] = chkMonday.Checked;
                            break;
                        }
                    case 2:
                        {
                            enableWeekday[i] = chkTuesday.Checked;
                            break;
                        }
                    case 3:
                        {
                            enableWeekday[i] = chkWednesday.Checked;
                            break;
                        }
                    case 4:
                        {
                            enableWeekday[i] = chkThursday.Checked;
                            break;
                        }
                    case 5:
                        {
                            enableWeekday[i] = chkFriday.Checked;
                            break;
                        }
                    case 6:
                        {
                            enableWeekday[i] = chkSaturday.Checked;
                            break;
                        }
                }
            }

            try
            {
                result = new TimeTable(title, enableWeekday, startTime, endTime, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (result != null)
            {
                if (isModified)
                {
                    foreach (var item in timeTable.TimeBlocks)
                        if (result.isTimeBlockValid(item))
                            result.Add(item);
                    dataTable.Remove(timeTable);
                    dataTable.Add(result);
                }
                else
                {
                    try
                    {
                        dataTable.Add(result);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Enter Title")
            {
                tbTitle.ForeColor = Color.DarkGray;
            }
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbTitle.Text == "Enter Title")
            {
                tbTitle.Text = "";
            }

            tbTitle.ForeColor = Color.White;
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            string title = tbTitle.Text.Replace(" ", string.Empty);
            if (title == "" || tbTitle.Text == "Enter Title")
            {
                tbTitle.Text = "Enter Title";
                tbTitle.ForeColor = Color.White;
            }
        }

        private void cbEndHour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEndHour.SelectedIndex == 24)
            {
                cbEndMin.SelectedIndex = 0;
                cbEndMin.Enabled = false;
            }
            else
            {
                cbEndMin.Enabled = true;
            }
        }
    }
}
