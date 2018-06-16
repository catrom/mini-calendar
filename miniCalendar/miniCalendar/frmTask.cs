using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar
{
    public partial class frmTask : UserControl
    {
        public Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        public int _id;

        public frmTask() {
            InitializeComponent();
        }

        public frmTask(int id, Dictionary<int, Task> todoList)
        {
            InitializeComponent();

            _id = id;
            _todoList = todoList;

            this.btnTaskName.TabIndex = id;

            displayInfo();
        }

        public void displayInfo()
        {
            if (_todoList[_id].Name == "")
            {
                btnTaskName.Text = "(no title)";
            }
            else
            {
                btnTaskName.Text = _todoList[_id].Name;
            }
            int pg = _todoList[_id].subTasks.Count;

            if (pg == 0)
            {
                pnlTaskDone.Visible = false;
                lbTaskDone.Text = "Progress: 0%";
            }
            else
            {
                lbTaskDone.Text = "Progress";
                lbTaskDone.BringToFront();
                int count = 0;
                for (int i = 0; i < _todoList[_id].subTaskStatus.Count; i++)
                {
                    if (_todoList[_id].subTaskStatus[i] == 1)
                        count++;
                }
                pnlTaskDone.Width = (count * 331) / (pg);
                int percent = (int)(count * 100 / pg);
                lbTaskDone.Text = lbTaskDone.Text + ": " + percent.ToString() + "%";
            }
            pnlTaskDone.BackColor = Color.FromArgb(91, 184, 93);

            if (isEqual(_todoList[_id].DueDay, _todoList[_id].StartDay))
            {
                lbDayLeft.Text = "Due today.";
                lbDayLeft.BringToFront();
                pnlDayPast.Dock = DockStyle.Fill;
                pnlDayPast.BackColor = Color.FromArgb(217, 84, 79);
            }
            else
            {
                TimeSpan totalDay = _todoList[_id].DueDay - _todoList[_id].StartDay;
                TimeSpan dayLeft = _todoList[_id].DueDay - DateTime.Now;
                TimeSpan dayPast = DateTime.Now - _todoList[_id].StartDay;

                if (dayLeft == totalDay)
                {
                    pnlDayPast.Visible = false;
                }
                else
                {
                    if (dayLeft.Days == 1)
                    {
                        lbDayLeft.Text = "1 day left.";
                        lbDayLeft.BringToFront();
                        pnlDayPast.Width = (dayPast.Days * 331) / (totalDay.Days);
                    }

                    else
                    {
                        lbDayLeft.Text = dayLeft.Days.ToString() + " days left.";
                        lbDayLeft.BringToFront();
                        pnlDayPast.Width = (dayPast.Days * 331) / (totalDay.Days);
                    }

                    float n = dayPast.Days / totalDay.Days;
                    if (n <= 1 / 3)
                        pnlDayPast.BackColor = Color.FromArgb(91, 192, 222);
                    else if (n > 1 / 3 && n <= 2 / 3)
                        pnlDayPast.BackColor = Color.FromArgb(239, 173, 77);
                    else if (n > 2 / 3 && n <= 1)
                        pnlDayPast.BackColor = Color.FromArgb(217, 84, 79);    
                }
            }
        }

        public bool isEqual(DateTime a, DateTime b)
        {
            if (a.Year == b.Year)
            {
                if (a.Month == b.Month)
                {
                    if (a.Day == b.Day)
                        return true;
                    else return false;
                }
                else return false;
            }

            return false;
        }

        private void cbIsDone_OnChange(object sender, EventArgs e)
        {
            if(cbIsDone.Checked)
            {
                _todoList.Remove(_id);
                Dispose();
            }
        }
    } 

}
