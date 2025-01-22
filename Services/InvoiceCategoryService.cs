using ChurchFinanceSystem.Models;
using ChurchFinanceSystem.Repositories;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public class InvoiceCategoryService : IInvoiceCategoryService
    {
        private readonly IInvoiceCategoryRepository _invoiceCategoryRepository;

        public InvoiceCategoryService(IInvoiceCategoryRepository invoiceCategoryRepository)
        {
            _invoiceCategoryRepository = invoiceCategoryRepository;
        }

        // Obter todas as categorias de faturas
        public IEnumerable<InvoiceCategory> GetAllInvoiceCategories()
        {
            return _invoiceCategoryRepository.GetAll();
        }

        // Obter uma categoria de fatura por Id
        public InvoiceCategory GetInvoiceCategoryById(int id)
        {
            return _invoiceCategoryRepository.GetById(id);
        }

        // Criar uma nova categoria de fatura
        public void CreateInvoiceCategory(InvoiceCategory invoiceCategory)
        {
            _invoiceCategoryRepository.Add(invoiceCategory);
        }

        // Atualizar uma categoria de fatura
        public void UpdateInvoiceCategory(InvoiceCategory invoiceCategory)
        {
            _invoiceCategoryRepository.Update(invoiceCategory);
        }

        // Deletar uma categoria de fatura por Id
        public void DeleteInvoiceCategory(int id)
        {
            _invoiceCategoryRepository.Delete(id);
        }
    }
}
