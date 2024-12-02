using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models.ViewModel
{
    public class EmployeeVm
    {
        public string? EmployeeName { get; set; }
        public string? EmployeeEMail { get; set; }
        [Required] // Field is required
        public bool IsLive { get; set; }
        public string? CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
