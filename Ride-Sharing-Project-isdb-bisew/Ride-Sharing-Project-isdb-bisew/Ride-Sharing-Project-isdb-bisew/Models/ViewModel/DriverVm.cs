﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models.ViewModel
{
    public class DriverVm
    {
        [DisplayName("Driver Name")]
        public string? DriverName { get; set; }
        public string? Email { get; set; }
        [DisplayName("NId Number")]
        public int NID_Number { get; set; }
        [DisplayName("Driver License")]
        public string? DrivingLicense { get; set; }
        public string? Picture { get; set; }
        public IFormFile? PictureFile { get; set; } 
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string? CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
