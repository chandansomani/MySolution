using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyAPI.Models
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        [EnumDataType(typeof(InvoiceType))]
        public InvoiceType InType { get; set; } = InvoiceType.Other;
        public int Number { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; } 
        public decimal CredfitAmount { get; set; }
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
