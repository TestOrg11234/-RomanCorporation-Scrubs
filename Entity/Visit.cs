using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Visit
    {
        public long ID { get; set; }
        public string NumberCard { get; set; }
        public DateTime Data { get; set; }
        public long DiagnosisID { get; set; }
        public long PatientID { get; set; }
        public long DoctorID { get; set; }
    }
}
