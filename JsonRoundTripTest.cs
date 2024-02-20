using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace chURL
{
    internal class JsonRoundTripTest
    {
        public void Test()
        {
            string json = """
[ { "id": "Idabdff0ad-e844-4829-882a-810c65f0a36b", "createdDate": "2023-12-19T15:33:47.7040435", "properties": { "key560cba7d-acc3-447f-9af6-24eae63773f3": "valuec404e3ae-49fa-4755-86a8-a1b05459de49", "key7b70261b-5e71-4a8d-92b8-c4e9d45485b7": "value2bc016a5-1840-4011-ae35-b58b8dffeffa", "key3725b5bc-7d6e-40ab-9471-63681f45a81c": "value3d5bb01d-89b1-4fdf-bab0-fd06de727177" }, "title": "Titleebc6ad4a-732e-4da3-b7c3-5611d0bd2dcb" }, { "id": "Id33274a17-4ce1-46ac-81e2-bf12b2b9d121", "createdDate": "2022-03-15T10:36:57.8019084", "properties": { "keyac52da87-7d60-4c4e-a424-92dd580eb6ff": "value9e38ddd3-8b87-44d1-a242-9d91a62c40f7", "key03a18580-3e97-4843-bbdb-1cbd9e4dca31": "valuecaa97589-e490-430c-b97f-b6c3e53082f1", "keyfd39749a-acf0-472a-a373-df2d200e033a": "value13dbe190-d174-45d5-88b4-d177b63b571b" }, "title": "Titlebf1a05cc-0deb-4f27-a1be-819634227a3e" }, { "id": "Id92a06ac3-4580-495e-b265-cef985a03331", "createdDate": "2024-06-03T01:45:15.4953351", "properties": { "keya509dd4d-7919-483d-9e0e-d80dd435c047": "value89e793c1-9c2a-4cbd-9680-95a155e98df9", "key4f8f17c5-7633-444e-a1a0-a3d671e9614c": "value2431b4f7-d281-4a50-8f81-932ab227d913", "key8f2fe537-be85-4306-bce4-5c21d86a65a2": "valuebe5703ab-3dea-4b31-b27d-0a7dc052ae71" }, "title": "Title964c1aa5-e20c-4af1-ace5-42e403c9ddd9" } ]
""";
            var itemList = SplitJsonArray(json);
            var rtjson = ListOfItemsToString(itemList!);
            Debug.Assert(json == rtjson);
        }

        private List<Item>? SplitJsonArray(string json)
        {
            if (json == null)
            {
                return null;
            }

            if (json.Length == 0)
            {
                return null;
            }

            return JsonSerializer.Deserialize<List<Item>>(json);
        }

        private string ListOfItemsToString(List<Item> itemList)
        {
            string s = string.Empty;
            if (itemList?.Count > 0)
            {
                s += "[ ";
                string l = string.Empty;
                foreach (var item in itemList)
                {
                    l += item.ToString() + ", ";
                }
                s += l.Remove(l.Length - 1) + " ]";
            }
            else
            {
                s = "[]";
            }
            return s;
        }
    }
}
