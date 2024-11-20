using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required(ErrorMessage = "Payment Time is required.")]
        public DateTime PaymentTime { get; set; }

        [Required(ErrorMessage = "Particular is required.")]
        [StringLength(100, ErrorMessage = "Particular cannot exceed 100 characters.")]
        public string? Particular { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, float.MaxValue, ErrorMessage = "Amount must be greater than 0.")]
        public float Amount { get; set; }

        [Required(ErrorMessage = "Customer ID is required.")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Payment Mode ID is required.")]
        public int PaymentModeId { get; set; }

        [Required(ErrorMessage = "Booking ID is required.")]
        public int BookingID { get; set; }

    }
}
