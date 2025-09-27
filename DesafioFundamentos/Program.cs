using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;
var estacionamento = new Estacionamento();
var controller = new EstacionamentoController();

Console.WriteLine("Seja bem vindo ao sistema de estacionamento!\n" +
                  $"O preço inicial é de: {estacionamento.precoInicial} ");
Console.WriteLine($"E o preço por hora é:{estacionamento.precoPorHora}");

string opcao = string.Empty;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar veículo");
    Console.WriteLine("2 - Remover veículo");
    Console.WriteLine("3 - Listar veículos");
    Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            controller.AdicionarVeiculo();
            break;

        case "2":
            controller.RemoverVeiculo();
            break;

        case "3":
            controller.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
