using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class GraphicalInvoiceRepresentation
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key annotation for GraphID
        public int GraphID { get; set; }
        [Required(ErrorMessage = "Month/Year is required.")]
        [StringLength(7, ErrorMessage = "Month/Year must be in the format YYYY-MM.")]
        public string? MonthYear { get; set; }
        [Required(ErrorMessage = "Invoice Type is required.")]
        [StringLength(50, ErrorMessage = "Invoice Type cannot exceed 50 characters.")]
        public string? InvoiceType { get; set; }
        [Required(ErrorMessage = "Amount is required.")]
        [Range(0.01, 1000000, ErrorMessage = "Amount must be between 0.01 and 1,000,000.")]
        public decimal Amount { get; set; }
        [Required(ErrorMessage = "Creation time is required.")]
        public DateTime CreatedAt { get; set; }
    }
}
