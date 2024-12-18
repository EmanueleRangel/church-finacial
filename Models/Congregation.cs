namespace ChurchFinanceSystem.Models
{
    public class Congregation
    {
        public int Id { get; set; }
        public string Name { get; set; }  // Nome da congregação
        public string Address { get; set; }  // Endereço da congregação
        public string ContactEmail { get; set; }  // E-mail de contato
        public string ContactPhone { get; set; }  // Telefone de contato
    }
}
