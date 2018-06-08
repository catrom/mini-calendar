using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace miniCalendar.Schedule
{
    public class TimeBlock
    {
        [XmlAttribute]
        int id;
        [XmlAttribute]
        string subjectTitle;
        [XmlAttribute]
        int weekDay;
        [XmlAttribute]
        DateTime startTime;
        [XmlAttribute]
        DateTime endTime;
        [XmlAttribute]
        string color;
        [XmlAttribute]
        int notiUnit;
        [XmlAttribute]
        string description;

        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string SubjectTitle
        {
            get
            {
                return subjectTitle;
            }
            set
            {
                subjectTitle = value;
            }
        }

        public int WeekDay
        {
            get
            {
                return weekDay;
            }
            set
            {
                weekDay = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public int NotiUnit
        {
            get
            {
                return notiUnit;
            }
            set
            {
                notiUnit = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        public TimeBlock() { }

        public TimeBlock(int id, string subjectTitle, int weekDay, DateTime startTime, DateTime endTime, string color)
        {
            this.id = id;
            this.subjectTitle = subjectTitle;
            this.weekDay = weekDay;
            this.startTime = startTime;
            this.endTime = endTime;
            this.color = color;
        }

    }
}
