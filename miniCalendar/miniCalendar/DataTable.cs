using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace miniCalendar
{
    [Serializable]
    public class DataTable
    {
        private List<Appointment> dataTable = new List<Appointment>();
        private XmlSerializer formatter = new XmlSerializer(typeof(Appointment[]), new XmlRootAttribute() { ElementName = "Tasks" });
        private string fileName = "tasks.xml";

        public DataTable() { }
        
        public void Add(Appointment o)
        {
            dataTable.Add(o);
        }

        public void Delete(Appointment o)
        {
            dataTable.Remove(dataTable.Single(r => r == o));
        } 

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, dataTable.Select(kv => new Appointment() { Title = kv.Title,
                                                                                startHour = kv.startHour,
                                                                                endHour = kv.endHour,
                                                                                Location = kv.Location,
                                                                                notiValue = kv.notiValue,
                                                                                notiUnit = kv.notiUnit,
                                                                                Color = kv.Color,
                                                                                Description = kv.Description}).ToArray());

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
            var result = ((Appointment[])formatter.Deserialize(fs))
               .Select(kv => new Appointment() { Title = kv.Title,
                                               startHour = kv.startHour,
                                               endHour = kv.endHour,
                                               Location = kv.Location,
                                               notiValue = kv.notiValue,
                                               notiUnit = kv.notiUnit,
                                               Color = kv.Color,
                                               Description = kv.Description
                                           }).ToList();

            dataTable = result;

            fs.Close();
        }
    }
}
