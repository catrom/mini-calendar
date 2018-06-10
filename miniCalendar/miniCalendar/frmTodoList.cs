using System;
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

        public frmTodoList()
        {
            InitializeComponent();            
        }

        public frmTodoList(Dictionary<int, Task> todoList)
        {
            InitializeComponent();
            tbAddTask.Text = "Add a to-do...";
            //ShowTaskList();
            _todoList = todoList;

            if(_todoList.Count > 0)
            {
                for(int i=1;i<=_todoList.Count;i++)
                {
                    frmTask aTask = new frmTask(i,_todoList);
                    fpTaskList.Controls.Add(aTask);
                }
            }
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
                    //task.Key = _id;
                    task.Name = tbAddTask.Text;
                    task.DueDay = DateTime.Now;
                    task.RemindDay = DateTime.Now;         
                    _todoList.Add(_id, task);

                    frmTask abc = new frmTask(_id, _todoList);
                    abc.lbName.BringToFront();
                    _list.Add(abc._id);
                    MessageBox.Show(_list.Count.ToString());

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

        private void Delete_detail(int id, Dictionary<int, Task> todoList, List<int> list)
        {
            todoList.Remove(id);
            list.Remove(id);
            Dispose();
        }


    }
}