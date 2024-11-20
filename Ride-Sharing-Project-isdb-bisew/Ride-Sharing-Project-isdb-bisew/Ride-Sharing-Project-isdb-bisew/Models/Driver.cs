using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Driver
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int DriverId { get; set; }

        [Required(ErrorMessage = "Driver Name is required.")]
        [StringLength(100, ErrorMessage = "Driver Name cannot exceed 100 characters.")]
        public string? DriverName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email format.")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "NID Number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "NID Number must be a positive number.")]
        public int NID_Number { get; set; }

        [Required(ErrorMessage = "Driving License is required.")]
        [StringLength(50, ErrorMessage = "Driving License cannot exceed 50 characters.")]
        public string? DrivingLicense { get; set; }

        [StringLength(250, ErrorMessage = "Picture path cannot exceed 250 characters.")]
        public string? Picture { get; set; }

        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public decimal Lat { get; set; }

        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public decimal Lon { get; set; }
    }
}
