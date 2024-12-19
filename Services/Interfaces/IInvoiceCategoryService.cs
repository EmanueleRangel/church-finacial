using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Services
{
    public interface IInvoiceCategoryService
    {
        IEnumerable<InvoiceCategory> GetAllInvoiceCategories();  // Obter todas as categorias
        InvoiceCategory GetInvoiceCategoryById(int id);          // Obter categoria por Id
        void CreateInvoiceCategory(InvoiceCategory invoiceCategory); // Criar uma nova categoria
        void UpdateInvoiceCategory(InvoiceCategory invoiceCategory); // Atualizar uma categoria
        void DeleteInvoiceCategory(int id);                       // Deletar uma categoria
    }
}
