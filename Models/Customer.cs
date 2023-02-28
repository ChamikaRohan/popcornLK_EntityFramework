using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace popcornLK.Models
{
    public class Customer
    {
        [Key]
        public string NIC { get; set; }
        public string C_Email { get; set; }
        public string C_Address { get; set; }
        public int C_Age { get; set; }
        public string PhoneNumber { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public ICollection<Ticket> Buys { get; set; }
    }
}
