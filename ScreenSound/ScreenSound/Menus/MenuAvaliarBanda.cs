using ScreenSound.Modelos;
namespace ScreenSound.Menus;
internal class MenuAvaliarBanda : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirMensagemTitulo("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual nota deseja dar a banda {nomeDaBanda}: ");
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
                banda.AdicionarNota(nota);
                Console.WriteLine($"\nA nota {nota.Nota} foi registrada para a banda {nomeDaBanda}!");
                Thread.Sleep(500);
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