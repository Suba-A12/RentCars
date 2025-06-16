namespace RentCars.Models
{
    public class InvoiceView
    {
        public int  InvoiceId { get; set; }
        public int  CustomerId { get; set; }
        public string Email { get; set; }
        public DateOnly Date { get; set; }
        public double TotalAmount { get; set; }
        public string PaymentStatus { get; set; }
        public int RentalId { get; set; }
    }
}
