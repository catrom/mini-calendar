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

            this.btnTaskName.TabIndex = id;

            displayInfo();
        }

        public void displayInfo()
        {
            if (_todoList[_id].Name == "")
            {
                btnTaskName.Text = "(no title)";
            }
            else
            {
                btnTaskName.Text = _todoList[_id].Name;
            }
        }

        

        private void cbIsDone_OnChange(object sender, EventArgs e)
        {
            if(cbIsDone.Checked)
            {
                _todoList.Remove(_id);
                Dispose();
            }
        }
    } 

}
