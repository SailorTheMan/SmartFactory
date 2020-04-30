using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFactory.Models
{
    class Filial
    {
        public string name { get; }
        public string country { get; }
        public string address { get; }
        public string director { get; }
        public int numberOfEmployees { get; }
        public bool function { get; }
        public float latitude { get; }
        public float longitude { get; }

        public Filial(string name, string country, string address, string director, int numberOfEmployees, bool function, 
            float latitude, float longitude)
        {
            this.name = name;
            this.country = country;
            this.address = address;
            this.director = director;
            this.numberOfEmployees = numberOfEmployees;
            this.function = function;
            this.latitude = latitude;
            this.longitude = longitude;

        }

    }
}
