using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PetType Type { get; set; }
        public float Weight { get; set; }
        public Pet(int id, string name, PetType type, float weight)
        {
            Id = id;
            Name = name;
            Type = type;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Type: {Type}, Weight: {Weight}";
        }
    }
}
