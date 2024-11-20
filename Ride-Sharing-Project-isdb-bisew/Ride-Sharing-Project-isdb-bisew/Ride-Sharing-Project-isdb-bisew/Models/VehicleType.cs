using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class VehicleType
    {
      [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key

        public int VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, ErrorMessage = "Name cannot exceed 255 characters.")]
        public string? VehicleName { get; set; }
    }
}
