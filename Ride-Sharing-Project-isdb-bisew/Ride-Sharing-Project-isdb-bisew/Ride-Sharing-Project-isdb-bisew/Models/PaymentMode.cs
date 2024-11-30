using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class PaymentMode : BaseEntity
    {
         [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int PaymentModeId { get; set; }

        [Required(ErrorMessage = "Payment Mode Name is required.")]
        [StringLength(100, ErrorMessage = "Payment Mode Name cannot exceed 100 characters.")]
        public string? Name { get; set; }
    }
}
