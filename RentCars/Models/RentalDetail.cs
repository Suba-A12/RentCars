using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class RentalDetail
    {
        [Key]
        public int RentalDetailId { get; set; }
        public int NumberOfDays { get; set; }
        public double DailyRate { get; set; }
        public int RentalId { get; set; }

        [ForeignKey("RentalId")]
        public Rental Rental { get; set; }
        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }
    }
}
