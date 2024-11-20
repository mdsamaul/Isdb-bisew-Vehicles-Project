namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class FareDetail
    {
        public int FareDetailsID { get; set; }
        public int VehicleTypeId { get; set; }
        public decimal UnitPrice { get; set; }

        // Navigation Property for VehicleType
        public VehicleType VehicleType { get; set; }
    }
}
