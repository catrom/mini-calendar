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
        public Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        private XmlSerializer formatter = new XmlSerializer(typeof(Appointment[]), new XmlRootAttribute() { ElementName = "Tasks" });
        private string fileName = "tasks.xml";

        public DataTable() { }
        
        public void Add(Appointment o)
        {
            dataTable.Add(1, o);
        }

        public void Delete(int ID)
        {
            dataTable.Remove(ID);
        } 

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, dataTable.Select(kv => new Appointment() { Title = kv.Value.Title,
                                                                                startHour = kv.Value.startHour,
                                                                                endHour = kv.Value.endHour,
                                                                                Location = kv.Value.Location,
                                                                                notiValue = kv.Value.notiValue,
                                                                                notiUnit = kv.Value.notiUnit,
                                                                                Color = kv.Value.Color,
                                                                                Description = kv.Value.Description}).ToArray());

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

            int ID = 1;

            for (int i = 0; i < result.Count; i++)
            {
                dataTable.Add(ID, result[i]);
                ++ID;
            }

            fs.Close();
        }
    }
}
