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
        public List<DateTime> dateTime = new List<DateTime>();
        public List<int> ID = new List<int>();
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
        
        public frmNewAppointment(List<int> ID, Dictionary<int, Appointment> dataTable, List<DateTime> dateTime, bool isModified)
        {
            InitializeComponent();
            this.ID = ID;
            this.isModified = isModified;
            this.dataTable = dataTable;
            this.dateTime = dateTime;

            if (ID.Count == 1)
            {
                clListDay.Visible = false;
                var obj = dateTime[0];
                var id = ID[0];

                if (isModified == false)
                {
                    dtpStartDay.Value = new DateTime(obj.Year, obj.Month, obj.Day);
                    dtpEndDay.Value = new DateTime(obj.Year, obj.Month, obj.Day);
                    cbStartHour.SelectedIndex = 0;
                    cbEndHour.SelectedIndex = 47;
                    dtpStartDay.Value = obj;
                    dtpEndDay.Value = obj;
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
                    if (dataTable[id].Title == "")
                    {
                        tbTitle.Text = "(No Title)";
                    }
                    else
                    {
                        tbTitle.Text = dataTable[id].Title;
                    }

                    dtpStartDay.Value = dataTable[id].startHour;
                    dtpEndDay.Value = dataTable[id].endHour;
                    cbStartHour.SelectedIndex = dataTable[id].startHour.Hour * 2 + dataTable[id].startHour.Minute / 30;
                    cbEndHour.SelectedIndex = dataTable[id].endHour.Hour * 2 + dataTable[id].endHour.Minute / 30;

                    if (dataTable[id].Location == "")
                    {
                        tbLocation.Text = "Add a location";
                        tbLocation.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        tbLocation.Text = dataTable[id].Location;
                        tbLocation.ForeColor = Color.Black;
                    }

                    numNotiValue.Value = dataTable[id].notiValue;
                    cbNotiUnit.SelectedIndex = cbNotiUnit.FindStringExact(dataTable[id].notiUnit);
                    color = dataTable[id].Color;

                    if (dataTable[id].Description == "")
                    {
                        tbDescription.Text = "Add descriptions";
                        tbDescription.ForeColor = Color.DarkGray;
                    }
                    else
                    {
                        tbDescription.Text = dataTable[id].Description;
                        tbDescription.ForeColor = Color.Black;
                    }


                    if (dataTable[id].startHour.Date == dataTable[id].endHour.Date &&
                        dataTable[id].endHour.Minute == 59)
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
                    switch (dataTable[id].Color)
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
            else
            {
                dateTime.Sort();

                clListDay.Visible = true;
                dtpStartDay.Visible = false;
                dtpEndDay.Visible = false;

                for (int i = 0; i < ID.Count; i++)
                {
                    clListDay.Items.Insert(i, new DateTime(dateTime[i].Year, dateTime[i].Month, dateTime[i].Day).ToString("ddddddddd dd MMM yyyy"));
                    clListDay.SetItemChecked(i, true);
                }


                cbStartHour.SelectedIndex = 0;
                cbEndHour.SelectedIndex = 47;
                dtpStartDay.Value = dateTime[0];
                dtpEndDay.Value = dateTime[0];
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


                for (int i = 0; i < ID.Count; i++)
                {
                    if (clListDay.GetItemCheckState(i) == CheckState.Unchecked)
                    {
                        continue;
                    }

                    if (switchAllday.Value == true)
                    {
                        startHour = new DateTime(dateTime[i].Year, dateTime[i].Month, dateTime[i].Day, 0, 0, 0);
                        endHour = new DateTime(dateTime[i].Year, dateTime[i].Month, dateTime[i].Day, 23, 59, 0);
                    }
                    else
                    {
                        int X = cbStartHour.SelectedIndex;
                        int Y = cbEndHour.SelectedIndex;
                        startHour = new DateTime(dateTime[i].Year, dateTime[i].Month, dateTime[i].Day, X / 2, 30 * (X % 2), 0);
                        endHour = new DateTime(dateTime[i].Year, dateTime[i].Month, dateTime[i].Day, Y / 2, 30 * (Y % 2), 0);
                    }

                    Appointment fin = new Appointment(title, startHour, endHour, location, notiValue, notiUnit, color, description);

                    if (isModified == true)
                    {
                        dataTable[ID[i]] = fin;
                    }
                    else
                    {
                        dataTable.Add(ID[i], fin);
                    }
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
                cbEndHour.Visible = true;

                if (ID.Count == 1)
                {
                    dtpEndDay.Visible = true;
                }
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
