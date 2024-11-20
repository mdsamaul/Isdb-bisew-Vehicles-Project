using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class InvoiceReport
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key annotation for ReportID
        public int ReportID { get; set; }
        [Required(ErrorMessage = "Invoice ID is required.")]
        [ForeignKey("Invoice")] // Foreign key relationship with Invoice
        public int InvoiceID { get; set; }
        [Required(ErrorMessage = "Customer ID is required.")]
        [ForeignKey("Customer")] // Foreign key relationship with Customer
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Booking ID is required.")]
        [ForeignKey("Booking")] // Foreign key relationship with Booking
        public int BookingID { get; set; }
        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Amount must be between 0.01 and 1,000,000.")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Payment time is required.")]
        public DateTime PaymentTime { get; set; }
        [Required(ErrorMessage = "Creation time is required.")]
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "Report date is required.")]
        public DateTime ReportDate { get; set; }
        [Required(ErrorMessage = "Month/Year is required.")]
        [StringLength(7, ErrorMessage = "Month/Year must be in the format YYYY-MM.")]
        public string? MonthYear { get; set; }
        [Required(ErrorMessage = "IsPaid status is required.")]
        public bool IsPaid { get; set; }
        [Range(0.01, 1000000, ErrorMessage = "Pending Amount must be between 0.01 and 1,000,000.")]
        public decimal PendingAmount { get; set; }
        [Required(ErrorMessage = "Report Type is required.")]
        [StringLength(50, ErrorMessage = "Report Type cannot exceed 50 characters.")]
        public string? ReportType { get; set; }
        // Navigation properties (optional if you want to load related entities)
        public virtual Invoice? Invoice { get; set; }
        //todo
        //public virtual Customer? Customer { get; set; }
        //public virtual Booking? Booking { get; set; }
    }
}
