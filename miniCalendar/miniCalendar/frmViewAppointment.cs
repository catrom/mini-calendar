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
    public partial class frmViewAppointment : UserControl
    {
        public Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        public int ID;
    

        public frmViewAppointment(int ID, Dictionary<int, Appointment> dataTable)
        {
            InitializeComponent();

            this.ID = ID;
            this.dataTable = dataTable;

            displayInfo();
        }

        private void displayInfo()
        {
            // display Title
            if (dataTable[ID].Title == "")
            {
                lbTitle.Text = "(No Title)";
            }
            else
            {
                lbTitle.Text = dataTable[ID].Title;
            }

            // Time
            if (dataTable[ID].startHour.Date == dataTable[ID].endHour.Date)
            {
                lbStartHour.Text = dataTable[ID].startHour.ToString("ddddddddd, dd MMM yyyy");
                if (dataTable[ID].endHour.Minute == 59)
                {
                    lbEndHour.Text = "(All day)";
                    lbEndHour.ForeColor = Color.DarkGray;
                }
                else
                {
                    lbEndHour.Text = dataTable[ID].startHour.ToString("hh:mm tt") + " - " +
                                dataTable[ID].endHour.ToString("hh:mm tt");
                    lbEndHour.ForeColor = Color.Black;
                }
            }
            else
            {
                lbStartHour.ForeColor = Color.Black;
                lbEndHour.ForeColor = Color.Black;
                lbStartHour.Text = dataTable[ID].startHour.ToString("ddddddddd, dd MMM yyyy       hh:mm tt");
                lbEndHour.Text = dataTable[ID].endHour.ToString("ddddddddd, dd MMM yyyy       hh:mm tt");
            }


            if (dataTable[ID].Location == "")
            {
                panelLocation.Visible = false;
            }
            else
            {
                panelLocation.Visible = true;
                lbLocation.Text = dataTable[ID].Location;
            }

            lbNoti.Text = Convert.ToString(dataTable[ID].notiValue) + " " + dataTable[ID].notiUnit + " before";

            if (dataTable[ID].Description == "")
            {
                panelDescription.Visible = false;
            }
            else
            {
                panelDescription.Visible = true;
                lbDescription.Text = dataTable[ID].Description;
            }

            switch (dataTable[ID].Color)
            {
                case "Red":
                    panelTitle.BackColor = Color.FromArgb(192, 0, 0);
                    break;
                case "Orange":
                    panelTitle.BackColor = Color.FromArgb(255, 128, 0);
                    break;
                case "Yellow":
                    panelTitle.BackColor = Color.FromArgb(192, 192, 0);
                    break;
                case "Green":
                    panelTitle.BackColor = Color.FromArgb(0, 192, 0);
                    break;
                case "Blue":
                    panelTitle.BackColor = Color.FromArgb(0, 192, 192);
                    break;
            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            panelView.Visible = false;

            frmNewAppointment frmModify = new frmNewAppointment(new List<int> { ID }, dataTable, new List<DateTime> { dataTable[ID].startHour }, true);
            frmModify.Disposed += new EventHandler(dispose_event);
            panelModify.Controls.Add(frmModify);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Delete this appointment?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                dataTable.Remove(ID);
                Dispose();
            }
            else if (dialogResult == DialogResult.No)
            { 
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void dispose_event(object sender, EventArgs e)
        {
            panelView.Visible = true;
            displayInfo();
        }

    }
}
