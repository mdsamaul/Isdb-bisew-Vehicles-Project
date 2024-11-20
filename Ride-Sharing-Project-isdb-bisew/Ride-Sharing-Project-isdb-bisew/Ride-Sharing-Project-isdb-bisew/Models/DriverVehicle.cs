<<<<<<< HEAD
﻿namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class DriverVehicle
    {
        public int DriverVehicleID { get; set; }
        public int DriverID { get; set; }
        public int RegistrationNo { get; set; }
        public int ChassisNo { get; set; }
        public int VehicleLicence { get; set; }

        // Navigation Property for Driver
        public Driver Driver { get; set; }

        // Relationship with RideTrack
        public ICollection<RideTrack> RideTracks { get; set; }
=======
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class DriverVehicle
    {
        [Key]
        public int DriverVehicleID { get; set; }

        [Required(ErrorMessage = "DriverID is required.")]
        [ForeignKey("Driver")]
        public int DriverID { get; set; }

        [Required(ErrorMessage = "Registration number is required.")]
        [StringLength(50, ErrorMessage = "Registration number cannot exceed 50 characters.")]
        public string ?RegistrationNo { get; set; }

        [Required(ErrorMessage = "Chassis number is required.")]
        [StringLength(50, ErrorMessage = "Chassis number cannot exceed 50 characters.")]
        public string? ChassisNo { get; set; }

        [Required(ErrorMessage = "Vehicle license is required.")]
        [StringLength(50, ErrorMessage = "Vehicle license cannot exceed 50 characters.")]
        public string? VehicleLicence { get; set; }

        // Navigation property
        public virtual Driver? Driver { get; set; }
>>>>>>> 66656895b4e9e124ab3d67f8601cad35a5c1dd87
    }
}
