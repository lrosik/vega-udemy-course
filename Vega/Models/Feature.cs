using System.ComponentModel.DataAnnotations;

namespace Vega.Models
{
    public class Feature
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}