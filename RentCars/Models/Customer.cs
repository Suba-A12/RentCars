using System.ComponentModel.DataAnnotations;

namespace RentCars.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public string License { get; set; }
        public int Phone { get; set; }
        public ICollection<Rental> Rental { get; set; }
    }
}
