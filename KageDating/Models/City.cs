using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KageDating.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Range(1, 9999, ErrorMessage = "Values cannot exceed 9999 or be lower than 1")]
        public int CityId { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Names is too long... Fjong")]
        public string CityName { get; set; }
    }
}
