using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCalendar.Schedule
{
    public class TimeTable
    {
        [XmlAttribute]
        int id;
        [XmlAttribute]
        string title;
        [XmlArray]
        bool[] enableWeekDay = new bool[7];
        [XmlAttribute]
        DateTime startTime;
        [XmlAttribute]
        DateTime endTime;
        [XmlArray]
        List<TimeBlock> timeBlocks;

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

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public bool[] EnableWeekDay
        {
            get
            {
                return enableWeekDay;
            }
            set
            {
                enableWeekDay = value;
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

        public List<TimeBlock> TimeBlocks
        {
            get
            {
                return timeBlocks;
            }
            set
            {
                timeBlocks = value;
            }
        }

        public TimeTable() { }

        public TimeTable(int id, string title, bool[] enableWeekDay, DateTime startTime, DateTime endTime, List<TimeBlock> timeBlocks)
        {
            this.id = id;
            this.title = title;
            this.enableWeekDay = enableWeekDay;
            this.startTime = startTime;
            this.endTime = endTime;
            this.timeBlocks = timeBlocks;
        }
    }
}
