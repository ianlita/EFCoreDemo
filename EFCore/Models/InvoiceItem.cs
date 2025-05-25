using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class InvoiceItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Quantity { get; set; }
        public decimal Amount { get; set; }

        [JsonIgnore]
        public Invoice? Invoice { get; set; } // Navigation property to the Invoice
        public Guid InvoiceId { get; set; } // Foreign key to the Invoice

    }
}