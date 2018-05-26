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
        DataTable dataTable = new DataTable();
        public frmAppointment()
        {
            InitializeComponent();
         
        }
        public frmAppointment(DataTable dataTable)
        {
            InitializeComponent();
            
            this.dataTable = dataTable;
        }
        private void btnNewAppointment_Click(object sender, EventArgs e)
        {
            this.frmNewAppointment1.BringToFront();
        }
    }
}
