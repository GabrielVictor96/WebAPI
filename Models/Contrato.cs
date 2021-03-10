namespace WebAPI.Models
{
    public class Contrato
    {
        public int Id { get; set; }
        public string DataContratacao { get; set; }
        public string QuantidadeParcelas { get; set; }
        public string ValorFinanciado { get; set; }
        public string Prestacoes { get; set; }
    }
}
