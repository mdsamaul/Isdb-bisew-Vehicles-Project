using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Employee : BaseEntity
    {
       [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
    public int EmployeeID { get; set; }
    [Required(ErrorMessage = "Name is required.")] // Field is required
    [StringLength(255, ErrorMessage = "Name can't be longer than 255 characters.")] // Max length validation
    public string? EmployeeName { get; set; }
    [Required(ErrorMessage = "Email is required.")] // Field is required
    [EmailAddress(ErrorMessage = "Invalid Email Address.")] // Email validation
    [StringLength(255, ErrorMessage = "Email can't be longer than 255 characters.")] // Max length validation
    public string? EmployeeEMail { get; set; }
    [Required] // Field is required
    public bool IsLive { get; set; }
    }
}
