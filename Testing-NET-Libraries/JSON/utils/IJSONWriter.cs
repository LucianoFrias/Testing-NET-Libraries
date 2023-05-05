using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_NET_Libraries.JSON.utils
{
    internal interface IJSONWriter<T>
    {
        public abstract void writeJSONToFile(string path, T element);
    }
}
