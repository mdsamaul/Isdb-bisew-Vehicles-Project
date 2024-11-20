using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Customer Name is required.")]
        [StringLength(100, ErrorMessage = "Customer Name cannot exceed 100 characters.")]
        public string? CustomerName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email format.")]
        public string? Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "NID Number must be a positive number.")]
        public int? NID_Number { get; set; }

        [StringLength(250, ErrorMessage = "Picture path cannot exceed 250 characters.")]
        public string? Picture { get; set; }

        [Required(ErrorMessage = "Latitude is required.")]
        [Range(-90, 90, ErrorMessage = "Latitude must be between -90 and 90.")]
        public decimal Lat { get; set; }

        [Required(ErrorMessage = "Longitude is required.")]
        [Range(-180, 180, ErrorMessage = "Longitude must be between -180 and 180.")]
        public decimal Lon { get; set; }
    }
}
