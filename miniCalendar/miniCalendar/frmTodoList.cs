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
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        List<frmTask> list = new List<frmTask>();

        public frmTodoList()
        {
            InitializeComponent();
            tbAddTask.Text = "Add a to-do...";

            ShowTaskList();
        }

        public frmTodoList(int id, Dictionary<int, Task> todoList)
        {
            InitializeComponent();
            _todoList = todoList;
            _id = id;

            frmTask f = new frmTask();
            pnlTaskDetail.Controls.Add(f);
            f.Click += new EventHandler(btnTask_Click);
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
                    
                    _id = getID();
                    Task task = new Task();
                    task.Name = tbAddTask.Text;
                    task.DueDay = DateTime.Now;
                    task.RemindDay = DateTime.Now;         
                    _todoList.Add(_id, task);

                    frmTask abc = new frmTask(_id, _todoList);
                    abc.lbName.BringToFront();
                    list.Add(abc);

                    tbAddTask.Text = "";

                    abc.Click += new EventHandler(btnTask_Click);
                    fpTaskList.Controls.Add(abc);
                }                
            }

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            frmTask abc = sender as frmTask;
            frmTaskDetail fa = new frmTaskDetail(abc._id, _todoList,false);
            pnlTaskDetail.Controls.Clear();
            pnlTaskDetail.Controls.Add(fa);
            fa.Dock = DockStyle.Fill;
            fa.BringToFront();
        }

        public void ShowTaskList()
        {
            for(int i=0;i<list.Count;i++)
            {
                fpTaskList.Controls.Add(list[i]);
            }
        }

    }
}