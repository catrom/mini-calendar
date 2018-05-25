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
    public partial class frmAppointment : UserControl
    {
        public frmAppointment()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmNewAppointment a = new frmNewAppointment();
            this.Controls.Add(a);
            a.Location = new Point(246, 0);
            TimeTable.Visible = false;
            a.Visible = true;
            a.BringToFront();
        }
    }
}
