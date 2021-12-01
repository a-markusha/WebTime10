using System.ComponentModel.DataAnnotations;

namespace WebTime10.Data.Models
{
    public class Client
    {
        [Key] public int Id { get; set; }
        public string TelephoneClient { get; set; }
    }
}