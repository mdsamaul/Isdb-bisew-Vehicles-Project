using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Employee
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters.")]
        public string? EmployeeName { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [StringLength(255, ErrorMessage = "Email can't be longer than 255 characters.")]
        public string? EmployeeEMail { get; set; }
        [Required(ErrorMessage = "IsLive status is required.")]
        public bool IsLive { get; set; }
    }
}
