using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProfileApp
{
    public class ProfileAPI
    {
        [Key]
        public int Id { get; set; }

        public string Photo { get; set; }

        [Required(ErrorMessage = "Enter firstname")]
        public string Firstname { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Description { get; set; }

        public string Website { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }
    }
}




