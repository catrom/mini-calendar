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
        DataTable dataTable = new DataTable();
        List<Notifications> notifications = new List<Notifications>();
        public frmNotifications()
        {
            InitializeComponent();
        }
        public frmNotifications(DataTable dataTable)
        {
            this.dataTable = dataTable;
            InitializeComponent();
            Task.Run(action: () => CheckNotifications());
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            enable = !enable;
        }

        private void CheckNotifications()
        {
            while (true)
            {
                for (int i = 0; i < dataTable.dataTable.Count(); i++)
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
                                    NotificationPopup toastNotification = new NotificationPopup(notifications[i].startHour.ToString(), notifications[i].description, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
                                    toastNotification.Show();
                                    if (notifications.Count() > 6)
                                        notifications.RemoveAt(6);
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
                                    NotificationPopup toastNotification = new NotificationPopup(notifications[i].startHour.ToString(), notifications[i].description, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
                                    toastNotification.Show();
                                    if (notifications.Count() > 6)
                                        notifications.RemoveAt(6);
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
                                    NotificationPopup toastNotification = new NotificationPopup(notifications[i].startHour.ToString(), notifications[i].description, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
                                    toastNotification.Show();
                                    if (notifications.Count() > 6)
                                        notifications.RemoveAt(6);
                                }
                                break;
                            }
                    }
                    DrawNotifications();
                }
            }
        }
        private void DrawNotifications()
        {
            if (notifications.Count >= 1)
                label1.Text = notifications[1].description;
            if (notifications.Count >= 2)
                label1.Text = notifications[2].description;
            if (notifications.Count >= 3)
                label1.Text = notifications[3].description;
            if (notifications.Count >= 4)
                label1.Text = notifications[4].description;
            if (notifications.Count >= 5)
                label1.Text = notifications[5].description;
            if (notifications.Count == 6)
                label1.Text = notifications[6].description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NotificationPopup toastNotification = new NotificationPopup(dataTable.dataTable[1].startHour.ToString(), dataTable.dataTable[1].notiUnit, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
            toastNotification.Show();
            Task.Run(() => CheckNotifications());
        }
    }
}