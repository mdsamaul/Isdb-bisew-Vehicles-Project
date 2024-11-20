using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class RideBook
    {
        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingID { get; set; }

        [Required(ErrorMessage = "DriverVehicleID is required.")]
        [ForeignKey("DriverVehicle")]
        public int DriverVehicleID { get; set; }

        [Required(ErrorMessage = "CustomerID is required.")]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "VehicleID is required.")]
        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }

        [Required(ErrorMessage = "Source Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "SourceLat must be between -90 and 90.")]
        [Column(TypeName = "decimal(9,6)")]
        public decimal SourceLat { get; set; }

        [Required(ErrorMessage = "Source Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "SourceLon must be between -180 and 180.")]
        [Column(TypeName = "decimal(9,6)")]
        public decimal SourceLon { get; set; }

        [Required(ErrorMessage = "Destination Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "DestinationLat must be between -90 and 90.")]
        [Column(TypeName = "decimal(9,6)")]
        public decimal DestinationLat { get; set; }

        [Required(ErrorMessage = "Destination Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "DestinationLon must be between -180 and 180.")]
        [Column(TypeName = "decimal(9,6)")]
        public decimal DestinationLon { get; set; }

        [Required(ErrorMessage = "Start time is required.")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "End time is required.")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "Fare is required.")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fare must be a positive value.")]
        public decimal Fare { get; set; }

        [Required]
        public bool IsPaid { get; set; }

        [Required(ErrorMessage = "Distance is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Distance must be greater than 0.")]
        public int DistanceInMeter { get; set; }

        [Range(0, 5, ErrorMessage = "DriverRating must be between 0 and 5.")]
        [Column(TypeName = "decimal(3,2)")]
        public decimal? DriverRating { get; set; }

        [Range(0, 5, ErrorMessage = "CustomerRating must be between 0 and 5.")]
        [Column(TypeName = "decimal(3,2)")]
        public decimal? CustomerRating { get; set; }

        // Navigation properties
        public virtual DriverVehicle DriverVehicle { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
