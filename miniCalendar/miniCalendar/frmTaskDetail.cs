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
        public string color = "Gray";  

        public frmTaskDetail()
        {
            InitializeComponent();
        }
 
        public frmTaskDetail(int id, Dictionary<int, Task> todoList, bool isModified) 
        {
            InitializeComponent();

            _id = id;
            _todoList = todoList;
            _isModified = isModified;
            tbSubtask.text = "Add a to-do...";

            ShowInfo(_isModified);

            setUncheckColor();
            switch (color)
            {
                case "Red":
                    changeColorRed();
                    break;
                case "Yellow":
                    changeColorYellow();
                    break;
                case "Green":
                    changeColorGreen();
                    break;
                case "Gray":
                    changeColorGray();
                    break;
            }
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
                _isModified = true;
                ShowInfo(_isModified);
            }
            lbInfo.Text = "Last updated on " + DateTime.Now;

            frmTask aTask = new frmTask(_id, _todoList);
            aTask.btnTaskName.Normalcolor = Color.Red;
        }

        private void ShowInfo(bool isModified)
        {
            if (isModified == false)
            {
                MessageBox.Show(_id.ToString());
                tbTaskName.Text = _todoList[_id].Name;  
                dtpDueDay.Value = _todoList[_id].DueDay;
                dtpRemindTime.Value = _todoList[_id].RemindTime;
                dtpRemindDay.Value = _todoList[_id].RemindDay;
                if(_todoList[_id].Note == "")
                {
                    rtbNote.Text = "Add a note...";
                    rtbNote.ForeColor = Color.Green;
                }
                rtbNote.Text = _todoList[_id].Note;
                if(_todoList[_id].Color == "Red")
                {
                    setUncheckColor();
                    changeColorRed();
                }
                else if (_todoList[_id].Color == "Yellow")
                {
                    setUncheckColor();
                    changeColorYellow();
                }
                else if (_todoList[_id].Color == "Green")
                {
                    setUncheckColor();
                    changeColorGreen();
                }
                else if (_todoList[_id].Color == "Gray")
                {
                    setUncheckColor();
                    changeColorGray();
                }
                lbInfo.Text = "Created on " + _todoList[_id].StartDay.ToString();
            }
            else
            {
                _todoList[_id].Name = tbTaskName.Text;
                _todoList[_id].DueDay = dtpDueDay.Value;
                _todoList[_id].RemindTime = dtpRemindTime.Value;
                _todoList[_id].RemindDay = dtpRemindDay.Value;
                _todoList[_id].Note = rtbNote.Text;
                if(checkRed.Checked)
                {
                    _todoList[_id].Color = "Red";
                }
                else if(checkYellow.Checked) {
                    _todoList[_id].Color = "Yellow";
                }
                else if(checkGreen.Checked)
                {
                    _todoList[_id].Color = "Green";
                }
                else if(checkGray.Checked)
                {
                    _todoList[_id].Color = "Gray";
                }
                _todoList[_id].StartDay = DateTime.Now;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _isModified = false;
            ShowInfo(_isModified);
        }

        public void cbIsDone_OnChange(object sender, EventArgs e)
        {
            if (cbIsDone.Checked)
            {
                frmTodoList newList = new frmTodoList( _todoList);
                _todoList.Remove(_id);
                Dispose();

                
            }
        }

        #region Color
        public void changeColorRed()
        {
            setUncheckColor();
            checkRed.Checked = true;
            color = "Red";
        }

        public void changeColorYellow()
        {
            setUncheckColor();
            checkYellow.Checked = true;
            color = "Yellow";
        }

        public void changeColorGreen()
        {
            setUncheckColor();
            checkGreen.Checked = true;
            color = "Green";
        }

        public void changeColorGray()
        {
            setUncheckColor();
            checkGray.Checked = true;
            color = "Gray";
        }

        public void setUncheckColor()
        {
            if (color == "Red") checkRed.Checked = false;
            else if (color == "Yellow") checkYellow.Checked = false;
            else if (color == "Green") checkGreen.Checked = false;
            else checkGray.Checked = false;
        }

        public void checkRed_OnChange(object sender, EventArgs e)
        {
            changeColorRed();
        }

        public void checkYellow_OnChange(object sender, EventArgs e)
        {
            changeColorYellow();
        }

        public void checkGreen_OnChange(object sender, EventArgs e)
        {
            changeColorGreen();
        }

        public void checkGray_OnChange(object sender, EventArgs e)
        {
            changeColorGray();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            frmSubTask st = new frmSubTask(tbSubtask.text);
            fpSubTask.Controls.Add(st);
            st.BringToFront();
            st.Dock = DockStyle.Top;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
