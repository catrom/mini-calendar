using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar.Schedule
{
    public partial class frmNewTimeTable : UserControl
    {
        List<TimeTable> timeTables = new List<TimeTable>();

        public string title = "";
        public DateTime startTime;
        public DateTime endTime;
        public bool[] enableWeekday = new bool[7];
        public bool isModified;

        public frmNewTimeTable()
        {
            InitializeComponent();
        }
        
        public frmNewTimeTable(List<TimeTable> timeTables)
        {
            InitializeComponent();
            this.timeTables = timeTables;

        }
    }
}
