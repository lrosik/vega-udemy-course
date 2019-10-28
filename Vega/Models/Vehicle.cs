using System.ComponentModel.DataAnnotations;

namespace Vega.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }

        [StringLength(255)]
        public string PhoneContact { get; set; }

        [StringLength(255)]
        public string EmailContact { get; set; }
    }
}