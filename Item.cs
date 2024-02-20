using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chURL
{
    internal class Item()
    {
        public string id { get; set; } = string.Empty;
        public DateTime createdDate { get; set; }
        public Dictionary<string, string> properties { get; set; } = new Dictionary<string, string>();
        public string title { get; set; } = string.Empty;

        override public string ToString()
        {
            string d = createdDate.ToString("yyyy-MM-ddTHH:mm:ss");
            string s = $"{{ \"id\": \"{id}\", \"createdDate\": \"{d}\", \"title\": \"{title}\", ";
            string p = "\"properties\": { ";
            foreach (KeyValuePair<string, string> kvp in properties)
            {
                p += $"\"{kvp.Key}\": \"{kvp.Value}\",";
            }
            if (p.Length > 0) {
                s += p;
            }
            s += $" }}, \"title\": \"{title}\" }}";
            return s;
        }
    }
}
