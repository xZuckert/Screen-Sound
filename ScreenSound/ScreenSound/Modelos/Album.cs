namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public Album(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
    public int DuraçãoTotal =>
        musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExbirMusicasAlbum()
    {
        Console.WriteLine($"\nLista de músicas do álbum {Nome}\n");
        int i = 1;
        foreach (var musica in musicas)
        {
            Console.WriteLine($"{i}. {musica.Nome}");
            i++;
        }

        Console.WriteLine($"\nA duração total do álbum {Nome} é de {DuraçãoTotal} segundos.");
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
}