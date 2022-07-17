using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Assignment_2.Models
{
    public class Fighters
    {
        [Key]
        public int FightersID { get; set; }
        [Required]
        [DisplayName("Bender Name")]
        public string BenderName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Weapon { get; set; }
        [Required]
        [DisplayName("Fighting Style")]
        public string FightingStyle { get; set; }

    }
}
