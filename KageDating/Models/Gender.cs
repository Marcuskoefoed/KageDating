using System.ComponentModel.DataAnnotations;

namespace KageDating.Models
{
    public class Gender
    {
        public int GenderId { get; set; }

        [Required]
        [StringLength(100)]
        public string GenderName { get; set; }
    }
}
