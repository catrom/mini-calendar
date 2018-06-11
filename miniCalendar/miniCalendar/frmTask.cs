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
        //public bool _isModified;

        public frmTask() {
            InitializeComponent();
        }

        public frmTask(int id, Dictionary<int, Task> todoList)
        {
            InitializeComponent();

            _id = id;
            _todoList = todoList;
            //_isModified = isModified;
            
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

        public void Dispose(int id)
        {
            Dispose();
        }

        private void cbIsDone_OnChange(object sender, EventArgs e)
        {
            if(cbIsDone.Checked)
            {
                _todoList.Remove(_id);
                Dispose();

                //frmTodoList td = new frmTodoList();
                //td.Dispose();

            }
        }
    } 

}
