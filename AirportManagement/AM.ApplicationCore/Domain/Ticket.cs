using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public double Price { get; set; }
        public int Seat { get; set; }
        public bool VIP { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Passenger Passenger { get; set; }
        public int FlightKey { get; set; }
        public string PassengerKey { get; set; }
    }
}
