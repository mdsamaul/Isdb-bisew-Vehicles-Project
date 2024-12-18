﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Company : BaseEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Primary Key
        public int CompanyId { get; set; }

        [Required(ErrorMessage = "Company Name is required.")]
        [StringLength(100, ErrorMessage = "Company Name cannot exceed 100 characters.")]
        public string? CompanyName { get; set; }
    }
}
