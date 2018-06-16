using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCalendar.Schedule
{
    public static class Helper
    {
        public static void toDefaultDay(ref DateTime dateTime)
        {
            dateTime = new DateTime(1, 1, 1, dateTime.Hour, dateTime.Minute, 0);
        }
    }
}
