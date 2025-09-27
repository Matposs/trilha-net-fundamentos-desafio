using DesafioFundamentos.Models;

public class EstacionamentoController
{
    private EstacionamentoService service;

    public EstacionamentoController()
    {
        var estacionamento = new Estacionamento();
        service = new EstacionamentoService(estacionamento);
    }
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        if (placa != null && placa != string.Empty && !service.placaExiste(placa))
        {
            service.AdicionarVeiculo(placa);
            Console.WriteLine("Seja bem vindo ao nosso estacionamento!");
        }
        else
        {
            Console.WriteLine("Placa inválida");
        }
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine();
        if (placa != null && placa != string.Empty)
        {
            if (service.placaExiste(placa))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal valorTotal = 0;
                int horas = Convert.ToInt32(Console.ReadLine());
                service.RemoverVeiculo(placa, horas, out valorTotal);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Placa não cadastrada no estacionamento!");
            }

        }
        else
        {
            Console.WriteLine("Placa inválida");
        }

    }

    public void ListarVeiculos()
    {
        var veiculos = service.listarVeiculos();
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");
            int i = 0;
            foreach (var placa in veiculos)
            {
                Console.WriteLine($"{i}: {placa}");
                i++;
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}