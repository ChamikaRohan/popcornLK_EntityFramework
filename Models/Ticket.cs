using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace popcornLK.Models
{
    public class Ticket
    {
        [Key]
        public int T_ID { get; set; }
        public string Seat_No { get; set; }
        public string Ticket_Type { get; set; }

        // Foreign key property for the CUSTOMER entity
        public string CustomerNIC { get; set; }

        // Navigation property for the CUSTOMER entity
        public Customer Customer { get; set; }

        // Foreign key property for the THEATER entity
    }

}
