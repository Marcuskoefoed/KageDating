using System.ComponentModel.DataAnnotations;

namespace KageDating.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        public DateTime? DeleteDate { get; set; }

        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now;
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        public DateOnly BirthDate { get; set; }


        public string? AboutMe { get; set; }


    }
}
