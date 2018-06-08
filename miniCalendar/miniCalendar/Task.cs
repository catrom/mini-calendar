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
        public Task(string name, DateTime dDay, DateTime rTime, DateTime rDay, string note, string comment)
        {
            Name = name;
            DueDay = dDay;
            RemindTime = rTime;
            RemindDay = rDay;
            Note = note;
            Comment = comment;
        }

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
        public string Comment;
    }
}
