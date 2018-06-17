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
using System.IO;
using System.Xml.Serialization;

namespace miniCalendar
{
    public partial class frmTodoList : UserControl
    {
        private Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        int _id;
        List<int> _list = new List<int>();
        List<string> _listSubTask = new List<string>();

        public frmTodoList()
        {
            InitializeComponent();       
        }

        public frmTodoList(Dictionary<int, Task> todoList)
        {
            InitializeComponent();
            tbAddTask.Text = "Add a to-do...";
            _todoList = todoList;

            foreach (var i in _todoList)
            {
                Console.WriteLine(i.Key.ToString() + "  " + i.Value.ID.ToString());
            }

            showTaskList();
            _id = getID();

            
        }

        public void showTaskList()
        {
            if (_todoList.Count > 0)
            {              
                foreach (var task in _todoList)
                {
                    frmTask aTask = new frmTask(task.Value.ID, _todoList);
                    aTask.btnTaskName.TabIndex = task.Value.ID;
                    aTask.btnTaskName.Click += new EventHandler(btnTask_Click);
                    
                    if (task.Value.Color == "Red")
                    {
                        aTask.btnTaskName.Normalcolor = Color.Red;
                        aTask.btnTaskName.Activecolor = Color.White;

                    }
                    else if (task.Value.Color == "Yellow")
                    {
                        aTask.btnTaskName.Normalcolor = Color.Yellow;
                        aTask.btnTaskName.Activecolor = Color.White;
                    }
                    else if (task.Value.Color == "Green")
                    {
                        aTask.btnTaskName.Normalcolor = Color.Green;
                        aTask.btnTaskName.Activecolor = Color.White;
                    }
                    else if (task.Value.Color == "Gray")
                    {
                        aTask.btnTaskName.Normalcolor = Color.Gray;
                        aTask.btnTaskName.Activecolor = Color.White;
                    }

                    fpTaskList.Controls.Add(aTask);
                }
            }
            //fpTaskList.Controls.Clear();
        }

        private int getID()
        {
            for (int i = 1; ; i++)
            {
                if (_todoList.ContainsKey(i) == false)
                {
                    return i;
                }
            }
        }

        private void tbAddTask_Enter(object sender, EventArgs e)
        {
            if (tbAddTask.Text == "Add a to-do...")
            {
                tbAddTask.BackColor = Color.White;
            }
        }
        private void tbAddTask_KeyDown(object sender, KeyEventArgs e)
        {
            _id = getID();
            if (tbAddTask.Text == "Add a to-do...")
            {
                tbAddTask.Text = "";
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbAddTask.Text))
                    MessageBox.Show("Textbox can't be empty!", "Error!!!");
                else
                {
                    DateTime now = DateTime.Now;                   
                    Task task = new Task();
                    task.ID = _id;
                    task.Name = tbAddTask.Text;
                    task.DueDay = DateTime.Now;
                    task.RemindDay = DateTime.Now;
                    task.RemindTime = DateTime.Now;
                    task.Color = "Gray";
                    task.StartDay = now;    
                    _todoList.Add(_id, task);

                    frmTask abc = new frmTask(_id, _todoList);
                    abc.btnTaskName.TabIndex = _id;
                    abc.btnTaskName.BackColor = Color.Red;
                    abc.btnTaskName.BringToFront();
                    _list.Add(abc._id);

                    tbAddTask.Text = "";

                    abc.btnTaskName.Click += new EventHandler(btnTask_Click);
                    abc.Disposed += new EventHandler(disposed_event);
                    fpTaskList.Controls.Add(abc);
                }                
            }
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            for (int i = pnlTaskDetail.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlTaskDetail.Controls[i] is frmTaskDetail)
                {
                    pnlTaskDetail.Controls.RemoveAt(i);
                }
            }
            

            var pick = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            int idpick = pick.TabIndex;
           // MessageBox.Show(idpick.ToString());
            frmTaskDetail fa = new frmTaskDetail(idpick, _todoList, false);
            fa.Disposed += new EventHandler(dispose_event);
            
            
            pnlTaskDetail.Controls.Add(fa);
            fa.Dock = DockStyle.Fill;
            fa.BringToFront();      


        }

        public bool moreImportant(string a, string b)
        {
            if (a == "Red")
                return true;
            else if(a == "Yellow")
            {
                if (b == "Red" || b == "Yellow")
                    return false;
                else return true;
            }
            else if(a == "Green")
            {
                if (b == "Green" || b == "Gray")
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public void swapLocation(frmTask a, frmTask b)
        {
            Point temp = new Point();
            temp = a.Location;
            a.Location = b.Location;
            b.Location = temp;
        }

        public void dispose_event(object sender, EventArgs e)
        {
            fpTaskList.Controls.Clear();
            showTaskList();
        }

        public void disposed_event(object sender, EventArgs e)
        {
            pnlTaskDetail.Controls.Clear();
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
using System.IO;
using System.Xml.Serialization;

namespace miniCalendar
{
    public partial class frmTodoList : UserControl
    {
        private Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        int _id;
        List<int> _list = new List<int>();
        List<string> _listSubTask = new List<string>();

        public frmTodoList()
        {
            InitializeComponent();       
        }

        public frmTodoList(Dictionary<int, Task> todoList)
        {
            InitializeComponent();
            tbAddTask.Text = "Add a to-do...";
            _todoList = todoList;

            showTaskList();
            _id = getID();      
        }

        // clear tasklist trước rồi mới vẽ lại 
        private void clearTaskList()
        {
            for (int i = fpTaskList.Controls.Count - 1; i >= 0; i--)
            {
                if (fpTaskList.Controls[i] is frmTask)
                {
                    fpTaskList.Controls.RemoveAt(i);
                }
            }
        }

        // vẽ list các task
        public void showTaskList()
        {
            clearTaskList();
            if (_todoList.Count > 0)
            {              
                foreach (var task in _todoList)
                {
                    frmTask aTask = new frmTask(task.Value.ID, _todoList);
                    aTask.btnTaskName.TabIndex = task.Value.ID;
                    aTask.btnTaskName.Click += new EventHandler(btnTask_Click);
                    
                    if (task.Value.Color == "Red")
                    {
                        aTask.btnTaskName.Normalcolor = Color.FromArgb(217, 84, 79);
                        aTask.btnTaskName.Activecolor = Color.White;

                    }
                    else if (task.Value.Color == "Yellow")
                    {
                        aTask.btnTaskName.Normalcolor = Color.FromArgb(239, 173, 77);
                        aTask.btnTaskName.Activecolor = Color.White;
                    }
                    else if (task.Value.Color == "Green")
                    {
                        aTask.btnTaskName.Normalcolor = Color.FromArgb(91, 192, 222);
                        aTask.btnTaskName.Activecolor = Color.White;
                    }
                    else if (task.Value.Color == "Gray")
                    {
                        aTask.btnTaskName.Normalcolor = Color.Gray;
                        aTask.btnTaskName.Activecolor = Color.White;
                    }

                    fpTaskList.Controls.Add(aTask);
                }
            }
        }

        // lấy giá trị cho ID
        private int getID()
        {
            for (int i = 1; ; i++)
            {
                if (_todoList.ContainsKey(i) == false)
                {
                    return i;
                }
            }
        }

        // đổi màu chữ khi click chuột vào textbox
        private void tbAddTask_Enter(object sender, EventArgs e)
        {
            if (tbAddTask.Text == "Add a to-do...")
            {
                tbAddTask.ForeColor = Color.Black;
            }
        }

        // xét sự kiện nhấn phím
        private void tbAddTask_KeyDown(object sender, KeyEventArgs e)
        {
            _id = getID();
            if (tbAddTask.Text == "Add a to-do...")
            {
                tbAddTask.Text = "";
            }

            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tbAddTask.Text))
                    MessageBox.Show("Textbox can't be empty!", "Error!!!");
                else
                {
                    DateTime now = DateTime.Now;                   
                    Task task = new Task();
                    task.ID = _id;
                    task.Name = tbAddTask.Text;
                    task.DueDay = DateTime.Now;
                    task.RemindDay = DateTime.Now;
                    task.RemindTime = DateTime.Now;
                    task.Color = "Gray";
                    task.StartDay = DateTime.Now;
                    _todoList.Add(_id, task);

                    frmTask abc = new frmTask(_id, _todoList);
                    abc.btnTaskName.TabIndex = _id;
                    abc.btnTaskName.BackColor = Color.Red;
                    abc.btnTaskName.BringToFront();
                    _list.Add(abc._id);

                    tbAddTask.Text = "";

                    abc.btnTaskName.Click += new EventHandler(btnTask_Click);
                    abc.Disposed += new EventHandler(disposed_event);
                    fpTaskList.Controls.Add(abc);
                }                
            }
        }

        // click vào task sẽ show taskdetail
        private void btnTask_Click(object sender, EventArgs e)
        {
            clearpnlTaskDetail();
            

            var pick = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            int idpick = pick.TabIndex;
            _id = idpick;
            frmTaskDetail fa = new frmTaskDetail(_id, _todoList, false);
            fa.Disposed += new EventHandler(dispose_event);
            fa.pictureBox4.Click += new EventHandler(closeTaskDetail);

            fa.checkRed.BackColor = Color.FromArgb(217, 84, 79);
            fa.checkRed.ChechedOffColor = Color.FromArgb(217, 84, 79);
            fa.checkRed.CheckedOnColor = Color.FromArgb(217, 84, 79);
            fa.checkYellow.BackColor = Color.FromArgb(239, 173, 77);
            fa.checkYellow.ChechedOffColor = Color.FromArgb(239, 173, 77);
            fa.checkYellow.CheckedOnColor = Color.FromArgb(239, 173, 77);
            fa.checkGreen.BackColor = Color.FromArgb(91, 192, 222);
            fa.checkGreen.ChechedOffColor = Color.FromArgb(91, 192, 222);
            fa.checkGreen.CheckedOnColor = Color.FromArgb(91, 192, 222);


            pnlTaskDetail.Controls.Add(fa);
            fa.Dock = DockStyle.Fill;
            fa.BringToFront();
        }

        #region Dispose_event
        public void dispose_event(object sender, EventArgs e)
        {
            fpTaskList.Controls.Clear();
            showTaskList();
        }

        public void frmTaskDetailDispose(object sender, EventArgs e)
        {
            fpTaskList.Controls.Clear();
            showTaskList();
        }

        public void disposed_event(object sender, EventArgs e)
        {
            pnlTaskDetail.Controls.Clear();
        }

        private void close_event(object sender, EventArgs e)
        {
            clearpnlTaskDetail();
        }
        #endregion

        // clear panel taskdetail trước khi vẽ lại
        private void clearpnlTaskDetail()
        {
            for (int i = pnlTaskDetail.Controls.Count - 1; i >= 0; i--)
            {
                if (pnlTaskDetail.Controls[i] is frmTaskDetail)
                {
                    pnlTaskDetail.Controls.RemoveAt(i);
                }
            }
        }

        // đóng panel TaskDetail
        private void closeTaskDetail(object sender, EventArgs e)
        {
            clearpnlTaskDetail();
        }

    }
>>>>>>> todoList
}