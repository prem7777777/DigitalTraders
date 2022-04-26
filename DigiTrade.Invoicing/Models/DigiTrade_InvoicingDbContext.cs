using Microsoft.EntityFrameworkCore;
namespace DigiTrade.Invoicing.Models
{
    public class DigiTrade_InvoicingDbContext : DbContext
    {
        public DigiTrade_InvoicingDbContext(DbContextOptions<DigiTrade_InvoicingDbContext> options) : base(options)
        {
        }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesInvoice> SalesInvoices { get; set; }
    }

}
