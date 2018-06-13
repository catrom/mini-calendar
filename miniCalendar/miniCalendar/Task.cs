using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Drawing;

namespace miniCalendar
{
    public class Task
    {     
        public Task () { }
        public Task(int id, string name, DateTime dDay, DateTime rTime, DateTime rDay, string note, string color, DateTime sDay, List<string> subtasks)
        {
            ID = id;
            Name = name;
            DueDay = dDay;
            RemindTime = rTime;
            RemindDay = rDay;
            Note = note;
            Color = color;
            StartDay = sDay;
            subTasks = subtasks;
        }

        [XmlAttribute]
        public int ID;

        [XmlAttribute]
        public string Name;

        [XmlAttribute]
        public DateTime DueDay;

        [XmlAttribute]
        public DateTime RemindTime;

        [XmlAttribute]
        public DateTime RemindDay;

        [XmlAttribute]
        public string Note;

        [XmlAttribute]
        public string Color;

        [XmlAttribute]
        public DateTime StartDay;

        [XmlAttribute]
        public List<string> subTasks = new List<string>();
    }
} 
