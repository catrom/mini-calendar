using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniCalendar
{
    public partial class frmMain : Form
    {
        DataTable dataTable = new DataTable();
        public frmMain(DataTable dataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
        }
        Bunifu.Framework.UI.Drag MoveForm = new Bunifu.Framework.UI.Drag();
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm.Grab(this);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            MoveForm.Release();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveForm.MoveObject();
        }

        private void ibtnExit_Click(object sender, EventArgs e)
        {
            dataTable.Serialize();
            Environment.Exit(0);
        }

        private void ibtnMenu_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 214)
            {
                menuPanel.Visible = false;
                menuPanel.Width = 48;
                menuTransition.ShowSync(menuPanel);
            } 
            else
            {
                menuPanel.Visible = false;
                menuPanel.Width = 214;
                menuTransition.ShowSync(menuPanel);
            }
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            frmNotifications1.BringToFront();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmSchedule1.BringToFront();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment1.BringToFront();
        }

        private void btnTodoList_Click(object sender, EventArgs e)
        {
            frmTodoList1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frmSettings1.BringToFront();
        }
    }
}
