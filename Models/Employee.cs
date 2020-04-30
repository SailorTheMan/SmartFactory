using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.Windows.Documents.Spreadsheet.Expressions.Functions;

namespace SmartFactory.Models
{
    class Employee
    {
        public string name { get; set; }
        public string country { get; set; }
        public int age { get; set; }
        public string sex { get; set; }
        public string position { get; set; }
        public int exp { get; set; }
        public string address { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }

        public Employee(string country, string name, int age, string sex, string position, int exp, string address, 
            float latitude, float longitude)
        {
            this.country = country;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.position = position;
            this.exp = exp;
            this.address = address;
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
