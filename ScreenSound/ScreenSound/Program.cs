using ScreenSound.Modelos;
using ScreenSound.Menus;

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda legiao = new Banda("Legião Urbana");
legiao.AdicionarNota(new Avaliacao(8));
legiao.AdicionarNota(new Avaliacao(7));
legiao.AdicionarNota(new Avaliacao(9));

//Titulos e variaveis inicializadas
 Console.Clear(); string logo = @"
 ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
 ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
 ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
 ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
 ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
 ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
 "; string msgBoasVindas = "Boas Vindas ao Screen Sound";
 Dictionary<string, Banda> bandasRegistradas = new();
 bandasRegistradas.Add(ira.Nome, ira);
 bandasRegistradas.Add(legiao.Nome, legiao);
// void ExibirTitulo(string titulo)
// {
//     int quantLetras = titulo.Length;
//     string asteriscos = string.Empty.PadLeft(quantLetras, '*');
//     Console.WriteLine(asteriscos);
//     Console.WriteLine(titulo);
//     Console.WriteLine(asteriscos + "\n");
// }
// void ExibirMensagemTitulo(string logo, string msg){
//     Console.WriteLine(logo); 
//     Thread.Sleep(200);
//     ExibirTitulo(msg);
//     Thread.Sleep(200);
// }
void ExibirOpçõesMenu() {
    Menu.ExibirLogo();
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Registrar um álbum");
    Console.WriteLine("3 - Mostrar bandas");
    Console.WriteLine("4 - Avaliar uma banda");
    Console.WriteLine("5 - Exibir a média de uma banda");
    Console.WriteLine("0 - Sair");
    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaInt = int.Parse(opcaoEscolhida);
    Thread.Sleep(200);
    switch (opcaoEscolhidaInt) {
        case 1: RegistrarBanda(); break;
        case 2: RegistrarAlbum(); break;
        case 3: MostrarBandas(); break;
        case 4:
            MenuAvaliarBanda avaliar = new MenuAvaliarBanda();
            avaliar.Executar(bandasRegistradas);
            ExibirOpçõesMenu(); break;
        case 5:
            MenuExibirDetalhes menu = new MenuExibirDetalhes();
            menu.Executar(bandasRegistradas);
            ExibirOpçõesMenu(); break;
        case 0: Console.WriteLine("\nPrograma encerrado!"); break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
}
void RegistrarBanda()
{
    Console.Clear();
    Menu.ExibirMensagemTitulo("Registro de Banda");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    Banda banda = new Banda(nomeDaBanda);
    bandasRegistradas.Add(nomeDaBanda, banda);
    Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(500);
    Console.Write("\nPrecione qualquer botão para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçõesMenu();
}
void RegistrarAlbum()
{
    Console.Clear();
    Menu.ExibirMensagemTitulo("Registro de Álbuns");
    Console.Write($"Digite a banda cujo álbum deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Agora digite o título do álbum: ");
        string tituloDoAlbum = Console.ReadLine()!;
        Banda banda = bandasRegistradas[nomeDaBanda];
        banda.AdicionarAlbum(new Album(tituloDoAlbum));
        Console.Write($"O álbum {tituloDoAlbum} de {nomeDaBanda} foi registrado como sucesso!");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
    }
    Thread.Sleep(500);
    Console.Write("\nPrecione qualquer botão para voltar ao menu");
    Console.ReadKey();
    Console.Clear();
    ExibirOpçõesMenu();
}
void MostrarBandas()
{
    Console.Clear();
    Menu.ExibirMensagemTitulo("Lista de Bandas Registradas");
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

ExibirOpçõesMenu();