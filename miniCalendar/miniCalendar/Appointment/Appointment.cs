using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace miniCalendar
{
    public class Appointment
    {
        public Appointment() { }

        public Appointment(string Title, DateTime startHour, DateTime endHour, string Location, 
                            int notiValue, string notiUnit, string Color, string Description)
        {
            this.Title = Title;
            this.startHour = startHour;
            this.endHour = endHour;
            this.Location = Location;
            this.notiValue = notiValue;
            this.notiUnit = notiUnit;
            this.Color = Color;
            this.Description = Description;
        }

        public DateTime NotiTime()
        {
            switch (notiUnit)
            {
                case "minutes":
                    {
                        return startHour.AddMinutes(-notiValue);
                    }
                case "hours":
                    {
                        return startHour.AddHours(-notiValue);
                    }
                case "days":
                    {
                        return startHour.AddDays(-notiValue);
                    }
            }
            return startHour;
        }

        [XmlAttribute] public string Title;
        [XmlAttribute] public DateTime startHour;
        [XmlAttribute] public DateTime endHour;
        [XmlAttribute] public string Location;
        [XmlAttribute] public int notiValue;
        [XmlAttribute] public string notiUnit;
        [XmlAttribute] public string Color;
        [XmlAttribute] public string Description;
    }
}
