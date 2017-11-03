using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Credential
    {
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Roles _Role { get; set; }
        public Credential()
        {

        }
    }
}
