namespace ChurchFinanceSystem.Models
{
    public class InvoiceCategory
    {
        public int Id { get; set; }            // Id da categoria
        public string Name { get; set; }       // Nome da categoria (ex: "Doações", "Despesas", etc.)
        public string Description { get; set; } // Descrição opcional da categoria
    }
}
