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

    
    }

}
