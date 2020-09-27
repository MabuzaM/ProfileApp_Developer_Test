using System.ComponentModel.DataAnnotations;

namespace ProfileApp.Models
{
    public class Profile
    {
        [Key]
        public int Id { get; set; }

        public string Photo { get; set; }

        [Required(ErrorMessage ="Enter firstname")]
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
