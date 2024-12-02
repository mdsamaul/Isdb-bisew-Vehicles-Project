using System.ComponentModel.DataAnnotations;

namespace Ride_Sharing_Project_isdb_bisew.Models.ViewModel
{
    public class RideTrackVm
    {
        public int TrackID { get; set; }
        public int BookingID { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public decimal Distance { get; set; }
        public DateTime TrackTime { get; set; }
    }
}
