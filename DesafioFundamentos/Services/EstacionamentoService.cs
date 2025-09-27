using DesafioFundamentos.Models;

public class EstacionamentoService
{
    private Estacionamento estacionamento;
    public EstacionamentoService(Estacionamento estacionamento)
    {
        this.estacionamento = estacionamento;
    }
    public void AdicionarVeiculo(string placa)
    {
        estacionamento.veiculos.Add(placa);
    }
    public bool RemoverVeiculo(string placa, int horas, out decimal valorTotal)
    {
        placa = placa.ToUpper();
        if (estacionamento.veiculos.Any(p => p.ToUpper() == placa))
        {
            valorTotal = estacionamento.precoInicial + estacionamento.precoPorHora * horas;
            estacionamento.veiculos.RemoveAll(p => p.ToUpper() == placa);
            return true;
        }

        valorTotal = 0;
        return false;
    }
    public List<string> listarVeiculos()
    {
        return estacionamento.veiculos;
    }
    public bool placaExiste(string placa)
    {
        placa = placa.ToUpper();
        return estacionamento.veiculos.Any(v => v.ToUpper() == placa);
    }
}
