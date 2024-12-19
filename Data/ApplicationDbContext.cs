using Microsoft.EntityFrameworkCore;
using ChurchFinanceSystem.Models;

namespace ChurchFinanceSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSet para suas entidades
        public DbSet<InvoiceCategory> InvoiceCategories { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Congregation> Congregations { get; set; }

        // Aqui você pode configurar mais aspectos, como relações ou validações
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adicionar configurações específicas, como restrições, etc.
        }
    }
}
