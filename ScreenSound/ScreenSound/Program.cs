using ScreenSound.Modelos;
using ScreenSound.Menus;

Console.Clear();

Banda ira = new Banda("Ira");
ira.AdicionarNota(new Avaliacao(10));
ira.AdicionarNota(new Avaliacao(8));
ira.AdicionarNota(new Avaliacao(6));
Banda legiao = new Banda("Legião Urbana");
legiao.AdicionarNota(new Avaliacao(8));
legiao.AdicionarNota(new Avaliacao(7));
legiao.AdicionarNota(new Avaliacao(9));

 Dictionary<string, Banda> bandasRegistradas = new();
 bandasRegistradas.Add(ira.Nome, ira);
 bandasRegistradas.Add(legiao.Nome, legiao);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(0, new MenuSair());

 

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


    if (opcoes.ContainsKey(opcaoEscolhidaInt))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaInt];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaInt > 0) ExibirOpçõesMenu();
    }
    else
    {
        Console.WriteLine("Opção Inválida");
    }
}
ExibirOpçõesMenu();