using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using Testing_NET_Libraries.JSONReader.car;
using Testing_NET_Libraries.JSONReader.utils;

namespace Testing_NET_Libraries.JSON.utils
{
    internal class JSONWriter<T>
    {
        public static void writeJSONToFile(string path, T element)
        {
            List<T> elements = JSONReader<T>.readJson(path);

            elements.Add(element);

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(elements, options);
            File.WriteAllText(path, json);

        }
    }
}
