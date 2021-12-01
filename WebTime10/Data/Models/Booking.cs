using System.ComponentModel.DataAnnotations;

namespace WebTime10.Data.Models
{
    public class Booking
    {
        [Key] public int Id { get; set; }
        public Client Client { get; set; }
        public TimeTable TimeTable { get; set; }
    }
}