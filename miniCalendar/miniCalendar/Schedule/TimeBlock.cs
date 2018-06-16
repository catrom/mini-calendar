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

        public string SubjectTitle
        {
            get
            {
                return subjectTitle;
            }
            set
            {
                if (value == "") throw new Exception("Subject Title invalid");
                else subjectTitle = value;
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
                if (value < 0 || value > 6) throw new Exception("Weekday invalid");
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
                if (value < 0) throw new Exception("Notification delay time invalid");
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

        public TimeBlock(string subjectTitle, int weekDay, DateTime startTime, DateTime endTime, string color, int notiUnit)
        {
            this.subjectTitle = subjectTitle;
            this.weekDay = weekDay;
            this.color = color;
            this.notiUnit = notiUnit;
            if ((startTime.Hour > endTime.Hour)
                || (startTime.Hour == endTime.Hour) && (startTime.Minute >= endTime.Hour))
                throw new Exception("Start time and End time invalid");
            else
            {
                this.startTime = startTime;
                Helper.toDefaultDay(ref this.startTime);

                this.endTime = endTime;
                Helper.toDefaultDay(ref this.endTime);
            }
        }
    }
}
