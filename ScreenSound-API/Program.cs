using ScreenSound_API.Models;
using System.Text.Json;
using ScreenSound_API.Filters;

using (HttpClient client = new HttpClient())
{
	try
	{
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
		var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //musicas[199].ExibirDetalhesMusicas();

        LinqTonalidade.ExibirMusicasTonalidadeCsharp(musicas);

        //LinqFilter.FiltrarTodosGeneros(musicas);
        //LinqOrder.ListaArtistasOrdenados(musicas);
        //LinqFilter.ArtistaGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeArtistas(musicas, "Post Malone");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2012);

        //var musicasPreferidas = new MusicasFavoritas("Vini");
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[55]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[80]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[700]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[130]);
        //musicasPreferidas.AdicionarMusicasFavoritas(musicas[1990]);
        //musicasPreferidas.ExibirMusicasFavoritas();

        //musicasPreferidas.GerarArquivoJason();
    }
    catch (Exception erro)
	{

		Console.WriteLine($"Opa. Temos um problema:  {erro.Message}");
	}

}