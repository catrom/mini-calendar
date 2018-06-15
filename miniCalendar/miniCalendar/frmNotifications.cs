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
        List<Notification> notifications = new List<Notification>();
        public frmNotifications()
        {
            InitializeComponent();
        }
        public frmNotifications(List<Notification> notifications)
        {
            this.notifications = notifications;
            InitializeComponent();
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            enable = !enable;
        }

        private void DrawNotifications()
        {
            if (notifications.Count() >= 1)
                label1.Text = notifications[notifications.Count-1].text;
            if (notifications.Count() >= 2)
                label2.Text = notifications[notifications.Count-2].text;
            if (notifications.Count() >= 3)
                label3.Text = notifications[notifications.Count-3].text;
            if (notifications.Count() >= 4)
                label4.Text = notifications[notifications.Count-4].text;
            if (notifications.Count() >= 5)
                label5.Text = notifications[notifications.Count-5].text;
            if (notifications.Count() == 6)
                label6.Text = notifications[notifications.Count-6].text;
        }
    }
}