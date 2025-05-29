using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class Maintenance
    {
        [Key]
        public int MaintenanceId { get; set; }
        public string Description { get; set; }
        public DateOnly Date {  get; set; }
        public double Cost { get; set; }
        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }
    }
}
