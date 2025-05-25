using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUEL_Ticketing_System
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string Seat_Num { get; set; }
        public string UniquePatronNumber { get; set; }
        public DateTime TDateTime { get; set; }
        public int Price{ get; set; }


    }
}
