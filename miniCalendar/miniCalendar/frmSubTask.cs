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
    public partial class frmSubTask : UserControl
    {
        Dictionary<int, Task> _todoList;
        int _id;
        public string _name;
        public frmSubTask()
        {
            InitializeComponent();
        }

        public frmSubTask(Dictionary<int, Task> _todoList, int _id, string name)
        {
            InitializeComponent();
            this.Disposed += new EventHandler(dispose);
            this._todoList = _todoList;
            this._id = _id;
            lbSubtaskName.Text = name;
            _name = name;
        }

        public void dispose(object sender, EventArgs e)
        {
            for (int i = 0; i < _todoList[_id].subTasks.Count; i++)
            {
                if (_todoList[_id].subTasks[i] == _name)
                {
                    _todoList[_id].subTasks.RemoveAt(i);
                    _todoList[_id].subTaskStatus.RemoveAt(i);
                    break;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cbIsDone_OnChange(object sender, EventArgs e)
        {
            Console.WriteLine(this.TabIndex);

            if (cbIsDone.Checked == true)
            {
                _todoList[_id].subTaskStatus[this.TabIndex] = 1;
            }
            else
            {
                _todoList[_id].subTaskStatus[this.TabIndex] = 0;
            }
        }
    }
}
