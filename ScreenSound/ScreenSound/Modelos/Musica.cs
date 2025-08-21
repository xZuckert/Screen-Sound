namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescriçãoResumida =>
        $"A música {Nome} pertence à banda {Artista.Nome}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}" +
                          $"\nArtista: {Artista.Nome}" +
                          $"\nDuração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponível\n");
        }
        else
        {
            Console.WriteLine($"Indisponível\n");
        }
    }
}