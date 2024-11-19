namespace Ride_Sharing_Project_isdb_bisew.Models
{
    public class Invoice
    {
        public int InvoiceId { get; set; }
        public DateTime PaymentTime { get; set; }
        public float Amount{get; set;}
        public int CustomerId { get; set;}
    }
}
