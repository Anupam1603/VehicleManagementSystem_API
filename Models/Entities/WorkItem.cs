using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class WorkItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, 9999999.99)]
        public decimal Cost { get; set; }
    }
}
