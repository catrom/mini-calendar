using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace miniCalendar
{
    [Serializable]
    public class TodoList
    {
        public Dictionary<int, Task> todoList = new Dictionary<int, Task>();
        private XmlSerializer formatter = new XmlSerializer(typeof(Task[]), new XmlRootAttribute() { ElementName = "TodoList" });
        private string fileName = "todoList.xml";

        public TodoList() { }

        public void Add(Task a)
        {
            todoList.Add(1, a);
        }

        public void Delete(int id)
        {
            todoList.Remove(id);
        }

        public void Serialize()
        {
            FileStream fs = new FileStream(fileName, FileMode.Truncate);
            formatter.Serialize(fs, todoList.Select(kv => new Task()
            {
                Name = kv.Value.Name,
                DueDay = kv.Value.DueDay,
                RemindTime = kv.Value.RemindTime,
                RemindDay = kv.Value.RemindDay,
                Note = kv.Value.Note,
                Comment = kv.Value.Comment
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
            var result = ((Task[])formatter.Deserialize(fs)).Select(kv => new Task()
            {
                Name = kv.Name,
                DueDay = kv.DueDay,
                RemindTime = kv.RemindTime,
                RemindDay = kv.RemindDay,
                Note = kv.Note,
                Comment = kv.Comment
            }).ToList();

            int id = 1;

            for (int i = 0; i < result.Count; i++)
            {
                todoList.Add(id, result[i]);
                ++id;

                fs.Close();
            }
        }
    }
}
