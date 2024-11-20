using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Vehicle
    {
      [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int VehicleID { get; set; }

        [Required(ErrorMessage = "Brand is required.")]
        [StringLength(255, ErrorMessage = "Brand cannot exceed 255 characters.")]
        public string? Brand { get; set; }

        [Required(ErrorMessage = "Model is required.")]
        [StringLength(255, ErrorMessage = "Model cannot exceed 255 characters.")]
        public string? Model { get; set; }

        [Required(ErrorMessage = "Capacity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Capacity must be at least 1.")]
        public int Capacity { get; set; }

        [Required(ErrorMessage = "Vehicle Type is required.")]
        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }

        // Navigation property for VehicleType
        public virtual VehicleType VehicleType { get; set; }
    }
}
