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
    public partial class frmTaskDetail : UserControl
    {
        public int _id;
        Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        public bool _isModified;

        public DateTime _dueDay;
        public Point _remindTime;
        public DateTime _remindDay;
        public string _note = "";
        public string _comment = ""; 

        public frmTaskDetail(int id, Dictionary<int, Task> todoList, bool isModified) 
        {
            InitializeComponent();

            _id = id;
            _todoList = todoList;
            _isModified = isModified;
            tbSubtask.text = "Add a to-do...";

            ShowInfo(_isModified);
        }

        private void tbSubtask_KeyDown(object sender, EventArgs e)
        {
            if (tbSubtask.text == "Add a to-do...")
            {
                tbSubtask.text = "";
            }
        }

        private void tbSubtask_Enter(object sender, EventArgs e)
        {
            if (tbSubtask.text == "Add a to-do...")
            {
                tbSubtask.BackColor = Color.White;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(dtpRemindDay.Value > dtpDueDay.Value)
            {
                MessageBox.Show("Change your 'Remind Day' before clicking 'Save' button!", "Error!!!");
            }
            else
            {
                _todoList[_id].Name = tbTaskName.Text;
                _todoList[_id].DueDay = dtpDueDay.Value;

                DateTime dt = new DateTime();
                _todoList[_id].RemindTime = dt.AddHours((double)nmHours.Value);
                _todoList[_id].RemindTime = dt.AddMinutes((double)nmMinutes.Value);

                _todoList[_id].RemindDay = dtpRemindDay.Value;
                _todoList[_id].Note = rtbNote.Text;
                _todoList[_id].Comment = tbComment.text;
            }
            MessageBox.Show(_todoList[_id].Name + "\n" + _todoList[_id].DueDay.ToString());
        }

        private void ShowInfo(bool isModified)
        {
            if (isModified == false)
            {
                tbTaskName.Text = _todoList[_id].Name;  
                dtpDueDay.Value = _todoList[_id].DueDay;
                nmHours.Value = _todoList[_id].RemindTime.Hour;
                nmMinutes.Value = _todoList[_id].RemindTime.Minute;
                dtpRemindDay.Value = _todoList[_id].RemindDay;
                rtbNote.Text = _todoList[_id].Note;
                tbComment.text = _todoList[_id].Comment;
            }
            else
            {
                _todoList[_id].Name = tbTaskName.Text;
                _todoList[_id].DueDay = dtpDueDay.Value;

                DateTime dt = new DateTime();
                _todoList[_id].RemindTime = dt.AddHours((double)nmHours.Value);
                _todoList[_id].RemindTime = dt.AddMinutes((double)nmMinutes.Value);

                _todoList[_id].RemindDay = dtpRemindDay.Value;
                _todoList[_id].Note = rtbNote.Text;
                _todoList[_id].Comment = tbComment.text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _isModified = false;
            ShowInfo(_isModified);
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if(cbIsDone.Checked)
            {
                _todoList.Remove(_id);
                Dispose();
            }
        }
    }
}
