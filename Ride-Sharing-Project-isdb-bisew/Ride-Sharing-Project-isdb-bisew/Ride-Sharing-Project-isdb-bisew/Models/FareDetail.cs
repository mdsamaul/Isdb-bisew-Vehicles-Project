<<<<<<< HEAD
﻿namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class FareDetail
    {
        public int FareDetailsID { get; set; }
        public int VehicleTypeId { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation Property for VehicleType
        public VehicleType VehicleType { get; set; }
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class FareDetail
    {
        [Key]
        public int FareDetailsID { get; set; }

        [Required(ErrorMessage = "Vehicle Type ID is required.")]
        public int VehicleTyped { get; set; }

        [Required(ErrorMessage = "Unit Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Unit Price must be greater than 0.")]
        public decimal UnitPrice { get; set; }

>>>>>>> 66656895b4e9e124ab3d67f8601cad35a5c1dd87
    }
}
