using System.ComponentModel.DataAnnotations;

namespace WebTime10.Data.Models
{
    public class Hall
    {
        [Key] public int Id { get; set; }
        public string NameHall { get; set; }
    }
}