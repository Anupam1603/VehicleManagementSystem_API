using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class BillOfMaterial
    {
        public int Id { get; set; }

        public int ServiceRecordId { get; set; }

        public ServiceRecord ServiceRecord { get; set; }

        public int WorkItemId { get; set; }

        public WorkItem WorkItem { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
