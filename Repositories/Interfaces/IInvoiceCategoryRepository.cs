using ChurchFinanceSystem.Models;
using System.Collections.Generic;

namespace ChurchFinanceSystem.Repositories
{
    public interface IInvoiceCategoryRepository
    {
        IEnumerable<InvoiceCategory> GetAll();                // Obter todas as categorias de faturas
        InvoiceCategory GetById(int id);                       // Obter categoria por Id
        void Add(InvoiceCategory invoiceCategory);             // Adicionar uma nova categoria
        void Update(InvoiceCategory invoiceCategory);          // Atualizar uma categoria existente
        void Delete(int id);                                   // Deletar uma categoria pelo Id
    }
}
