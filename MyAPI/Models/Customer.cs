using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public decimal OpeningBalance { get; set; } = decimal.Zero;        
    }
}
