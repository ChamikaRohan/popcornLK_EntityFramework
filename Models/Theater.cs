using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;

namespace popcornLK.Models
{
    public class Theater
    {
        [Key]
        public int T_ID { get; set; }
        public int T_Phone_No { get; set; }
        public string T_Email { get; set; }
        public int T_Address { get; set; }
        public string T_Name { get; set; }
        public string T_Ratings { get; set; }
        public string Facilities { get; set; }
        public string T_Reviews { get; set; }
        public string Now_Showing { get; set; }
        public string Comming_Soon { get; set; }
        public string T_Location { get; set; }
 
    }
}
