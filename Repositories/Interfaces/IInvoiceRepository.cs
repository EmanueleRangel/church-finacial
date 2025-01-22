using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Repositories
{
    public interface IInvoiceRepository
    {
        IEnumerable<Invoice> GetAll();
        Invoice GetById(int id);
        void Add(Invoice invoice);
        void Update(Invoice invoice);
        void Delete(int id);
    }
}
