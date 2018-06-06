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
            CheckNotifications();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            enable = !enable;
        }

        private void CheckNotifications()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    for (int i = 0; i < dataTable.dataTable.Count(); i++)
                    {
                        TimeSpan notiTime = dataTable.dataTable[i].startHour.Subtract(DateTime.Now);
                        switch (dataTable.dataTable[i].notiUnit)
                        {
                            case "minutes":
                                {
                                    if (notiTime.TotalMinutes >= dataTable.dataTable[i].notiValue)
                                    {
                                        notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                           dataTable.dataTable[i].endHour,
                                                                           dataTable.dataTable[i].Description));
                                        if (notifications.Count() > 6)
                                            notifications.RemoveAt(6);
                                    }
                                    break;
                                }
                            case "hours":
                                {
                                    if (notiTime.TotalHours >= dataTable.dataTable[i].notiValue)
                                    {
                                        notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                           dataTable.dataTable[i].endHour,
                                                                           dataTable.dataTable[i].Description));
                                        if (notifications.Count() > 6)
                                            notifications.RemoveAt(6);
                                    }
                                    break;
                                }
                            case "days":
                                {
                                    if (notiTime.TotalDays >= dataTable.dataTable[i].notiValue)
                                    {
                                        notifications.Add(new Notifications(dataTable.dataTable[i].startHour,
                                                                           dataTable.dataTable[i].endHour,
                                                                           dataTable.dataTable[i].Description));
                                        if (notifications.Count() > 6)
                                            notifications.RemoveAt(6);
                                    }
                                    break;
                                }
                        }
                    }
                    await Task.Delay(60000);
                }
            });
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
    }
}