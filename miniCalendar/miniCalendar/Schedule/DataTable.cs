using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace miniCalendar.Schedule
{
    [Serializable]
    public class DataTable
    {
        public List<TimeTable> dataTable = new List<TimeTable>();
        private XmlSerializer serializer = new XmlSerializer(typeof(List<TimeTable>));
        private string fileName = "testingSchedule.xml";

        public DataTable() { }
        
        public void Add(TimeTable o)
        {
            dataTable.Add(o);
        }

        public void Remove(TimeTable o)
        {
            dataTable.Remove(o);
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            serializer.Serialize(fs, dataTable);
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
                dataTable.Add(i);
            fs.Close();
        }
    }
}
