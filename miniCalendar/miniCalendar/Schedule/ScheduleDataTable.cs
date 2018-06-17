using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;



namespace miniCalendar.Schedule
{
    [Serializable]
    public class ScheduleDataTable
    {
        public List<TimeTable> timeTables = new List<TimeTable>();

        private XmlSerializer serializer = new XmlSerializer(typeof(List<TimeTable>));
        private string fileName = "ScheduleDataTable.xml";

        public ScheduleDataTable() { }

        public void Add(TimeTable timeTable)
        {
            foreach (var item in timeTables)
                if (timeTable.Title == item.Title)
                    throw new Exception("Title already taken.");

            timeTables.Add(timeTable);
        }

        public void Remove(TimeTable timeTable)
        {
            timeTables.Remove(timeTable);
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            serializer.Serialize(fs, timeTables);
            fs.Close();
        }

        public void Deserialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);
            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }
            var result = (List<TimeTable>)serializer.Deserialize(fs);
            foreach (var i in result)
                timeTables.Add(i);
            fs.Close();
        }
    }
}
