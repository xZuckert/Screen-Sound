void ExibirMensagem(string logo, string msg){
    Console.WriteLine(logo);
    Console.WriteLine("***************************");
    Console.WriteLine(msg);
    Console.WriteLine("***************************");
}

void ExibirOpçõesMenu() {
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar Bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");
    
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaInt) {
        case 1: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaInt); break;
        case 0: Console.WriteLine("Programa encerrado!"); break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
}

string logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
";

string msgBoasVindas = "Boas Vindas ao Screen Sound";
ExibirMensagem(logo, msgBoasVindas);
ExibirOpçõesMenu();