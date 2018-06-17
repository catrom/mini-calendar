using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ToastNotifications;

namespace miniCalendar
{
    public class Notification
    {
        public DateTime startTime;
        public string text;
        public Bitmap image;
        public Notification(Bitmap image, DateTime startTime, string text)
        {
            this.image = image;
            this.startTime = startTime;
            this.text = text;
        }

        public Notification(Appointment appointment)
        {
            this.image = new Bitmap(@"Resources\\icons8_Planner_32.png");
            this.startTime = appointment.startHour;
            this.text = appointment.Title;
        }

        public Notification(Task task)
        {
            this.image = new Bitmap(@"Resources\\icons8_Todo_List_32.png");
            this.startTime = task.RemindTime;
            this.text = task.Name;
        }

        public Notification(Schedule.TimeBlock timeBlock)
        {
            this.image = new Bitmap(@"Resources\\icons8_Schedule_32.png");
            this.startTime = timeBlock.StartTime;
            this.text = timeBlock.SubjectTitle;
        }

        public void DisplayNotification()
        {
            NotificationPopup toastNotification = new NotificationPopup(image, startTime.ToString(), text, 10, FormAnimator.AnimationMethod.Roll, FormAnimator.AnimationDirection.Up);
            toastNotification.Show();
        }
    }
}
