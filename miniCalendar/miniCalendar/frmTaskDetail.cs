<<<<<<< HEAD
﻿using System;
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
        List<frmSubTask> _listSubTask = new List<frmSubTask>();

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

            showSubTaskList();
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
                //MessageBox.Show(_id.ToString());
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
            st.pictureBox1.Click += new EventHandler(pictureBox1_Click);

            _listSubTask.Add(st);
            _todoList[_id].subTasks.Add(tbSubtask.text);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void showSubTaskList()
        {
            var list = _todoList[_id].subTasks;

            foreach(string i in list)
            {
                frmSubTask st = new frmSubTask(i);
                fpSubTask.Controls.Add(st);
                st.BringToFront();
                st.Dock = DockStyle.Top;
                _listSubTask.Add(st);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
=======
﻿using System;
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
        Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        public int _id;
        public string _color;

        Task temptask = new Task();
        List<int> tempstt = new List<int>();
        List<string> tempsub = new List<string>();

        public bool _isModified;
        List<frmSubTask> _listSubTask = new List<frmSubTask>();


        public frmTaskDetail()
        {
            InitializeComponent();
        }
 
        public frmTaskDetail(int id, Dictionary<int, Task> todoList, bool isModified) 
        {
            InitializeComponent();

            _todoList = todoList;
            _id = id;

            // lưu giá trị tạm thời
            temptask = todoList[id];
            tempstt = todoList[id].subTaskStatus.ToList();
            tempsub = todoList[id].subTasks.ToList();

            _isModified = isModified;
            tbSubtask.text = "Add a to-do...";
            rtbNote.Text = "Add a note...";

            ShowInfo(_isModified);

            // xét giá trị cho biến _color
            setUncheckColor();
            switch (_color)
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

            showSubTaskList();
        }

        //  clear textbox khi gõ 1 phím bất kì
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

        // lưu dữ liệu xuống khi nhấn button save
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

            frmTodoList tdl = new frmTodoList(_todoList);
            tdl.showTaskList();

            temptask = _todoList[_id];
            tempstt = _todoList[_id].subTaskStatus.ToList();
            tempsub = _todoList[_id].subTasks.ToList();

            Dispose();
        }

        // lưu dữ liệu hoặc xuất info
        private void ShowInfo(bool isModified)
        {
            if (isModified == false)
            {
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
                _todoList[_id].DueDay = new DateTime(dtpDueDay.Value.Year, dtpDueDay.Value.Month, dtpDueDay.Value.Day, 23, 59, 59);
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

        // Undo
        private void btnUndo_Click(object sender, EventArgs e)
        { 
            Console.WriteLine("tempstt " + tempstt.Count + "   " + "list" + _todoList[_id].subTaskStatus.Count);
            Console.WriteLine("tempsub " + tempsub.Count + "   " + "list" + _todoList[_id].subTasks.Count);

            _todoList[_id] = temptask;
            _todoList[_id].subTasks = tempsub.ToList();
            _todoList[_id].subTaskStatus = tempstt.ToList();
            

            Console.WriteLine("-tempstt " + tempstt.Count + "   " + "list" + _todoList[_id].subTaskStatus.Count);
            Console.WriteLine("-tempsub " + tempsub.Count + "   " + "list" + _todoList[_id].subTasks.Count);

            ShowInfo(_isModified);
            showSubTaskList();
        }

        // xoá task khi check vào checkbox
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
            _color = "Red";
        }

        public void changeColorYellow()
        {
            setUncheckColor();
            checkYellow.Checked = true;
            _color = "Yellow";
        }

        public void changeColorGreen()
        {
            setUncheckColor();
            checkGreen.Checked = true;
            _color = "Green";
        }

        public void changeColorGray()
        {
            setUncheckColor();
            checkGray.Checked = true;
            _color = "Gray";
        }

        public void setUncheckColor()
        {
            if (_color == "Red") checkRed.Checked = false;
            else if (_color == "Yellow") checkYellow.Checked = false;
            else if (_color == "Green") checkGreen.Checked = false;
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

        // add 1 subtask khi click vào button add-
        private void button1_Click(object sender, EventArgs e)
        {
            frmSubTask st = new frmSubTask(_todoList, _id, tbSubtask.text);
            st.Disposed += new EventHandler(dispose_event);
            fpSubTask.Controls.Add(st);
            st.BringToFront();
            st.Dock = DockStyle.Top;

            _listSubTask.Add(st);
            st.pbdelete.Tag = _listSubTask.Count.ToString();
            _todoList[_id].subTasks.Add(tbSubtask.text);
            _todoList[_id].subTaskStatus.Add(0);
            tbSubtask.text = "";
        }

        // clear panel SubTask trước khi vẽ lại
        private void clearfpSubTask()
        {
            for (int i = fpSubTask.Controls.Count - 1; i >= 0; i--)
            {
                if (fpSubTask.Controls[i] is frmSubTask)
                {
                    fpSubTask.Controls.RemoveAt(i);
                }
            }
        }

        // show subtask list khi load form
        private void showSubTaskList()
        {
            _listSubTask.Clear();
            clearfpSubTask();

            var list = _todoList[_id].subTasks;
            Console.WriteLine(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                frmSubTask st = new frmSubTask(_todoList, _id, list[i]);
                st.pbdelete.Tag = i.ToString();
                st.pbdelete.Click += new EventHandler(pbdelete);
                fpSubTask.Controls.Add(st);
                st.BringToFront();
                st.Dock = DockStyle.Top;
                _listSubTask.Add(st);

                if (_todoList[_id].subTaskStatus[i] == 1)
                {
                    st.cbIsDone.Checked = true;
                }
                else
                {
                    st.cbIsDone.Checked = false;
                }


                st.Disposed += new EventHandler(dispose_event);
            }

            updateIndexSub();
        }

        // update lại chỉ số của subtask khi xoá hoặc thêm subtask
        private void updateIndexSub()
        {
            for (int i = 0; i < _listSubTask.Count; i++)
            {
                _listSubTask[i].cbIsDone.TabIndex = i;
            }
        }

        // sự kiện đóng form
        public void dispose_event(object sender, EventArgs e)
        {
            clearfpSubTask();
            showSubTaskList();
            updateIndexSub();
        }

        // xử lý sự kiện xoá 1 subtask
        private void pbdelete(object sender, EventArgs e)
        {
            var pbdel = (PictureBox)sender;
            var index = Convert.ToInt32(pbdel.Tag);
            _todoList[_id].subTasks.RemoveAt(index);
            _todoList[_id].subTaskStatus.RemoveAt(index);

            showSubTaskList();      
        }
    }
}
>>>>>>> todoList
