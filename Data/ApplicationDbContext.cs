using Microsoft.EntityFrameworkCore;
using ChurchFinanceSystem.Models;

namespace ChurchFinanceSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  // Representação da tabela Users
        public DbSet<Congregation> Congregations { get; set; }  // Representação da tabela Congregations
        public DbSet<Invoice> Invoices { get; set; }  // Representação da tabela Invoices
        public DbSet<InvoiceCategory> InvoiceCategories { get; set; }  // Representação da tabela InvoiceCategories

        // Configurações adicionais podem ser feitas aqui (como tabelas auxiliares ou relacionamentos)
    }
}
