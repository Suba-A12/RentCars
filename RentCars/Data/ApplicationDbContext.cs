using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentCars.Models;

namespace RentCars.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RentCars.Models.Customer> Customer { get; set; } = default!;
        public DbSet<RentCars.Models.Staff> Staff { get; set; } = default!;
        public DbSet<RentCars.Models.Rental> Rental { get; set; } = default!;
        public DbSet<RentCars.Models.Report> Report { get; set; } = default!;
        public DbSet<RentCars.Models.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<RentCars.Models.RentalDetail> RentalDetail { get; set; } = default!;
        public DbSet<RentCars.Models.Invoice> Invoice { get; set; } = default!;
        public DbSet<RentCars.Models.Maintenance> Maintenance { get; set; } = default!;
        public DbSet<RentCars.Models.Payment> Payment { get; set; } = default!;
    }
}
