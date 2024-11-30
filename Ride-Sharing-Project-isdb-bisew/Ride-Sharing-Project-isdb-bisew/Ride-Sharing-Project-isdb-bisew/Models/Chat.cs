using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Chat : BaseEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key annotation for ChatID
        public int ChatID { get; set; }
        [Required(ErrorMessage = "Message is required.")]
        [StringLength(4000, ErrorMessage = "Message cannot be longer than 4000 characters.")]
        public string? Message { get; set; }
        [Required(ErrorMessage = "Chat Time is required.")]
        public DateTime ChatTime { get; set; }
        [Required(ErrorMessage = "Customer ID is required.")]
        [ForeignKey("Customer")] // Establishing the foreign key relationship with Customer
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Employee ID is required.")]
        [ForeignKey("Employee")] // Establishing the foreign key relationship with Employee
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Sender Type is required.")]
        [StringLength(50, ErrorMessage = "Sender Type cannot be longer than 50 characters.")]
        public string? SenderType { get; set; }
        // Navigation properties (optional if you want to load related entities)
        //todo
        //public virtual Customer? Customer { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
