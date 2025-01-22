using ChurchFinanceSystem.Data;
using ChurchFinanceSystem.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ChurchFinanceSystem.Repositories
{
    public class InvoiceCategoryRepository : IInvoiceCategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceCategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obter todas as categorias de faturas
        public IEnumerable<InvoiceCategory> GetAll()
        {
            return _context.InvoiceCategories.ToList();
        }

        // Obter categoria por Id
        public InvoiceCategory GetById(int id)
        {
            return _context.InvoiceCategories.FirstOrDefault(ic => ic.Id == id);
        }

        // Adicionar uma nova categoria
        public void Add(InvoiceCategory invoiceCategory)
        {
            _context.InvoiceCategories.Add(invoiceCategory);
            _context.SaveChanges();
        }

        // Atualizar uma categoria existente
        public void Update(InvoiceCategory invoiceCategory)
        {
            _context.InvoiceCategories.Update(invoiceCategory);
            _context.SaveChanges();
        }

        // Deletar uma categoria por Id
        public void Delete(int id)
        {
            var invoiceCategory = _context.InvoiceCategories.FirstOrDefault(ic => ic.Id == id);
            if (invoiceCategory != null)
            {
                _context.InvoiceCategories.Remove(invoiceCategory);
                _context.SaveChanges();
            }
        }
    }
}
