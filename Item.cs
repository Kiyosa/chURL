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
        public string createdDate { get; set; } = string.Empty;
        public Dictionary<string, string> properties { get; set; } = new Dictionary<string, string>();
        public string title { get; set; } = string.Empty;

        override public string ToString()
        {
            // string d = createdDate.ToString("yyyy-MM-ddTHH:mm:ss."); // DateTime loses fidelity of decimal seconds
            string s = $"{{ \"id\": \"{id}\", \"createdDate\": \"{createdDate}\", ";
            string p = "\"properties\": { ";
            foreach (KeyValuePair<string, string> kvp in properties)
            {
                p += $"\"{kvp.Key}\": \"{kvp.Value}\", ";
            }
            if (p.Length > 0) {
                s += p.Remove(p.Length - 2);
            }
            s += $" }}, \"title\": \"{title}\" }}";
            return s;
        }
    }
}
