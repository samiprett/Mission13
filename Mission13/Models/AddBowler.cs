using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission13.Models
{
    public class AddBowler
    {
        [Key]
        [Required]
        public int BowlerID { get; set; }
        [Required(ErrorMessage = "Please enter First Name")]
        public string BowlerFirstName { get; set; }
        public ushort BowlerMiddleInit { get; set; }
        [Required(ErrorMessage = "Please enter Last Name")]
        public ushort BowlerLastName { get; set; }
        [Required(ErrorMessage = "Please enter City")]
        public string BowlerCity { get; set; }
        [Required(ErrorMessage = "Please enter State")]
        public string BowlerState { get; set; }
        [Required(ErrorMessage = "Please enter Zip")]
        public string BowlerZip { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        public string BowlerPhoneNumber { get; set; }
    }
}
