using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public interface IInvoiceService
    {
        IEnumerable<Invoice> GetAllInvoices();
        Invoice GetInvoiceById(int id);
        void CreateInvoice(Invoice invoice);
        void UpdateInvoice(Invoice invoice);
        void DeleteInvoice(int id);
    }
}
