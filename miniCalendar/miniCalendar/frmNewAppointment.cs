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
        public DateTime dateTime = new DateTime();
        public int ID;
        public bool isModified;
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
            this.ID = ID;
            this.isModified = isModified;
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
                setUncheckColor();
                changeColorBlue();

                switchAllday.Value = true;
                dtpStartDay.Enabled = false;
                dtpEndDay.Visible = false;
                cbStartHour.Visible = false;
                cbEndHour.Visible = false;
            }
            else
            {
                if (dataTable[ID].Title == "")
                {
                    tbTitle.Text = "(No Title)";
                }
                else
                {
                    tbTitle.Text = dataTable[ID].Title;
                }
                
                dtpStartDay.Value = dataTable[ID].startHour;
                dtpEndDay.Value = dataTable[ID].endHour;
                cbStartHour.SelectedIndex = dataTable[ID].startHour.Hour * 2 + dataTable[ID].startHour.Minute / 30;
                cbEndHour.SelectedIndex = dataTable[ID].endHour.Hour * 2 + dataTable[ID].endHour.Minute / 30;

                if (dataTable[ID].Location == "")
                {
                    tbLocation.Text = "Add a location";
                    tbLocation.ForeColor = Color.DarkGray;
                }
                else
                {
                    tbLocation.Text = dataTable[ID].Location;
                    tbLocation.ForeColor = Color.Black;
                }
                
                numNotiValue.Value = dataTable[ID].notiValue;
                cbNotiUnit.SelectedIndex = cbNotiUnit.FindStringExact(dataTable[ID].notiUnit);
                color = dataTable[ID].Color;

                if (dataTable[ID].Description == "")
                {
                    tbDescription.Text = "Add descriptions";
                    tbDescription.ForeColor = Color.DarkGray;
                }
                else
                {
                    tbDescription.Text = dataTable[ID].Description;
                    tbDescription.ForeColor = Color.Black;
                }


                if (dataTable[ID].startHour.Date == dataTable[ID].endHour.Date &&
                    dataTable[ID].endHour.Minute == 59)
                {
                    switchAllday.Value = true;
                    cbStartHour.Visible = false;
                    dtpEndDay.Visible = false;
                    cbEndHour.Visible = false;
                }
                else
                {
                    switchAllday.Value = false;
                    cbStartHour.Visible = true;
                    dtpEndDay.Visible = true;
                    cbEndHour.Visible = true;
                }

                setUncheckColor();
                switch (dataTable[ID].Color)
                {
                    case "Red":
                        changeColorRed();
                        break;
                    case "Orange":
                        changeColorOrange();
                        break;
                    case "Yellow":
                        changeColorYellow();
                        break;
                    case "Green":
                        changeColorGreen();
                        break;
                    case "Blue":
                        changeColorBlue();
                        break;
                }
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
                if (tbTitle.Text == "Enter Title" || tbTitle.Text == "(No Title)")
                {
                    title = "";
                }
                else
                {
                    title = tbTitle.Text;
                }

                if (tbLocation.Text == "Add a location")
                {
                    location = "";
                }
                else
                {
                    location = tbLocation.Text;
                }

                if (tbDescription.Text == "Add descriptions")
                {
                    description = "";
                } 
                else
                {
                    description = tbDescription.Text;
                }

                notiValue = Convert.ToInt32(numNotiValue.Value);
                notiUnit = cbNotiUnit.Text;
                

                if (switchAllday.Value == true)
                {
                    startHour = new DateTime(dtpStartDay.Value.Year, dtpStartDay.Value.Month, dtpStartDay.Value.Day, 0, 0, 0);
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


                Dispose();

            }
        }

        public void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
        
        public void switchAllday_OnValueChange(object sender, EventArgs e)
        {
            if (switchAllday.Value == true)
            {
                dtpStartDay.Enabled = false;
                dtpEndDay.Visible = false;
                cbStartHour.Visible = false;
                cbEndHour.Visible = false;

                if (dtpEndDay.Value != dtpStartDay.Value)
                {
                    dtpEndDay.Value = dtpStartDay.Value;
                }
            }
            else
            {
                dtpStartDay.Enabled = true;
                cbStartHour.Visible = true;
                dtpEndDay.Visible = true;
                cbEndHour.Visible = true;
            }
        }

        public void changeColorRed()
        {
            setUncheckColor();
            checkRed.Checked = true;
            color = "Red";
            panelTitle.BackColor = Color.FromArgb(192, 0, 0);
            switchAllday.OnColor = Color.FromArgb(192, 0, 0);
        }

        public void changeColorOrange()
        {
            setUncheckColor();
            checkOrange.Checked = true;
            color = "Orange";
            panelTitle.BackColor = Color.FromArgb(255, 128, 0);
            switchAllday.OnColor = Color.FromArgb(255, 128, 0);
        }

        public void changeColorYellow()
        {
            setUncheckColor();
            checkYellow.Checked = true;
            color = "Yellow";
            panelTitle.BackColor = Color.FromArgb(192, 192, 0);
            switchAllday.OnColor = Color.FromArgb(192, 192, 0);
        }

        public void changeColorGreen()
        {
            setUncheckColor();
            checkGreen.Checked = true;
            color = "Green";
            panelTitle.BackColor = Color.FromArgb(0, 192, 0);
            switchAllday.OnColor = Color.FromArgb(0, 192, 0);
        }

        public void changeColorBlue()
        {
            setUncheckColor();
            checkBlue.Checked = true;
            color = "Blue";
            panelTitle.BackColor = Color.FromArgb(0, 192, 192);
            switchAllday.OnColor = Color.FromArgb(0, 192, 192);
        }

        public void setUncheckColor()
        {
            if (color == "Red") checkRed.Checked = false;
            else if (color == "Orange") checkOrange.Checked = false;
            else if (color == "Yellow") checkYellow.Checked = false;
            else if (color == "Green") checkGreen.Checked = false;
            else checkBlue.Checked = false;
        }

        public void checkRed_OnChange(object sender, EventArgs e)
        {
            changeColorRed();
        }
        

        public void checkOrange_OnChange(object sender, EventArgs e)
        {
            changeColorOrange();
        }

        public void checkYellow_OnChange(object sender, EventArgs e)
        {
            changeColorYellow();
        }

        public void checkGreen_OnChange(object sender, EventArgs e)
        {
            changeColorGreen();
        }

        public void checkBlue_OnChange(object sender, EventArgs e)
        {
            changeColorBlue();
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            dataTable.Remove(ID);
            this.Dispose();
        }

        //
        // For UX
        //
        //

        private void tbTitle_Enter(object sender, EventArgs e)
        {
            if (tbTitle.Text == "Enter Title")
            {
                tbTitle.ForeColor = Color.DarkGray;
            }
        }

        private void tbTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbTitle.Text == "Enter Title")
            {
                tbTitle.Text = "";
            }

            tbTitle.ForeColor = Color.White;
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            string title = tbTitle.Text.Replace(" ", string.Empty);
            if (title == "" || tbTitle.Text == "Enter Title")
            {
                tbTitle.Text = "Enter Title";
                tbTitle.ForeColor = Color.White;
            }
        }

        private void tbLocation_Enter(object sender, EventArgs e)
        {

        }

        private void tbLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbLocation.Text == "Add a location")
            {
                tbLocation.Text = "";
            }
            tbLocation.ForeColor = Color.Black;
        }

        private void tbLocation_Leave(object sender, EventArgs e)
        {
            if (tbLocation.Text == "" || tbLocation.Text == "Add a location")
            {
                tbLocation.Text = "Add a location";
                tbLocation.ForeColor = Color.DarkGray;
            }
        }

        private void tbDescription_Enter(object sender, EventArgs e)
        {

        }

        private void tbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbDescription.Text == "Add descriptions")
            {
                tbDescription.Text = "";
            }
            tbDescription.ForeColor = Color.Black;
        }

        private void tbDescription_Leave(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || tbDescription.Text == "Add descriptions")
            {
                tbDescription.Text = "Add descriptions";
                tbDescription.ForeColor = Color.DarkGray;
            }
        }
    }
}
