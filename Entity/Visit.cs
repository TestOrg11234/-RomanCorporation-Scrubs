using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Visit
    {
        public int ID { get; set; }
        public string NumberCard { get; set; }
        public DateTime Data { get; set; }
        public int DiagnosisID { get; set; }
        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public Visit()
        {

        }
    }
}
