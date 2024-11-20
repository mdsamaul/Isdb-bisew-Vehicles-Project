<<<<<<< HEAD
﻿namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class RideTrack
    {
        public int TrackID { get; set; }
        public int BookingID { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Distance { get; set; }
        public DateTime TrackTime { get; set; }

        // Navigation Property for Booking (Assuming a Booking table exists)
        public Booking Booking { get; set; }
=======
﻿using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class RideTrack
    {
        [Key]
        public int TrackID { get; set; }

        [Required(ErrorMessage = "Booking ID is required.")]
        public int BookingID { get; set; }

        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public decimal Lat { get; set; }

        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public decimal Lon { get; set; }

        [Required(ErrorMessage = "Distance is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Distance must be a positive value.")]
        public decimal Distance { get; set; }

        [Required(ErrorMessage = "Track Time is required.")]
        public DateTime TrackTime { get; set; }
>>>>>>> 66656895b4e9e124ab3d67f8601cad35a5c1dd87
    }
}
