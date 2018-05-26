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
    public partial class frmNewAppointment : UserControl
    {
        private DataTable dataTable = new DataTable();
        private DateTime dateTime = new DateTime();
        public frmNewAppointment()
        {
            InitializeComponent();
        }
        public frmNewAppointment(DataTable dataTable, DateTime dateTime)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.dateTime = dateTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
