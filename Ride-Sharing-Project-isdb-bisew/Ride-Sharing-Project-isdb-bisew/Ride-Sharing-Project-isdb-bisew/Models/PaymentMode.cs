using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class PaymentMode
    {
        [Key]
        public int PaymentModeId { get; set; }

        [Required(ErrorMessage = "Payment Mode Name is required.")]
        [StringLength(100, ErrorMessage = "Payment Mode Name cannot exceed 100 characters.")]
        public string? Name { get; set; }
    }
}
