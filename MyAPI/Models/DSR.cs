using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class DSR
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10)]
        public string BType { get; set; }
        public DateOnly Date { get; set; }
        public int BNo { get; set; }
        public decimal Amount { get; set; }
        public decimal CreditAmt { get; set; }
        public decimal UPIAmt { get; set;}
        public decimal CashAmt { get; set;}

    }
}
