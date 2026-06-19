using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [MaxLength(300)]
        [StringLength(250, ErrorMessage = "FirstName length must be lower or equal to 250")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(300)]
        [StringLength(250, ErrorMessage = "LastName length must be lower or equal to 250")]
        public string LastName { get; set; }
        [Key]
        public string PassportNumber { get; set; }
        [RegularExpression("^[0-9]{8}$")]
        public string TelNumber { get; set; }
        public virtual string PassengerType { get { return "Unknown passenger type"; } }
        public virtual IList<Ticket> Tickets { get; set; }
        public override string ToString()
        {
            return $"PassportNumber : {PassportNumber}, FirstName : {FirstName}, LastName : {LastName}";
        }
    }
}
