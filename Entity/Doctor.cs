using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Doctor
    {
        public long ID { get; set; } // id doctor
        public string Login { get; set; }
        public string Password { get; set; }        
        public string EMail { get; set; }       
        public string FullName { get; set; }
        public string Spetialisation { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime EmploymentDate { get; set; } // занятость      
        public string CabinetNumber { get; set; }
        public string Shedule { get; set; } // график

        public Doctor() { }
    }
}
