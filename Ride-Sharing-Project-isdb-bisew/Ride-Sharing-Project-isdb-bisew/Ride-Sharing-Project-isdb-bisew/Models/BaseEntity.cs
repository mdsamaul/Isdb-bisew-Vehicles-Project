using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class BaseEntity
    {
        [Required(ErrorMessage = "CreateBy field is required.")]
        [MaxLength(100, ErrorMessage = "CreateBy cannot exceed 100 characters.")]
        public string? CreateBy { get; set; }

        [Required(ErrorMessage = "CreateDate is required.")]
        public DateTime CreateDate { get; set; }

        [MaxLength(100, ErrorMessage = "UpdateBy cannot exceed 100 characters.")]
        public string? UpdateBy { get; set; }

        public DateTime? UpdateDate { get; set; }

        [Required(ErrorMessage = "IsActive field is required.")]
        public bool IsActive { get; set; }
    }
}
