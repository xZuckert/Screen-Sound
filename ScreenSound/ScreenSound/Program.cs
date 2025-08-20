Console.Clear(); string logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
"; string msgBoasVindas = "Boas Vindas ao Screen Sound"; List<string> listaDasBandas = new List<string>();
void ExibirMensagem(string logo, string msg){
    Console.WriteLine(logo); 
    Thread.Sleep(500);
    Console.WriteLine("***************************");
    Console.WriteLine(msg);
    Console.WriteLine("***************************");
    Thread.Sleep(500);
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
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 0: Console.WriteLine("Programa encerrado!"); break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de Banda: ");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    listaDasBandas.Add(nomeDaBanda);
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(1000);
    Console.Clear();
    ExibirOpçõesMenu();
}
void MostrarBandas()
{
    Console.Clear();
    Console.WriteLine("****************************");
    Console.WriteLine("Lista de Bandas Registradas: ");
    Console.WriteLine("****************************\n");
    Thread.Sleep(500);
    if (listaDasBandas.Count == 0)
    {
        Console.WriteLine("Nenhuma banda registrada.");
    }
    else
    {
        for (int i = 0; i < listaDasBandas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listaDasBandas[i]}");
        }
    }
    Console.Write("\nPrecione qualquer botão para voltar ao menu");
    Console.ReadKey();
    Thread.Sleep(200);
    Console.Clear();
    ExibirOpçõesMenu();
}

ExibirOpçõesMenu();