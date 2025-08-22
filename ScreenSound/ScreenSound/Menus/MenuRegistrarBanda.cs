using ScreenSound.Modelos;
using OpenAI;
using OpenAI.Chat;

namespace ScreenSound.Menus;
    internal class MenuRegistrarBanda : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
        base.Executar(bandasRegistradas);
        ExibirMensagemTitulo("Registro de Banda");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        //Busca um pequeno resumo da banda registrada no chat gpt e o armazena em banda.Resumo
        var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");
        var client = new OpenAIClient(apiKey);
        var chatClient = client.GetChatClient("gpt-4o-mini");
        UserChatMessage mensagem = ChatMessage.CreateUserMessage($"Resuma a banda {nomeDaBanda} em 1 pequeno parágrafo, adote um estilo informal e resumido");
        var resposta = chatClient.CompleteChatAsync(mensagem).GetAwaiter().GetResult();
        banda.Resumo = resposta.Value.Content[0].Text;
        Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
        Thread.Sleep(500);
        Console.Write("\nPrecione qualquer botão para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}