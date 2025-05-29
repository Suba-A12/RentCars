using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentCars.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public string Type { get; set; }
        public DateOnly GeneratedDate { get; set; }
        public int StaffId { get; set; }

        [ForeignKey("StaffId")]
        public Staff Staff { get; set; }
    }
}
