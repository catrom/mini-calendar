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
    public class monthItem
    {
        public Dictionary<DateTime, int> colorHistory = new Dictionary<DateTime, int>(); // lưu màu khi người dùng chọn màu
        public Dictionary<DateTime, int> symbolHistory = new Dictionary<DateTime, int>();

        XmlSerializer colorSerializer = new XmlSerializer(typeof(colorItem[]),
                                 new XmlRootAttribute() { ElementName = "items" });
        XmlSerializer symbolSerializer = new XmlSerializer(typeof(symbolItem[]),
                                 new XmlRootAttribute() { ElementName = "items" });

        public monthItem() { }

        public void colorSerialize()
        {
            FileStream fs = new FileStream("colorItem.xml", FileMode.Truncate);
            colorSerializer.Serialize(fs, colorHistory.Select(kv => new colorItem() { key = kv.Key, value = kv.Value }).ToArray());

            fs.Close();
        }

        public void symbolSerialize()
        {
            FileStream fs = new FileStream("symbolItem.xml", FileMode.Truncate);
            symbolSerializer.Serialize(fs, symbolHistory.Select(kv => new symbolItem() { key = kv.Key, value = kv.Value }).ToArray());

            fs.Close();
        }

        public void Serialize()
        {
            colorSerialize();
            symbolSerialize();
        }

        public void colorDeserialize()
        {
            FileStream fs = new FileStream("colorItem.xml", FileMode.OpenOrCreate);

            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }

            var result = ((colorItem[])colorSerializer.Deserialize(fs)).ToDictionary(i => i.key, i => i.value);

            colorHistory = result;
            fs.Close();
        }

        public void symbolDeserialize()
        {
            FileStream fs = new FileStream("symbolItem.xml", FileMode.OpenOrCreate);

            if (fs.Length == 0)
            {
                fs.Close();
                return;
            }

            var result = ((symbolItem[])symbolSerializer.Deserialize(fs)).ToDictionary(i => i.key, i => i.value);

            symbolHistory = result;
            fs.Close();
        }

        public void Deserialize()
        {
            colorDeserialize();
            symbolDeserialize();
        }
    }

    public class colorItem
    {
        [XmlAttribute]
        public DateTime key;
        [XmlAttribute]
        public int value;
    }

    public class symbolItem
    {
        [XmlAttribute]
        public DateTime key;
        [XmlAttribute]
        public int value;
    }
}
