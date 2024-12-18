using ChurchFinanceSystem.Data;
using ChurchFinanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ChurchFinanceSystem.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        private InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices.Include(i => i.Congregation).ToList();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices.Include(i => i.Congregation).FirstOrDefault(i => i.Id == id);
        }

        public void Add(Invoice invoice)
        {
            _context.Invoices.Add(invoice);
            _context.SaveChanges();
        }

        public void Update(Invoice invoice)
        {
            _context.Invoices.Update(invoice);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var invoice = _context.Invoices.FirstOrDefault(i => i.Id == id);
            if (invoice != null)
            {
                _context.Invoices.Remove(invoice);
                _context.SaveChanges();
            }
        }
    }
}
