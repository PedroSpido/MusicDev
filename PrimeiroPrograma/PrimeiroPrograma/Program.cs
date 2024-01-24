//Screen Sound
string mensagemDeBoasVindas = "Boas vindas ao Music Dev";
//List<String> bandas = new List<string>();

Dictionary<String, List<int>> bandas = new Dictionary<string, List<int>>();


void ExibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░██████╗░███████╗██╗░░░██╗
████╗░████║██║░░░██║██╔════╝██║██╔══██╗██╔══██╗██╔════╝██║░░░██║
██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝██║░░██║█████╗░░╚██╗░██╔╝
██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗██║░░██║██╔══╝░░░╚████╔╝░
██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝██████╔╝███████╗░░╚██╔╝░░
╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░╚═════╝░╚══════╝░░░╚═╝░░░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDeMenu()
{
    ExibirMensagemDeBoasVindas();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("Digite uma opção: ");
    String opcao = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcao);

    switch (opcaoEscolhida)
    {
        case 1: RegistraBanda();
            break;
        case 2: MostrarAsBandasRegistradas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMediaDasBandas();
            break;
        case -1:
            Console.WriteLine("Voce escolheu a opcao " + opcaoEscolhida);
            break;
        default: Console.WriteLine("Você deve escolher uma das opções acima");
            break;
    }
}

void RegistraBanda()
{
    Console.Clear();
    ExibindoTituloDaBanda("Registro de bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"O nome da banda {nomeDaBanda} foi registrado!");
    Console.WriteLine("Banda registrada com sucesso!!!");
    //Thread.Sleep(2000);
    Console.Clear(); 
    ExibirOpcoesDeMenu();
}

void MostrarAsBandasRegistradas()
{
    Console.Clear();
    ExibindoTituloDaBanda("Lista de bandas registradas");

    //for (int i = 0; i < bandas.Count; i++)
    //{
    //    Console.WriteLine(bandas[i]);
    //}

    foreach (string banda in bandas.Keys)
    {
        Console.WriteLine(banda);
    }

    Console.WriteLine("\nDigite alguma tecla para voltar!");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDeMenu();
}

void ExibindoTituloDaBanda(String titulo)
{
    int quantidadeDeLetras = titulo.Length;
    String asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarBanda()
{
    Console.Clear();
    Console.Write("\nDigite a banda que deseja avaliar: ");
    String nomeDaBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeDaBanda))
    {
        Console.Write("\nDigite a nota que deseja dar para essa banda: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeDaBanda].Add(nota);
        Console.WriteLine($"Nota {nota} para a banda {nomeDaBanda} " +
            $"registrada com sucesso");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
    else
    {
        Console.Write("\nEssa banda não existe!");
        Console.WriteLine("\nDigite alguma tecla para voltar!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
}

void ExibirMediaDasBandas()
{
    Console.Clear();
    ExibindoTituloDaBanda("Média da banda!");
    Console.Write("Digite a banda que deseja exibir a média: ");
    String bandaQueDesejaExibirMedia = Console.ReadLine()!;

    if (bandas.ContainsKey(bandaQueDesejaExibirMedia)) {
        List<int> notas = new List<int>();
        notas = bandas[bandaQueDesejaExibirMedia];
        Console.WriteLine($"A média da banda {bandaQueDesejaExibirMedia} é {notas.Average()}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
    else
    {
        Console.WriteLine("Essa banda não existe na lista!");
        Console.WriteLine("\nDigite alguma tecla para voltar!");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDeMenu();
    }
}

ExibirOpcoesDeMenu();


