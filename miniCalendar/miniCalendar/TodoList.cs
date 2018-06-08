using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace miniCalendar
{
    [Serializable]
    public class TodoList
    {
        public Dictionary<int, Task> _todoList = new Dictionary<int, Task>();
        private XmlSerializer formatter = new XmlSerializer(typeof(Task[]), new XmlRootAttribute() { ElementName = "TodoList" });
        private string fileName = "todolist.xml";

        public TodoList() { }

        public void Add(Task o)
        {
            _todoList.Add(1, o);
        }

        public void Delete(int ID)
        {
            _todoList.Remove(ID);
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, _todoList.Select(kv => new Task()
            {
                Name = kv.Value.Name,
                DueDay = kv.Value.DueDay,
                RemindTime = kv.Value.RemindTime,
                RemindDay = kv.Value.RemindDay,
                Note = kv.Value.Note,
                Comment = kv.Value.Comment,
            }).ToArray());

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
            var result = ((Task[])formatter.Deserialize(fs))
               .Select(kv => new Task()
               {
                   Name = kv.Name,
                   DueDay = kv.DueDay,
                   RemindTime = kv.RemindTime,
                   RemindDay = kv.RemindDay,
                   Note = kv.Note,
                   Comment = kv.Comment,
               }).ToList();

            int ID = 1;

            for (int i = 0; i < result.Count; i++)
            {
                _todoList.Add(ID, result[i]);
                ++ID;
            }

            fs.Close();
        }
    }
}
