using Microsoft.EntityFrameworkCore;
using VehicleManagementSystem_API.Models.Entities;

namespace VehicleManagementSystem_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceRecord> ServiceRecords { get; set; }
        public DbSet<BillOfMaterial> BillOfMaterials { get; set; }
        public DbSet<ServiceRepresentative> ServiceRepresentatives { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
    }
}
