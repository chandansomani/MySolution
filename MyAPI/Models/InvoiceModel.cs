namespace MyAPI.Models
{
    public class InvoiceModel
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public string Number { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal UPIAmount { get; set; }
        public decimal CashAmount { get; set; }
        public int CustomerId { get; set; } // Froeign Key Points to One Customer
        // public virtual Customer Customer { get; set; }
    }
}
