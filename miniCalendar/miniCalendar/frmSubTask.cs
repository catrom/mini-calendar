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

namespace miniCalendar
{
    public partial class frmSubTask : UserControl
    {
        public string _name;
        public frmSubTask()
        {
            InitializeComponent();
        }

        public frmSubTask(string name)
        {
            InitializeComponent();
            label1.Text = name;
        }


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
            this._todoList = _todoList;
            this._id = _id;
            lbSubtaskName.Text = name;
            _name = name;
        }

        // Lưu status cho subtask khi check hoặc uncheck vào checkbox
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
>>>>>>> todoList
