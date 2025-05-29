using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class Payment
    {
        [Key]
        public int PaymentId { get; set; }
        public double Amount {  get; set; }
        public DateOnly PaymentDate { get; set; }
        public string PaymentType {  get; set; }
        public int InvoiceId { get; set; }

        [ForeignKey("InvoiceId")]
        public Invoice Invoice { get; set; }
    }
}
