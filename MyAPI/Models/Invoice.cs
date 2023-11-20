using MyAPI.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MyAPI.Models
{
    [Invoice_Validator]
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [EnumDataType(typeof(InvoiceType))]
        public InvoiceType InType { get; set; } = InvoiceType.Other;
        public int Number { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
        public decimal CreditAmount { get; set; }
        public decimal UPIAmount { get; set; }
        public decimal CashAmount { get; set; }
        public int CustID { get; set; }
    }

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum InvoiceType
    {
        Other = 0,
        CMP = 1,
        CMS = 2,
        CMFR = 3
    }
}
