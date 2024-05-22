using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace Project.Net.Models
{
    public class Passenger : IdentityUser
    {
        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [StringLength(7)]
        public string PassportNumber { get; set; }

        [RegularExpression("^[0 - 9]{8}$")]
        public string TelNumber { get; set; }

    }
}
