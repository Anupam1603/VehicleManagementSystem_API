using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string ContactNumber { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }
    }
}
