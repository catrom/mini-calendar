using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace miniCalendar
{
    public class Task
    {
        public Task() { }
        public Task(string name, DateTime dDay, DateTime rTime, DateTime rDay, string note, string comment)
        {
            _name = name;
            _dueDay = dDay;
            _remindTime = rTime;
            _remindDay = rDay;
            _note = note;
            _comment = comment;
        }

        private string _name;
        private DateTime _dueDay;
        private DateTime _remindTime;
        private DateTime _remindDay;
        //private List<String> _subTask;
        private string _note;
        private string _comment;

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