using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class CartItems
    {
        [Key]
        public int CartId { get; set; }
        public string Username { get; set; }
        public int NoOfCars { get; set; }
        public double TotalAmout { get; set; }
        public DateOnly DateCreated { get; set; }
        public int VehicleId { get; set; }

        [ForeignKey("VehicleId")]
        public Vehicle Vehicle { get; set; }

    }
}
