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

    /// <summary>
    /// Dictionary<int, Appointment> dataTable -> danh sách các appointment theo ID
    /// Serialize và Deserialize dataTable
    /// </summary>
    public class DataTable
    {
        public Dictionary<int, Appointment> dataTable = new Dictionary<int, Appointment>();
        private XmlSerializer formatter = new XmlSerializer(typeof(Appointment[]), new XmlRootAttribute() { ElementName = "Tasks" });
        private string fileName = "Data/Appointment/tasks.xml";

        public DataTable() { }

        public void Add(Appointment o)
        {
            dataTable.Add(1, o);
        }

        public void Delete(int ID)
        {
            dataTable.Remove(ID);
        }

        public Appointment this[int i]
        {
            get { return dataTable[i]; }
            set { dataTable[i] = value; }
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


            // Mỗi appointment khi lưu xuống bộ nhớ sẽ không cần ID, 
            // tuy nhiên khi truy xuất và làm việc thì cần có ID để dễ dàng cho việc thêm, xoá, sửa một appointment
            // Đoạn code sau thực hiện việc lấy ID tự động theo thứ tự tăng dần
            // cho mỗi appointment và add vào dataTable trong lúc deserialize.
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
