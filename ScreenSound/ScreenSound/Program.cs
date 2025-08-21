//Titulos e variaveis inicializadas
Console.Clear(); string logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
"; string msgBoasVindas = "Boas Vindas ao Screen Sound"; Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
//List<string> listaDasBandas = new List<string>();
void ExibirMensagem(string logo, string msg){
    Console.WriteLine(logo); 
    Thread.Sleep(200);
    ExibirTitulo(msg);
    Thread.Sleep(200);
}
void ExibirTitulo(string titulo) {
    int quantLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
    Thread.Sleep(200);
}
void ExibirOpçõesMenu() {
    ExibirMensagem(logo, msgBoasVindas);
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar Bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    Thread.Sleep(500);
    switch (opcaoEscolhidaInt) {
        case 1: RegistrarBanda(); break;
        case 2: MostrarBandas(); break;
        case 3: AvaliarUmaBanda(); break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 0: Console.WriteLine("\nPrograma encerrado!"); break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpçõesMenu();
}
void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Lista de Bandas Registradas");
    Thread.Sleep(200);
    if (bandasRegistradas.Keys.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada.");
    }
    else
    {
        int i = 1;
        foreach (string banda in bandasRegistradas.Keys) 
        {
            Console.WriteLine($"{i}. {banda}");
            i++;
        }
    }
    Console.Write("\nPrecione qualquer botão para voltar ao menu");
    Console.ReadKey();
    Thread.Sleep(200);
    Console.Clear();
    ExibirOpçõesMenu();
}

void AvaliarUmaBanda()
{
    // Digitar a banda que deseja avaliar
    // Verificar se a banda existe >> atribuir uma nota
    // Se não existir, volta ao menu principal
    Console.Clear();
    ExibirTitulo("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual nota deseja dar a banda {nomeDaBanda}: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada para a banda {nomeDaBanda}!");
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não encontrada!");
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        ExibirOpçõesMenu();
    }
}

ExibirOpçõesMenu();