using System.ComponentModel.DataAnnotations;

namespace RentCars.Models
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string LicensePlate { get; set; }
        public  string  Status { get; set; }
        public  double DailyRate { get; set; }
        public double WeeklyRate { get;set; }
        public double MonthlyRate { get; set; }
        public ICollection<RentalDetail> RentalDetail { get; set; }
        public ICollection<Maintenance> Maintenance { get; set; }
        public ICollection<CartItems> CartItems { get; set; }
    }
}
