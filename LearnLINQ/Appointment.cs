using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLINQ
{
    internal class Appointment
    {
        public int Id { get; set; } 
        public DateTime Time { get; set; }
        public int PetID { get; set; }

        public Appointment(int id, DateTime time, int petID)
        {
            Id = id;
            Time = time;
            PetID = petID;
        }
    }
}
