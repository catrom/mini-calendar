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
            MessageBox.Show(idpick.ToString());
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
}