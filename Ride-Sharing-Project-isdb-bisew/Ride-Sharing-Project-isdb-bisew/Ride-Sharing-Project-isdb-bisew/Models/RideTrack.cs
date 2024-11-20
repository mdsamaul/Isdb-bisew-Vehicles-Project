namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class RideTrack
    {
        public int TrackID { get; set; }
        public int BookingID { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public double Distance { get; set; }
        public DateTime TrackTime { get; set; }

        // Navigation Property for Booking (Assuming a Booking table exists)
        public Booking Booking { get; set; }
    }
}
