using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class FareDetail
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int FareDetailsID { get; set; }

        [Required(ErrorMessage = "Vehicle Type ID is required.")]
        public int VehicleTyped { get; set; }

        [Required(ErrorMessage = "Unit Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Unit Price must be greater than 0.")]
        public decimal UnitPrice { get; set; }

    }
}
