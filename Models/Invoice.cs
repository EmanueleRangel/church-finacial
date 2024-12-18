namespace ChurchFinanceSystem.Models
{
    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }  // Valor da fatura
        public string Description { get; set; }  // Descrição da fatura
        public DateTime DateIssued { get; set; }  // Data de emissão
        public DateTime DateDue { get; set; }  // Data de vencimento
        public int CongregationId { get; set; }  // Chave estrangeira para Congregation
        public Congregation Congregation { get; set; }  // Navegação para Congregation
    }
}
