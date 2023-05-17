using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Airline { get; set; }
        public int FlightId { get; set; }

        [ForeignKey("Plane")]
        public virtual int PlaneId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
    
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }

        public virtual Plane plane { get; set; }

        public virtual IList<Passenger> Passengers { get; set; }
        public virtual IList<Ticket> Tickets { get; set; }

    }
}
