using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Data.Configurations;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class InvoiceDbContext(DbContextOptions<InvoiceDbContext> options)
        : DbContext(options)
    {
        public DbSet<Invoice> Invoices => Set<Invoice>();
        public DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Invoice>().HasData(
            // new Invoice
            // {
            //     InvoiceId = Guid.Parse("d03342e9-cda2-4838-9fbe-98f2cd0ad2cb"),
            //     InvoiceNumber = "INV-001",
            //     ContactName = "Iron Man",
            //     Description = "Invoice for the first month",
            //     Amount = 100,
            //     InvoiceDate = new DateTimeOffset(2021, 1, 1, 0, 0, 0, TimeSpan.Zero),
            //     DueDate = new DateTimeOffset(2021, 1, 15, 0, 0, 0, TimeSpan.Zero),
            //     Status = InvoiceStatus.AwaitPayment
            // },
            // new Invoice
            // {
            //     InvoiceId = Guid.Parse("ffb2456b-14bb-4574-ba69-e2d3067f59cc"),
            //     InvoiceNumber = "INV-002",
            //     ContactName = "Captain America",

            //     Description = "Invoice for the first month",
            //     Amount = 200,
            //     InvoiceDate = new DateTimeOffset(2021, 1, 1, 0, 0, 0, TimeSpan.Zero),
            //     DueDate = new DateTimeOffset(2021, 1, 15, 0, 0, 0, TimeSpan.Zero),
            //     Status = InvoiceStatus.AwaitPayment
            // },
            // new Invoice
            // {
            //     InvoiceId = Guid.Parse("36de8af9-349d-4864-bd7e-9548f5b04e44"),
            //     InvoiceNumber = "INV-003",
            //     ContactName = "Thor",
            //     Description = "Invoice for the first month",
            //     Amount = 300,
            //     InvoiceDate = new DateTimeOffset(2021, 1, 1, 0, 0, 0, TimeSpan.Zero),
            //     DueDate = new DateTimeOffset(2021, 1, 15, 0, 0, 0, TimeSpan.Zero),
            //     Status = InvoiceStatus.Draft
            // });

            //If you have multiple entity configurations and want to apply them all from an assembly:
            //This approach uses reflection to apply all IEntityTypeConfiguration<T> implementations in the same assembly, which is helpful for large projects.
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InvoiceDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

    }

}