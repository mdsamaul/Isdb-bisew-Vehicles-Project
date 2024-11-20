namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public string NID { get; set; }
        public string Picture { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }

        // Relationship with Booking
        public ICollection<Booking> Bookings { get; set; }
    }
}
