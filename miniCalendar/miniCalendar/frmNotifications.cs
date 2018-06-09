using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToastNotifications;

namespace miniCalendar
{
    public partial class frmNotifications : UserControl
    {
        bool enable = true;
        bool newNoti = false;
        DataTable dataTable = new DataTable();
        List<Notifications> notifications = new List<Notifications>();
        Appointment swap;
        int j = 0;
        public frmNotifications()
        {
            InitializeComponent();
            timer1.Start();
        }
        public frmNotifications(DataTable dataTable)
        {
            this.dataTable = dataTable;
            InitializeComponent();
            timer1.Start();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            enable = !enable;
        }

        private void CheckNotifications()
        {
            for (int i = 1; i <= dataTable.dataTable.Count - j; i++)
            {
                switch (dataTable.dataTable[i].notiUnit)
                {
                    case "minutes":
                        {
                            DateTime notiTime = dataTable.dataTable[i].startHour.AddMinutes(-(dataTable.dataTable[i].notiValue));
                            if (notiTime <= DateTime.Now)
                            {
                                notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                    dataTable.dataTable[i].endHour,
                                                                    dataTable.dataTable[i].Description));
                                newNoti = true;
                                if (notifications.Count > 6)
                                    notifications.RemoveAt(1);
                                swap = dataTable.dataTable[i];
                                dataTable.dataTable[i] = dataTable.dataTable[dataTable.dataTable.Count()];
                                dataTable.dataTable[dataTable.dataTable.Count()] = swap;
                                j++;
                            }
                            break;
                        }
                    case "hours":
                        {
                            DateTime notiTime = dataTable.dataTable[i].startHour.AddHours(-(dataTable.dataTable[i].notiValue));
                            if (notiTime <= DateTime.Now)
                            {
                                notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                    dataTable.dataTable[i].endHour,
                                                                    dataTable.dataTable[i].Description));
                                newNoti = true;
                                if (notifications.Count > 6)
                                    notifications.RemoveAt(0);
                                swap = dataTable.dataTable[i];
                                dataTable.dataTable[i] = dataTable.dataTable[dataTable.dataTable.Count];
                                dataTable.dataTable[dataTable.dataTable.Count] = swap;
                                j++;
                            }
                            break;
                        }
                    case "days":
                        {
                            DateTime notiTime = dataTable.dataTable[i].startHour.AddDays(-(dataTable.dataTable[i].notiValue));
                            if (notiTime <= DateTime.Now)
                            {
                                notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                    dataTable.dataTable[i].endHour,
                                                                    dataTable.dataTable[i].Description));
                                newNoti = true;
                                if (notifications.Count > 6)
                                    notifications.RemoveAt(1);
                                swap = dataTable.dataTable[i];
                                dataTable.dataTable[i] = dataTable.dataTable[dataTable.dataTable.Count];
                                dataTable.dataTable[dataTable.dataTable.Count] = swap;
                                j++;
                            }
                            break;
                        }
                }
            }
        }
        private void DrawNotifications()
        {
            if (notifications.Count() >= 1)
                label1.Text = notifications[notifications.Count-1].description;
            if (notifications.Count() >= 2)
                label2.Text = notifications[notifications.Count-2].description;
            if (notifications.Count() >= 3)
                label3.Text = notifications[notifications.Count-3].description;
            if (notifications.Count() >= 4)
                label4.Text = notifications[notifications.Count-4].description;
            if (notifications.Count() >= 5)
                label5.Text = notifications[notifications.Count-5].description;
            if (notifications.Count() == 6)
                label6.Text = notifications[notifications.Count-6].description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckNotifications();
            if (newNoti)
            {
                NotificationPopup toastNotification = new NotificationPopup(notifications[notifications.Count-1].startHour.ToString(), notifications[notifications.Count-1].description, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
                toastNotification.Show();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CheckNotifications();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            DrawNotifications();
            if (newNoti == true)
            {
                NotificationPopup toastNotification = new NotificationPopup(notifications[notifications.Count-1].startHour.ToString(), notifications[notifications.Count-1].description, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
                toastNotification.Show();
                newNoti = false;
            }
        }
    }
}