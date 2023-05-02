using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_NET_Libraries.JSONReader.car
{
    internal class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public Car(int id, string name, string brand)
        {
            Id = id;
            Name = name;
            Brand = brand;
        }
    }
}
