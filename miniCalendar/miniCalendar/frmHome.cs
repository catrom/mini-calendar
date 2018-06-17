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
        monthItem myMonthCalendar = new monthItem();

        Schedule.ScheduleDataTable scDataTable = new Schedule.ScheduleDataTable();

        public frmMain(DataTable dataTable, monthItem monthItem)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.myMonthCalendar = monthItem;

            frmNotifications form = new frmNotifications();
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Add(form);
        }

        // Testing shit //
        public frmMain(Schedule.ScheduleDataTable scDataTable)
        {
            InitializeComponent();
            this.scDataTable = scDataTable;

            frmNotifications form = new frmNotifications();
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Add(form);
        }
        // ------------ //

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
            myMonthCalendar.Serialize();
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
            frmNotifications form = new frmNotifications();
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Clear();
            WorkingArea.Controls.Add(form);
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            frmSchedule form = new frmSchedule(scDataTable);
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Clear();
            WorkingArea.Controls.Add(form);
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            frmAppointment form = new frmAppointment(dataTable.dataTable, myMonthCalendar);
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Clear();
            WorkingArea.Controls.Add(form);
        }

        private void btnTodoList_Click(object sender, EventArgs e)
        {
            frmTodoList form = new frmTodoList();
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Clear();
            WorkingArea.Controls.Add(form);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            clearWorkingArea();

            frmSettings form = new frmSettings();
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Clear();
            WorkingArea.Controls.Add(form);
        }

        private void clearWorkingArea()
        {
            for (int i = WorkingArea.Controls.Count - 1; i >= 0; i--)
            {
                WorkingArea.Controls.RemoveAt(i);
            }
        }
    }
}
