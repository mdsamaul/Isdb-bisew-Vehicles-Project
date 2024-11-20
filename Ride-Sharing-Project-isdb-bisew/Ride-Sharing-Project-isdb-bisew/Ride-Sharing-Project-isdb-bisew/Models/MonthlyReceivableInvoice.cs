using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class MonthlyReceivableInvoice
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key annotation for ReportID
        public int ReportID { get; set; }
        [Required(ErrorMessage = "Month/Year is required.")]
        [StringLength(7, ErrorMessage = "Month/Year must be in the format YYYY-MM.")]
        public string? MonthYear { get; set; }
        [Required(ErrorMessage = "Total Amount is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Total Amount must be between 0.01 and 1,000,000.")]
        public decimal TotalAmount { get; set; }
        [Required(ErrorMessage = "Total Paid amount is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Total Paid must be between 0.01 and 1,000,000.")]
        public decimal TotalPaid { get; set; }
        [Required(ErrorMessage = "Total Pending amount is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Total Pending must be between 0.01 and 1,000,000.")]
        public decimal TotalPending { get; set; }
        [Required(ErrorMessage = "Total Invoices count is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Total Invoices must be a non-negative integer.")]
        public int TotalInvoices { get; set; }
        [Required(ErrorMessage = "Creation time is required.")]
        public DateTime CreatedAt { get; set; }
    }
}
