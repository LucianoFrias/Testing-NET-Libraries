using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Testing_NET_Libraries.JSONReader.utils
{
    internal class JSONReader<T>
    {
        public List<T> readJson(string path)
        {
            string json = File.ReadAllText(path);
            List<T>? list = JsonSerializer.Deserialize<List<T>>(json);

            return list;
        }

    }
}
