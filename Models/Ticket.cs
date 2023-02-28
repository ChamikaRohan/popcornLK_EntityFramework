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

        public string CustomerNIC { get; set; }
        public Customer Customer { get; set; }
        public int TheaterID { get; set; }
        public Theater Theater { get; set; }
        public int M_ID { get; set; }
        public Movie Movie { get; set; }
    }

}
