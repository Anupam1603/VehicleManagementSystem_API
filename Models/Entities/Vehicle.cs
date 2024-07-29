using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Make { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string LicensePlate { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
    }
}
