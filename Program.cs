string mensagemDeBoasVindas = "Boas vindas ao sistema de música!";


void ExibirMensagemBoasVindas()
{
    Console.WriteLine("***********************************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("***********************************");
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcaoEscolhidaNumerica == 1)
    {
        Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
    }
}

ExibirMensagemBoasVindas();
ExibirOpcoesMenu();
