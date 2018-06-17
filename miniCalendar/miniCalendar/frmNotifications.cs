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

        private void DrawNotifications()
        {
            if (notifications.Count() >= 1)
            {
                pictureBox1.Image = notifications[notifications.Count - 1].image;
                label1.Text = notifications[notifications.Count - 1].text;
                label7.Text = notifications[notifications.Count - 1].startTime.ToString();
            }
            if (notifications.Count() >= 2)
            {
                pictureBox1.Image = notifications[notifications.Count - 2].image;
                label2.Text = notifications[notifications.Count - 2].text;
                label8.Text = notifications[notifications.Count - 2].startTime.ToString();
            }
            if (notifications.Count() >= 3)
            {
                pictureBox1.Image = notifications[notifications.Count - 3].image;
                label3.Text = notifications[notifications.Count - 3].text;
                label9.Text = notifications[notifications.Count - 3].startTime.ToString();
            }
            if (notifications.Count() >= 4)
            {
                pictureBox1.Image = notifications[notifications.Count - 4].image;
                label4.Text = notifications[notifications.Count - 4].text;
                label10.Text = notifications[notifications.Count - 4].startTime.ToString();
            }
            if (notifications.Count() >= 5)
            {
                pictureBox1.Image = notifications[notifications.Count - 5].image;
                label5.Text = notifications[notifications.Count - 5].text;
                label11.Text = notifications[notifications.Count - 5].startTime.ToString();
            }
            if (notifications.Count() == 6)
            {
                pictureBox1.Image = notifications[notifications.Count - 6].image;
                label6.Text = notifications[notifications.Count - 6].text;
                label12.Text = notifications[notifications.Count - 6].startTime.ToString();
            }
        }
    }
}