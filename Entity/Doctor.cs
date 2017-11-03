using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Doctor
    {
        public int ID { get; set; } // id doctor
        public string FullName { get; set; }
        public  Spetialisations Spetialisation { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime EmploymentDate { get; set; } // занятость      
        public int CabinetNumber { get; set; }
        public Schedule _Schedule { get; set; } // график

        public Doctor()
        {

        }
    }
}
