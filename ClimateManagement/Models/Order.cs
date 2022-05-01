using Microsoft.AspNetCore.Identity;

namespace ClimateManagement.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string? ImageTitle { get; set; }
        public byte[]? ImageData { get; set; }
        public string Status { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public IdentityUser? Mechanic { get; set; }
    }
}
