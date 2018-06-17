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
    public partial class frmNewTimeBlock : UserControl
    {
        ScheduleDataTable dataTable = new ScheduleDataTable();
        public TimeTable timeTable = new TimeTable();
        public TimeBlock timeBlock = new TimeBlock();
        public TimeBlock result = new TimeBlock();

        public string title;
        public int weekday;
        public DateTime startTime;
        public DateTime endTime;
        public string color = "Blue";
        public int notiValue;
        public string description;

        public bool isModified;

        public frmNewTimeBlock()
        {
            InitializeComponent();
        }

        public frmNewTimeBlock(ScheduleDataTable dataTable, TimeTable timeTable, TimeBlock timeBlock, bool isModified)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.timeTable = timeTable;
            this.isModified = isModified;

            if (!isModified)
            {
                cbWeekday.SelectedIndex = 0;

                cbStartHour.SelectedIndex = 0;
                cbStartMin.SelectedIndex = 0;
                cbEndHour.SelectedIndex = 0;
                cbEndMin.SelectedIndex = 0;

                numNotiValue.Value = 0;

                setUncheckColor();
                changeColorBlue();
            }
            else
            {
                tbTitle.Text = timeBlock.SubjectTitle;

                cbWeekday.SelectedIndex = timeBlock.WeekDay;

                cbStartHour.SelectedIndex = timeTable.StartTime.Hour;
                cbStartMin.SelectedIndex = timeTable.StartTime.Minute / 5;

                cbEndHour.SelectedIndex = timeTable.EndTime.Hour;
                cbEndMin.SelectedIndex = timeTable.EndTime.Minute / 5;

                numNotiValue.Value = timeBlock.NotiValue;

                setUncheckColor();
                switch (timeBlock.Color)
                {
                    case "Red":
                        changeColorRed();
                        break;
                    case "Orange":
                        changeColorOrange();
                        break;
                    case "Yellow":
                        changeColorYellow();
                        break;
                    case "Green":
                        changeColorGreen();
                        break;
                    case "Blue":
                        changeColorBlue();
                        break;
                }
            }
        }




        public void changeColorRed()
        {
            setUncheckColor();
            checkRed.Checked = true;
            color = "Red";
            pnlTitle.BackColor = Color.FromArgb(192, 0, 0);
        }

        public void changeColorOrange()
        {
            setUncheckColor();
            checkOrange.Checked = true;
            color = "Orange";
            pnlTitle.BackColor = Color.FromArgb(255, 128, 0);
        }

        public void changeColorYellow()
        {
            setUncheckColor();
            checkYellow.Checked = true;
            color = "Yellow";
            pnlTitle.BackColor = Color.FromArgb(192, 192, 0);
        }

        public void changeColorGreen()
        {
            setUncheckColor();
            checkGreen.Checked = true;
            color = "Green";
            pnlTitle.BackColor = Color.FromArgb(0, 192, 0);
        }

        public void changeColorBlue()
        {
            setUncheckColor();
            checkBlue.Checked = true;
            color = "Blue";
            pnlTitle.BackColor = Color.FromArgb(0, 192, 192);
        }

        public void setUncheckColor()
        {
            if (color == "Red") checkRed.Checked = false;
            else if (color == "Orange") checkOrange.Checked = false;
            else if (color == "Yellow") checkYellow.Checked = false;
            else if (color == "Green") checkGreen.Checked = false;
            else checkBlue.Checked = false;
        }

        public void checkRed_OnChange(object sender, EventArgs e)
        {
            changeColorRed();
        }


        public void checkOrange_OnChange(object sender, EventArgs e)
        {
            changeColorOrange();
        }

        public void checkYellow_OnChange(object sender, EventArgs e)
        {
            changeColorYellow();
        }

        public void checkGreen_OnChange(object sender, EventArgs e)
        {
            changeColorGreen();
        }

        public void checkBlue_OnChange(object sender, EventArgs e)
        {
            changeColorBlue();
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


        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbDescription.Text == "Add descriptions")
            {
                tbDescription.Text = "";
            }
            tbDescription.ForeColor = Color.Black;
        }

        private void tbDescription_Leave(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || tbDescription.Text == "Add descriptions")
            {
                tbDescription.Text = "Add descriptions";
                tbDescription.ForeColor = Color.DarkGray;
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

            weekday = cbWeekday.SelectedIndex;

            startTime = new DateTime(1, 1, 1, cbStartHour.SelectedIndex, cbStartMin.SelectedIndex * 5, 0);
            if (cbEndHour.SelectedIndex == 24)
            {
                endTime = new DateTime(1, 1, 1, 23, 55, 0);
            }
            else
            {
                endTime = new DateTime(1, 1, 1, cbEndHour.SelectedIndex, cbEndMin.SelectedIndex * 5, 0);
            }

            notiValue = (int)(numNotiValue.Value);

            if (tbDescription.Text == "Add descriptions")
            {
                description = "";
            }
            else
            {
                description = tbDescription.Text;
            }

            try
            {
                result = new TimeTable(title, enableWeekday, startTime, endTime, null);
            }
            catch (Exception ex)
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
    }
}
