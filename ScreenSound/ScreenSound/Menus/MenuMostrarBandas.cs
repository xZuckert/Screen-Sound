using ScreenSound.Modelos;
namespace ScreenSound.Menus;
    internal class MenuMostrarBandas : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            base.Executar(bandasRegistradas);
            ExibirMensagemTitulo("Lista de Bandas Registradas");
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
        }
    }