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
            
            displayInfo();
        }

        public void displayInfo()
        {
            if (_todoList[_id].Name == "")
            {
                lbName.Text = "(no title)";
            }
            else
            {
                lbName.Text = _todoList[_id].Name;
            }
        }

        private void cbIsDone_OnChange(object sender, EventArgs e)
        {
            frmTodoList tdl = new frmTodoList();
            if(cbIsDone.Checked)
            {
                
            }
        }

        private void frmTask_Load(object sender, EventArgs e)
        {
            frmTodoList abc = new frmTodoList(_todoList);
            frmTaskDetail fa = new frmTaskDetail(_id, _todoList, false);
            abc.pnlTaskDetail.Controls.Clear();
            abc.pnlTaskDetail.Controls.Add(fa);
            fa.Dock = DockStyle.Fill;
            fa.BringToFront();
        }
    }

}
