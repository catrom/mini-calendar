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
        public Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        FlowLayoutPanel fPanel = new FlowLayoutPanel();
        List<frmTask> list = new List<frmTask>();

        public frmTodoList()
        {
            InitializeComponent();
            tbAddTask.Text = "Add a to-do...";

        }

        public frmTodoList(Dictionary<int, Task> todoList)
        {
            InitializeComponent();
            _todoList = todoList;

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
                    //tbAddTask.Text = "";
                }

                int id = getID();
                _todoList.Add(id, new Task(tbAddTask.Text, new DateTime(), new DateTime(), new DateTime(), "", ""));

                frmTask abc = new frmTask(id, _todoList);
                MessageBox.Show(abc.lbTaskName.Text);

                list.Add(abc);

                abc.Click += new EventHandler(btnTask_Click);
                fpTaskList.Controls.Add(abc);
            }

        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            frmTaskDetail fa = new frmTaskDetail();
            pnlTaskDetail.Controls.Clear();
            pnlTaskDetail.Controls.Add(fa);
            fa.Dock = DockStyle.Fill;
            fa.BringToFront();
        }

        private void tbAddTask_Enter(object sender, EventArgs e)
        {
            if (tbAddTask.Text == "Add a to-do...")
            {
                tbAddTask.BackColor = Color.White;
            }
        }

    }
}