using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace popcornLK.Models
{
    public class Movie
    {
        [Key]
        public int M_ID { get; set; }
        public string M_Description { get; set; }
        public string Title { get; set; }
        public int Ratings { get; set; }
        public string three_d_or_not { get; set; }
        public string RunTime  { get; set; }
        public string Last_Name { get; set; }
        public ICollection<Ticket> Has { get; set;

    }
}
 