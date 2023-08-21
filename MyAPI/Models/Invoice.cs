namespace MyAPI.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public InvoiceType InType { get; set; } = InvoiceType.Other;
        public int Number { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
        public decimal CredfitAmount { get; set; }
        public decimal UPIAmount { get; set; }
        public decimal CashAmount { get; set; }
    }

    public enum InvoiceType
    {
        Other = 0,
        CMP = 1,
        CMS = 2,
        CMFR = 3
    }
}
