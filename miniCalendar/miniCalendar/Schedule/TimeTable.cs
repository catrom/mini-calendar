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
        string title;
        [XmlArray]
        bool[] enableWeekDay = new bool[7] { true, true, true, true, true, true, true };
        [XmlAttribute]
        DateTime startTime;
        [XmlAttribute]
        DateTime endTime;
        [XmlArray]
        List<TimeBlock> timeBlocks;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                if (value == "") throw new Exception("Title invalid");
                else title = value;
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

        public TimeTable(string title, bool[] enableWeekDay, DateTime startTime, DateTime endTime, List<TimeBlock> timeBlocks)
        {
            if (title == "")
                throw new Exception("Title must not be blank");
            else
                this.title = title;

            this.enableWeekDay = enableWeekDay;

            if ((startTime.Hour > endTime.Hour)
                || (startTime.Hour == endTime.Hour) && (startTime.Minute >= endTime.Minute))
                throw new Exception("Start time and End time invalid");
            else
            {
                this.startTime = startTime;
                Helper.toDefaultDay(ref this.startTime);

                this.endTime = endTime;
                Helper.toDefaultDay(ref this.endTime);
            }

            this.timeBlocks = new List<TimeBlock>();
            if (timeBlocks != null)
            {
                foreach (var item in timeBlocks)
                {
                    Add(item);
                }
            }
        }

        public void Add(TimeBlock timeBlock)
        {
            if (isTimeBlockValid(timeBlock))
            {
                if (timeBlocks != null)
                {
                    foreach (var item in timeBlocks)
                    {
                        if (timeBlock.SubjectTitle == item.SubjectTitle)
                            throw new Exception("Title already taken");
                        if (timeBlock.WeekDay == item.WeekDay)
                        {

                            if (isOverlapped(timeBlock, item))
                                throw new Exception("Time frame overlapped");
                        }
                    }
                }
                timeBlocks.Add(timeBlock);
            }
            else throw new Exception("TimeBlock invalid");
        }

        public bool isTimeBlockValid(TimeBlock timeBlock)
        {
            //Check time
            if ((timeBlock.StartTime.Hour < StartTime.Hour)
                || ((timeBlock.StartTime.Hour == startTime.Hour) && (timeBlock.StartTime.Minute < startTime.Minute)))
                return false;

            if ((timeBlock.EndTime.Hour > EndTime.Hour)
                || ((timeBlock.EndTime.Hour == startTime.Hour) && (timeBlock.StartTime.Minute > startTime.Minute)))
                return false;

            //Check weekday
            if (!enableWeekDay[timeBlock.WeekDay])
                return false;

            return true;
        }

        public bool isOverlapped(TimeBlock a, TimeBlock b)
        {
            if ((a.StartTime.Hour < b.StartTime.Hour)
                || (a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute < b.StartTime.Minute))
            {
                if ((a.EndTime.Hour > b.StartTime.Hour)
                    || (a.EndTime.Hour == b.StartTime.Hour) && (a.EndTime.Minute > b.StartTime.Minute))
                    return true;
            }

            else if ((a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute == b.StartTime.Minute))
            {
                return true;
            }

            else if ((a.StartTime.Hour > b.StartTime.Hour)
                || (a.StartTime.Hour == b.StartTime.Hour) && (a.StartTime.Minute > b.StartTime.Minute))
            {
                if ((a.StartTime.Hour < b.EndTime.Hour)
                    || (a.StartTime.Hour == b.EndTime.Hour) && (a.StartTime.Minute < b.EndTime.Minute))
                    return true;
            }

            return false;
        }

        public void Remove(TimeBlock timeBlock)
        {
            timeBlocks.Remove(timeBlock);
        }

        public void Sort()
        {
            List<TimeBlock> tempTimeBlocks;
            tempTimeBlocks = TimeBlocks.OrderBy(o => o.WeekDay).ThenBy(o => o.StartTime).ToList();
            TimeBlocks = tempTimeBlocks;
        }

        public void Update()
        {
            if(timeBlocks != null)
            {
                foreach (var item in timeBlocks)
                    if (!isTimeBlockValid(item))
                        Remove(item);
            }
        }
    }
}
