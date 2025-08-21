using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirMensagemTitulo("Avaliar Álbum");
        Console.Write("Digite o nome da banda que deseja avaliar um álbum: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Agora digite o título do álbum: ");
            string tituloDoAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloDoAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloDoAlbum));
                Console.Write($"Qual nota deseja dar ao álbum {tituloDoAlbum}: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                if (nota.Nota < 0 || nota.Nota > 10)
                {
                    Console.WriteLine("Nota inválida! A nota deve ser entre 0 e 10.");
                    Console.Write("\nPrecione qualquer botão para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada para o álbum {tituloDoAlbum}!");
                    Thread.Sleep(500);
                    Console.Write("\nPrecione qualquer botão para voltar ao menu");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            else
            {
                Console.WriteLine($"o Álbum {tituloDoAlbum} não foi encontrado!");
                Console.Write("\nPrecione qualquer botão para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não encontrada!");
            Console.Write("\nPrecione qualquer botão para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}