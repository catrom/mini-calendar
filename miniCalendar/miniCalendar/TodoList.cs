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
                ID = kv.Value.ID,
                Name = kv.Value.Name,
                DueDay = kv.Value.DueDay,
                RemindTime = kv.Value.RemindTime,
                RemindDay = kv.Value.RemindDay,
                Note = kv.Value.Note,
                Color = kv.Value.Color,
                StartDay = kv.Value.StartDay
            }).ToArray());

            fs.Close();

            foreach (var i in _todoList)
            {
                string fileNameSub = i.Key.ToString() + ".xml";
                SerializeSubTask(i.Value.subTasks, fileNameSub);
            }
        }

        public void SerializeSubTask(List<string> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.Create(fileName))
            {
                serializer.Serialize(stream, list);
            }
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
                   ID = kv.ID,
                   Name = kv.Name,
                   DueDay = kv.DueDay,
                   RemindTime = kv.RemindTime,
                   RemindDay = kv.RemindDay,
                   Note = kv.Note,
                   Color = kv.Color,
                   StartDay = kv.StartDay
               }).ToList();

            fs.Close();

            foreach (var i in result)
            {
                List<string> subTask = new List<string>();
                string fileNameSub = i.ID.ToString() + ".xml";
                DeserializeSubTask(subTask, fileNameSub);
                _todoList.Add(i.ID, new Task(i.ID, i.Name, i.DueDay, i.RemindTime, i.RemindDay, i.Note, i.Color, i.StartDay, subTask));
            }
        }

        public void DeserializeSubTask(List<string> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<string>));
            FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);

            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }
            var result = ((List<string>)serializer.Deserialize(fs))
               .Select(kv => new Task()).ToList();

            fs.Close();
        }
    }
}
