using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Schedule
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public string CabinetNumber { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public Schedule() 
        {

        }
    }
}
