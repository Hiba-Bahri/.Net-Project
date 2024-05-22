using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Net.Models
{
    public enum PlaneType { Boing, Airbus }
    public class Plane
    {
        [Range(0, int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }
        public virtual ICollection<Flight>? Flights { get; set; }
        public override string ToString()
        {
            return "La capacité = " + Capacity;
        }
    }
}
