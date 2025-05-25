using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configurations
{
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder.ToTable("InvoiceItems");
            builder.HasKey(i => i.Id);
            builder.Property(p => p.Id).HasColumnName("InvoiceItemId");
            builder.Property(p => p.Name).HasColumnName("Name").HasMaxLength(64).IsRequired();
            builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(256);
            builder.Property(p => p.UnitPrice).HasColumnName("UnitPrice").HasPrecision(18, 2).IsRequired();
            builder.Property(p => p.Quantity).HasColumnName("Quantity").HasPrecision(18, 2).IsRequired();
            builder.Property(p => p.Amount).HasColumnName("Amount").HasPrecision(18, 2).IsRequired();

            // Foreign key relationship with Invoice
            builder.HasOne(ii => ii.Invoice)
                   .WithMany(i => i.InvoiceItems)
                   .HasForeignKey(ii => ii.InvoiceId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
        
    }
}