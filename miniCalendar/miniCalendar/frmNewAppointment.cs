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
        public Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        public bool isModified;
        public DateTime dateTime = new DateTime();
        public int ID;
        public string title = "";
        public DateTime startHour;
        public DateTime endHour;
        public string location = "";
        public int notiValue;
        public string notiUnit;
        public string color = "Blue";
        public string description = "";

        public frmNewAppointment()
        {
            InitializeComponent();
        }
        public frmNewAppointment(int ID, Dictionary<int, Appointment> dataTable, DateTime dateTime, bool isModified)
        {
            InitializeComponent();
            this.isModified = isModified;
            this.ID = ID;
            this.dataTable = dataTable;
            this.dateTime = dateTime;

            if (isModified == false)
            {
                dtpStartDay.Value = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
                dtpEndDay.Value = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
                cbStartHour.SelectedIndex = 0;
                cbEndHour.SelectedIndex = 47;
                dtpStartDay.Value = dateTime;
                dtpEndDay.Value = dateTime;
                numNotiValue.Value = 30;
                cbNotiUnit.SelectedIndex = 0;
                

                //foreach (Control i in this.Controls)
                //{
                //    i.Enabled = true;
                //}

                //btnModify.Visible = false;
                //btnDelete.Visible = false;
            }
            else
            {
                tbTitle.Text = dataTable[ID].Title;
                dtpStartDay.Value = dataTable[ID].startHour;
                dtpEndDay.Value = dataTable[ID].endHour;
                cbStartHour.SelectedIndex = dataTable[ID].startHour.Hour * 2 + dataTable[ID].startHour.Minute / 30;
                cbEndHour.SelectedIndex = dataTable[ID].endHour.Hour * 2 + dataTable[ID].endHour.Minute / 30;
                tbLocation.Text = dataTable[ID].Location;
                numNotiValue.Value = dataTable[ID].notiValue;
                cbNotiUnit.SelectedIndex = cbNotiUnit.FindStringExact(dataTable[ID].Title);
                tbDescription.Text = dataTable[ID].Description;

                //foreach (Control i in this.Controls)
                //{
                //    i.Enabled = false;
                //}

                //btnModify.Enabled = true;
                ////btnSave.Visible = false;
                //btnDelete.Visible = false;
                //btnCancel.Visible = false;

            }
            
        }


        public void btnSave_Click(object sender, EventArgs e)
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

                

                Appointment fin = new Appointment(title, startHour, endHour, location, notiValue, notiUnit, color, description);


                if (isModified == true)
                {
                    dataTable[ID] = fin;
                }
                else
                {
                    dataTable.Add(ID, fin);
                }
                
                
                this.Dispose();
            }
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose(false);

        }
        
        public void switchAllday_OnValueChange(object sender, EventArgs e)
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

        public void checkRed_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkRed.Checked = true;
            color = "Red";
            panelTitle.BackColor = Color.FromArgb(192, 0, 0);
            switchAllday.OnColor = Color.FromArgb(192, 0, 0);
        }
        public void setUncheckColor()
        {
            if (color == "Red") checkRed.Checked = false;
            else if (color == "Orange") checkOrange.Checked = false;
            else if (color == "Yellow") checkYellow.Checked = false;
            else if (color == "Green") checkGreen.Checked = false;
            else checkBlue.Checked = false;
        }

        public void checkOrange_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkOrange.Checked = true;
            color = "Orange";
            panelTitle.BackColor = Color.FromArgb(255, 128, 0);
            switchAllday.OnColor = Color.FromArgb(255, 128, 0);
        }

        public void checkYellow_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkYellow.Checked = true;
            color = "Yellow";
            panelTitle.BackColor = Color.FromArgb(192, 192, 0);
            switchAllday.OnColor = Color.FromArgb(192, 192, 0);
        }

        public void checkGreen_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkGreen.Checked = true;
            color = "Green";
            panelTitle.BackColor = Color.FromArgb(0, 192, 0);
            switchAllday.OnColor = Color.FromArgb(0, 192, 0);
        }

        public void checkBlue_OnChange(object sender, EventArgs e)
        {
            setUncheckColor();
            checkBlue.Checked = true;
            color = "Blue";
            panelTitle.BackColor = Color.FromArgb(0, 192, 192);
            switchAllday.OnColor = Color.FromArgb(0, 192, 192);
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            dataTable.Remove(ID);
            this.Dispose();
        }
    }
}
