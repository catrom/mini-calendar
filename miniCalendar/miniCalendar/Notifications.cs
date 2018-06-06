using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCalendar
{
    class Notifications
    {
        public DateTime startHour, endHour;
        public string description;
        public Notifications(DateTime startHour, DateTime endHour, string description)
        {
            this.startHour = startHour;
            this.endHour = endHour;
            this.description = description;
        }
    }
}
