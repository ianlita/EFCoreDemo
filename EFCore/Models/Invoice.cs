using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public string InvoiceNumber { get; set; } = string.Empty;
        public string ContactName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Amount { get; set; }
        public DateTimeOffset InvoiceDate { get; set; }
        public DateTimeOffset DueDate { get; set; }
        public InvoiceStatus Status { get; set; }

        public ICollection<InvoiceItem> InvoiceItems { get; set; } = new List<InvoiceItem>();

    }
}