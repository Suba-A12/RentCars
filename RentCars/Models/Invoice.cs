using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        public DateOnly Date {  get; set; }
        public double TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int RentalId { get; set; }

        [ForeignKey("RentalId")]
        public Rental Rental { get; set; }
        public ICollection<Payment> Payment { get; set; }

    }
}
