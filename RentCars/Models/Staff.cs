using System.ComponentModel.DataAnnotations;

namespace RentCars.Models
{
    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string Lname { get; set; }
        public string Fname { get; set; }
        public int Phone { get; set; }
        public string Role { get; set; }
        public ICollection<Rental> Rental { get; set; }
        public ICollection<Report> Report { get; set; }
    }
}
