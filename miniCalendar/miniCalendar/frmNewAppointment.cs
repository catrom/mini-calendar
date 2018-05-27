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
        private string title = "";
        private DateTime startHour;
        private DateTime endHour;
        private string location = "";
        private int notiValue;
        private string notiUnit;
        private string color = "Blue";
        private string description = "";

        public frmNewAppointment()
        {
            InitializeComponent();
        }
        public frmNewAppointment(DataTable dataTable, DateTime dateTime)
        {
            InitializeComponent();
            dtpStartDay.Value = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            dtpEndDay.Value = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            cbStartHour.SelectedIndex = 0;
            cbEndHour.SelectedIndex = 47;
            dtpStartDay.Value = dateTime;
            dtpEndDay.Value = dateTime;
            numNotiValue.Value = 30;
            cbNotiUnit.SelectedIndex = 0;
            this.dataTable = dataTable;
            this.dateTime = dateTime;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpStartDay.Value > dtpEndDay.Value ||
                (dtpStartDay.Value == dtpEndDay.Value && cbStartHour.SelectedIndex > cbEndHour.SelectedIndex))
            {
                MessageBox.Show("Change the start time to be before the end of the appointment.");
            }
            else
            {
                // set value
                title = tbTitle.Text;
                location = tbLocation.Text;
                notiValue = Convert.ToInt32(numNotiValue.Value);
                notiUnit = cbNotiUnit.Text;
                description = tbDescription.Text;

                if (switchAllday.Value == true)
                {
                    int X = cbStartHour.SelectedIndex;
                    startHour = new DateTime(dtpStartDay.Value.Year, dtpStartDay.Value.Month, dtpStartDay.Value.Day, X / 2, 30 * (X % 2), 0);
                    endHour = new DateTime(dtpEndDay.Value.Year, dtpEndDay.Value.Month, dtpEndDay.Value.Day, 23, 59, 59);
                }
                else
                {
                    int X = cbStartHour.SelectedIndex;
                    int Y = cbEndHour.SelectedIndex;
                    startHour = new DateTime(dtpStartDay.Value.Year, dtpStartDay.Value.Month, dtpStartDay.Value.Day, X / 2, 30 * (X % 2), 0);
                    endHour = new DateTime(dtpEndDay.Value.Year, dtpEndDay.Value.Month, dtpEndDay.Value.Day, Y / 2, 30 * (Y % 2), 0);
                }

            
                dataTable.Add(new Appointment(title, startHour, endHour, location, notiValue, notiUnit, color, description));
                
                this.Dispose(false);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(false);

        }
        
        private void switchAllday_OnValueChange(object sender, EventArgs e)
        {
            if (switchAllday.Value == true)
            {
                dtpStartDay.Enabled = false;
                dtpEndDay.Enabled = false;
                dtpEndDay.Visible = false;
                cbEndHour.Enabled = false;
                cbEndHour.Visible = false;

                if (dtpEndDay.Value != dtpStartDay.Value)
                {
                    dtpEndDay.Value = dtpStartDay.Value;
                }
            }
            else
            {
                dtpStartDay.Enabled = true;
                dtpEndDay.Enabled = true;
                dtpEndDay.Visible = true;
                cbEndHour.Enabled = true;
                cbEndHour.Visible = true;
            }
        }

        private void checkRed_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkRed.Checked = true;
            color = "Red";
            panelTitle.BackColor = Color.Red;
            switchAllday.OnColor = Color.Red;
        }
        private void setUncheckColor()
        {
            if (color == "Red") checkRed.Checked = false;
            else if (color == "Orange") checkOrange.Checked = false;
            else if (color == "Yellow") checkYellow.Checked = false;
            else if (color == "Green") checkGreen.Checked = false;
            else checkBlue.Checked = false;
        }

        private void checkOrange_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkOrange.Checked = true;
            color = "Orange";
            panelTitle.BackColor = Color.FromArgb(255, 128, 0);
            switchAllday.OnColor = Color.FromArgb(255, 128, 0);
        }

        private void checkYellow_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkYellow.Checked = true;
            color = "Yellow";
            panelTitle.BackColor = Color.Yellow;
            switchAllday.OnColor = Color.Yellow;
        }

        private void checkGreen_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkGreen.Checked = true;
            color = "Green";
            panelTitle.BackColor = Color.FromArgb(51, 205, 117);
            switchAllday.OnColor = Color.FromArgb(51, 205, 117);
        }

        private void checkBlue_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkBlue.Checked = true;
            color = "Blue";
            panelTitle.BackColor = Color.FromArgb(0, 162, 232);
            switchAllday.OnColor = Color.FromArgb(0, 162, 232);
        }
    }
}
