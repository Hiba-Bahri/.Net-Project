using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Net.Models
{
    public class Flight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightId { get; set; }
        public string Pilot { get; set; }
        public string Airline { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }

        public DateTime EffectiveArrival { get; set; }
        public double EstimatedDuration { get; set; }

        [ForeignKey("MyPlane")]
        public int PlaneId { get; set; }
        public virtual Plane? MyPlane { get; set; }

        ICollection<Passenger>? Passengers { get; set; }
        public override string ToString()
        {
            return "La destination = " + Destination
                + " La durée = " + EstimatedDuration;
        }
    }
}
