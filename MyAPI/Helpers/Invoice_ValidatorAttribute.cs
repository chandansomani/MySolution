
using MyAPI.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace MyAPI.Helpers
{
    [AttributeUsage(AttributeTargets.Class)]
    public class Invoice_ValidatorAttribute : ValidationAttribute
    {
        public Invoice_ValidatorAttribute() { }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var inv = value as Invoice;

            if (value != null)
            {
                if (inv.Amount != inv.UPIAmount + inv.CreditAmount + inv.CashAmount)
                {
                    return new ValidationResult("Incorrect Values of Amount");
                }
            }

            return ValidationResult.Success;
        }

    }
}
