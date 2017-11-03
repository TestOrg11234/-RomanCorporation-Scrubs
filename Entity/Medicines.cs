using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Medicines
    {
        public int ID { get; set; }
        public Diseases _Diagnosis { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public Medicines()
        {

        }

    }
}
