using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Data.Configurations
{
    public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
    {
        public void Configure(EntityTypeBuilder<Invoice> builder)
        {
            builder.ToTable("Invoices");
            builder.HasKey(i => i.Id);
            builder.Property(p => p.Id).HasColumnName("InvoiceId");
            builder.Property(p => p.InvoiceNumber).HasColumnName("InvoiceNumber").HasColumnType("varchar(32)").IsRequired();
            builder.Property(p => p.ContactName).HasColumnName("ContactName").HasMaxLength(32).IsRequired();
            builder.Property(p => p.Description).HasColumnName("Description").HasMaxLength(256);
            builder.Property(p => p.Amount).HasColumnName("Amount").HasPrecision(18, 2);
            builder.Property(p => p.InvoiceDate).HasColumnName("InvoiceDate").HasColumnType("datetimeoffset").IsRequired();
            builder.Property(p => p.DueDate).HasColumnName("DueDate").HasColumnType("datetimeoffset").IsRequired();
            builder.Property(p => p.Status).HasColumnName("Status").HasMaxLength(16).HasConversion(
                v => v.ToString(),
                v => (InvoiceStatus)Enum.Parse(typeof(InvoiceStatus), v));


        }

    }

}

//table
//column name
//column type
//is required
