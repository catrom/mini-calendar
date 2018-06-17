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
