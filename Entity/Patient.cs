using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Patient
    {
        public long ID { get; set; } // id patient
        public string FullName { get; set; } 
        public DateTime BirthDay { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumer { get; set; }
        public int CardNumer { get; set; }
        
        public Patient() { }
    }
}
