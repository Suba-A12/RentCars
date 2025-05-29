using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class Rental
    {
        [Key]
        public int RentalId { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string BookingStatus { get; set; }
        public double EstimatedRentalCost { get; set; }
        public double Latefee { get; set; }
        public double SecurityDeposit {  get; set; }
        public double TotalAmount { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
        public int StaffId { get; set; }

        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
        public ICollection<RentalDetail> RentalDetail { get; set; }
    }
}
