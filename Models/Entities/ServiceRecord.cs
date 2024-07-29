using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class ServiceRecord
    {
        public int Id { get; set; }

        public int VehicleId { get; set; }

        public Vehicle Vehicle { get; set; }

        [Required]
        public DateTime ServiceDate { get; set; }

        [Required]
        [MaxLength(20)]
        public string Status { get; set; } // Scheduled, InProgress, Completed

        public int ServiceRepresentativeId { get; set; }

        public ServiceRepresentative ServiceRepresentative { get; set; }

        public ICollection<BillOfMaterial> BillOfMaterials { get; set; }
    }
}
