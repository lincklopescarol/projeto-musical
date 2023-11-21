string mensagemDeBoasVindas = "Boas vindas ao sistema de música!";
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("One Direction", new List<int> {10, 10, 8});
bandasRegistradas.Add("Beatles", new List<int> ());


void ExibirMensagemBoasVindas()
{
    Console.WriteLine("*********************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*********************************");
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
            AvaliarBanda();
            break;
        case 4:
            ExibirAMediaDeNotas();
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
    ExibirTituloOpcao("Registro das bandas: ");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandasRegistradas(){
    Console.Clear();
    ExibirTituloOpcao("Exibindo todas as bandas registradas: ");

//    for (int i = 0; i < listaDasBandas.Count; i++)
//    {
//        Console.WriteLine($"Banda: {listaDasBandas[i]}");
//    }

foreach (string banda in bandasRegistradas.Keys)
{
    Console.WriteLine($"Banda: {banda}");
}
    Console.WriteLine("\nPressione em uma tecla para voltar ao Menu Principal.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda(){
    // digitar a banda que deseja avaliar
    // se a banda existe, atribui uma nota
    // se não, volta para o menu principal
    Console.Clear();
    ExibirTituloOpcao("Avaliar uma banda: ");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)){
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();

    } else {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada! ");
        Console.WriteLine("Digite uma tecla para voltar ao Menu Principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void ExibirAMediaDeNotas(){
    Console.Clear();
    ExibirTituloOpcao("Página de exibição de média de notas das bandas: ");
    Console.Write("Digite o nome da banda que deseja visualizar a média de notas? ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda)){
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}.");
        Console.WriteLine("Digite uma tecla para voltar ao Menu Principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    } else {
        Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada! ");
        Console.WriteLine("Digite uma tecla para voltar ao Menu Principal.");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
}}

ExibirOpcoesMenu();
