namespace WebAPI.Models
{
    public class Prestacao
    {
        public string Contrato { get; set; }
        public string DataVencimento { get; set; }
        public string DataPagamento { get; set; }
        public string Valor { get; set; }
        public string Status { get; set; }
    }
}
