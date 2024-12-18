using ChurchFinanceSystem.Models;
using ChurchFinanceSystem.Repositories;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public IEnumerable<Invoice> GetAllInvoices()
        {
            return _invoiceRepository.GetAll();
        }

        public Invoice GetInvoiceById(int id)
        {
            return _invoiceRepository.GetById(id);
        }

        public void CreateInvoice(Invoice invoice)
        {
            _invoiceRepository.Add(invoice);
        }

        public void UpdateInvoice(Invoice invoice)
        {
            _invoiceRepository.Update(invoice);
        }

        public void DeleteInvoice(int id)
        {
            _invoiceRepository.Delete(id);
        }
    }
}
