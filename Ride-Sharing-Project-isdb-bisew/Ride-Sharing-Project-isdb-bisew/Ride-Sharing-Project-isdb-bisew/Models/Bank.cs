using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Bank
    {
      [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int BankID { get; set; }

        [Required(ErrorMessage = "Company ID is required.")]
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Account Number is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Account Number must be a positive number.")]
        public int AccountNo { get; set; }

        [Required(ErrorMessage = "Branch Name is required.")]
        [StringLength(100, ErrorMessage = "Branch Name cannot exceed 100 characters.")]
        public string? BranchName { get; set; }

    }
}
