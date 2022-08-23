using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }
        public Person(string name, string country, int age)
        {
            Name = name;
            Country = country;
            Age = age;
        }
    }
}
