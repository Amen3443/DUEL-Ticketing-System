using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUEL_Ticketing_System
{
    internal class User
    {
        public int UniquePatronId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }  
        public string Address { get; set; }

    }
}
