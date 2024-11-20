using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class VehicleType
    {
<<<<<<< HEAD
      [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
=======
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
>>>>>>> 43b394d4bca55d99403e237b05fc191cedfd6ce0
        public int VehicleTypeId { get; set; }

        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, ErrorMessage = "Name cannot exceed 255 characters.")]
        public string? VehicleName { get; set; }
    }
}
