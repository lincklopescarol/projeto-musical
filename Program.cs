string mensagemDeBoasVindas = "Boas vindas ao sistema de música!";
List<string> listaDasBandas = new List<string>{"One Direction"};


void ExibirMensagemBoasVindas()
{
    Console.WriteLine("***********************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***********************************");
}

void ExibirOpcoesMenu()
{
    ExibirMensagemBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
           MostrarBandasRegistradas();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNumerica);
            break;
        case -1:
            Console.WriteLine("Encerrando o programa! :)");
            break;
        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("***************************");
    Console.WriteLine("Registro de bandas");
    Console.WriteLine("***************************\n");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas(){
    Console.WriteLine("****************************************");
    Console.WriteLine("Exibindo todas as bandas registradas: ");
    Console.WriteLine("****************************************\n");

    for (int i = 0; i < listaDasBandas.Count; i++)
    {
        Console.WriteLine($"Banda: {listaDasBandas[i]}");
    }
    Console.WriteLine("\nPressione em uma tecla para voltar ao Menu Principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();
