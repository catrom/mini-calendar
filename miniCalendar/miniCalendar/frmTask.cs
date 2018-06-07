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
        public string _name = "";

        public frmTask() { }

        public frmTask(int id, Dictionary<int, Task> todoList)
        {
            InitializeComponent();

            _id = id;
            _todoList = todoList;

            displayInfo();
        }

        public void displayInfo()
        {
            if (string.IsNullOrEmpty(_todoList[_id].Name))
            {
                lbTaskName.Text = "(no title)";
            }
            else
            {
                lbTaskName.Text = _todoList[_id].Name;
            }


        }

    }

}
