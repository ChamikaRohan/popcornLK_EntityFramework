using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace popcornLK.Models
{
    public class Genre 
    {
        [Key]
        public int Genre_ID { get; set; }
        public string Genre_Name { get; set; }
        public string Genre_Discriptionj { get; set; }
        public string Movies_Count { get; set; }
        public ICollection<Movie> BelongsTo { get; set; }
    }

}
