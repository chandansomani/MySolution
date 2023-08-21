using System.ComponentModel.DataAnnotations;

namespace MyAPI.Models
{
    public class DSR
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(10)]
        [Required(ErrorMessage = "Invoice Date Required")]
        public DateTime Date { get; set; }        
        public string BType { get; set; } = string.Empty;
        [Required(ErrorMessage = "Invoice Number Required")]
        public int BNo { get; set; }
        public decimal Amount { get; set; }
        public decimal CreditAmt { get; set; }
        public decimal UPIAmt { get; set;}
        public decimal CashAmt { get; set;}

    }
}
