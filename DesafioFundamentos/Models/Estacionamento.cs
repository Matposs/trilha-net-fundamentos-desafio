namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 10;
        public decimal precoPorHora = 4;
        public List<string> veiculos { get; set; } = new List<string>();

    }
}
