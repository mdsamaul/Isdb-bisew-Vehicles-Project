namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class DriverVehicle
    {
        public int DriverVehicleID { get; set; }
        public int DriverID { get; set; }
        public int RegistrationNo { get; set; }
        public int ChassisNo { get; set; }
        public int VehicleLicence { get; set; }

        // Navigation Property for Driver
        public Driver Driver { get; set; }

        // Relationship with RideTrack
        public ICollection<RideTrack> RideTracks { get; set; }
    }
}
