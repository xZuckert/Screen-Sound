using ScreenSound.Modelos;

namespace ScreenSound.Menus;
    internal class MenuRegistrarAlbum : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirMensagemTitulo("Registro de Álbuns");
            Console.Write($"Digite a banda cujo álbum deseja registrar: ");
            string nomeDaBanda = Console.ReadLine()!;
            if (bandasRegistradas.ContainsKey(nomeDaBanda))
            {
                Console.Write($"Agora digite o título do álbum: ");
                string tituloDoAlbum = Console.ReadLine()!;
                Banda banda = bandasRegistradas[nomeDaBanda];
                banda.AdicionarAlbum(new Album(tituloDoAlbum));
                Console.Write($"\nO álbum {tituloDoAlbum} de {nomeDaBanda} foi registrado como sucesso!\n");
            }
            else
            {
                Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            }
            Thread.Sleep(500);
            Console.Write("\nPrecione qualquer botão para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
    }
    }