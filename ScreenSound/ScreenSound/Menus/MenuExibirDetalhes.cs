using ScreenSound.Modelos;
namespace ScreenSound.Menus;
internal class MenuExibirDetalhes : Menu
{
    public void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirMensagemTitulo("Média de Banda");
        Console.Write("\nDigite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"\nA média da banda {nomeDaBanda} é {banda.Media}");
            Console.Write("\nPrecione qualquer botão para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.Write("\nPrecione qualquer botão para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
