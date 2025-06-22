using System.Collections.Generic;

namespace RentCars.Models
{
    public class ReportViewModel
    {
        public int ReportId { get; set; }
        public string Type { get; set; }
        public DateOnly GeneratedDate { get; set; }
        public Staff Staff { get; set; }

        public List<Rental> ConfirmedRentals { get; set; }
        public List<Rental> AvailableRentals { get; set; }
    }
}