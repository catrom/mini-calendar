using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace miniCalendar
{
    public partial class frmMain : Form
    {
        DateTime programStart = DateTime.Now;
        DataTable dataTable = new DataTable();
        monthItem myMonthCalendar = new monthItem();
        TodoList todoList = new TodoList();
        List<Notification> notifications = new List<Notification>();
        Schedule.ScheduleDataTable scDataTable = new Schedule.ScheduleDataTable();

        public frmMain(DataTable dataTable, monthItem monthItem, TodoList todoList, Schedule.ScheduleDataTable scDataTable)
        {
            InitializeComponent();
            this.dataTable = dataTable;
            this.myMonthCalendar = monthItem;
            this.todoList = todoList;
            this.scDataTable = scDataTable;

            frmNotifications form = new frmNotifications(notifications);
            form.Dock = DockStyle.Fill;
            WorkingArea.Controls.Add(form);
        }

        // Testing shit //
        //public frmMain(Schedule.ScheduleDataTable scDataTable)
        //{
        //    InitializeComponent();
        //    this.scDataTable = scDataTable;

        //    frmNotifications form = new frmNotifications();
        //    form.Dock = DockStyle.Fill;
        //    WorkingArea.Controls.Add(form);
        //}
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
            todoList.Serialize();
            scDataTable.Serialize();
            sysTrayIcon.Visible = false;
            Environment.Exit(0);
        }
        private void ibtnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void sysTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
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
            frmTodoList form = new frmTodoList(todoList._todoList);
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
        #region Notification Handling
        private void notiTimer_Tick(object sender, EventArgs e)
        {
            CheckNotifications();
        }

        private void CheckNotifications()
        {
            for (int i = 1; i <= dataTable.dataTable.Count; i++)
            {           
                if (dataTable[i].NotiTime().Year == DateTime.Now.Year && dataTable[i].NotiTime().Month == DateTime.Now.Month &&
                                                          dataTable[i].NotiTime().Day == DateTime.Now.Day &&
                                                          dataTable[i].NotiTime().Hour == DateTime.Now.Hour &&
                                                          dataTable[i].NotiTime().Minute == DateTime.Now.Minute &&
                                                          DateTime.Now.Second == 0)
                {
                    notifications.Add(new Notification(dataTable[i]));
                    notifications[notifications.Count - 1].DisplayNotification();
                    if (notifications.Count > 6)
                        notifications.RemoveAt(0);
                }
            }
            for (int i = 1; i <= todoList._todoList.Count; i++)
            {
                if (todoList[i].RemindTime.Year == DateTime.Now.Year && todoList[i].RemindTime.Month == DateTime.Now.Month &&
                                                                        todoList[i].RemindTime.Day == DateTime.Now.Day &&
                                                                        todoList[i].RemindTime.Hour == DateTime.Now.Hour &&
                                                                        todoList[i].RemindTime.Minute == DateTime.Now.Minute &&
                                                                        DateTime.Now.Second == 0)
                {
                    notifications.Add(new Notification(todoList[i]));
                    notifications[notifications.Count - 1].DisplayNotification();
                    if (notifications.Count > 6)
                        notifications.RemoveAt(0);
                }
            }
            for (int i = 0; i < scDataTable.timeTables.Count; i++)
                for (int j = 0; j < scDataTable.timeTables[i].TimeBlocks.Count; j++)
                {
                    DateTime notiTime = scDataTable.timeTables[i].TimeBlocks[j].StartTime.AddMinutes(-(scDataTable.timeTables[i].TimeBlocks[j].NotiValue));
                    if (scDataTable.timeTables[i].TimeBlocks[j].GetDayOfWeek() == DateTime.Now.DayOfWeek &&
                        notiTime.Hour == DateTime.Now.Hour &&
                        notiTime.Minute == DateTime.Now.Minute &&
                        DateTime.Now.Second == 0)
                    {
                        notifications.Add(new Notification(todoList[i]));
                        notifications[notifications.Count - 1].DisplayNotification();
                        if (notifications.Count > 6)
                            notifications.RemoveAt(0);
                    }
                }
        }
        #endregion //Notification Handling
    }
}
