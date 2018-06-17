using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static Color ColorPicker(string color)
        {
            switch (color)
            {
                case "Red":
                    {
                        return Color.FromArgb(192, 0, 0);
                    }
                case "Orange":
                    {
                        return Color.FromArgb(255, 128, 0);
                    }
                case "Yellow":
                    {
                        return Color.FromArgb(192, 192, 0);
                    }
                case "Green":
                    {
                        return Color.FromArgb(0, 192, 0);
                    }
                case "Blue":
                    {
                        return Color.FromArgb(0, 192, 192);
                    }
            }
            return Color.Transparent;
        }
    }
}
