using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;

namespace popcornLK.Models
{
    public class Customer
    {
        [Key]
        public string NIC { get; set; }
        public string C_Email { get; set; }
        public string C_Address { get; set; }
        public int C_age { get; set; }
        public string PhoneNumber { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        public ICollection<Ticket> Buys { get; set; }
    }
}