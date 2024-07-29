using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem_API.Models.Entities
{
    public class ServiceRepresentative
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public ICollection<ServiceRecord> ServiceRecords { get; set; }
    }
}
