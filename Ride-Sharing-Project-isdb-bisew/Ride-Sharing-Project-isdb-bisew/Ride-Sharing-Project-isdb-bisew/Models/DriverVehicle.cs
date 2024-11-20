using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class DriverVehicle
    {
<<<<<<< HEAD
       [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
=======
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
>>>>>>> 43b394d4bca55d99403e237b05fc191cedfd6ce0
        public int DriverVehicleID { get; set; }

        [Required(ErrorMessage = "DriverID is required.")]
        [ForeignKey("Driver")]
        public int DriverID { get; set; }

        [Required(ErrorMessage = "Registration number is required.")]
        [StringLength(50, ErrorMessage = "Registration number cannot exceed 50 characters.")]
        public string ? DriverVehicleRegistrationNo { get; set; }

        [Required(ErrorMessage = "Chassis number is required.")]
        [StringLength(50, ErrorMessage = "Chassis number cannot exceed 50 characters.")]
        public string? DriverVehicleChassisNo { get; set; }

        [Required(ErrorMessage = "Vehicle license is required.")]
        [StringLength(50, ErrorMessage = "Vehicle license cannot exceed 50 characters.")]
        public string? DriverVehicleVehicleLicence { get; set; }

        // Navigation property
        public virtual Driver? Driver { get; set; }
    }
}
