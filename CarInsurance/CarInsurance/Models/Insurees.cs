using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insurees
    {
        public Guid Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string? EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateOnly DateOfBirth { get; set; }
        public int CarYear { get; set; }
        public string? CarMake { get; set; }
        public string? CarModel { get; set; }
        public bool DUI { get; set; }
        public int SpeedingTickets { get; set; }
        public bool CoverageType { get; set; }
        public decimal Quote { get; set; }
    }
}
