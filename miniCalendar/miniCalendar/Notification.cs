using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToastNotifications;

namespace miniCalendar
{
    public class Notification
    {
        public DateTime startTime;
        public string text;
        public Notification() { }
        public Notification(DateTime startTime, string text)
        {
            this.startTime = startTime;
            this.text = text;
        }

        public Notification(Appointment appointment)
        {
            this.startTime = appointment.startHour;
            this.text = appointment.Title;
        }

        public Notification(Task task)
        {
            this.startTime = task.RemindTime;
            this.text = task.Name;
        }

        public void DisplayNotification()
        {
            NotificationPopup toastNotification = new NotificationPopup(startTime.ToString(), text, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
            toastNotification.Show();
        }
    }
}
