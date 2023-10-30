using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_API.Models
{
    internal class MusicasFavoritas
    {
        public string? Nome { get; set; }

        public List<Musica>? ListaMusicaFavorita { get;}

        public MusicasFavoritas (string nome) 
        {
            Nome = nome;
            ListaMusicaFavorita = new List<Musica> ();  
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaMusicaFavorita?.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas sao as musicas favoritas -> {Nome}");

            foreach (var musica in ListaMusicaFavorita!)
            {
                Console.WriteLine($"Musica {musica.Nome}\n Artista {musica.Artista}");
            }
            Console.WriteLine();
        }

        public void GerarArquivoJason()
        {
            var json = JsonSerializer.Serialize(new
            {
                nome = Nome,
                musicas = ListaMusicaFavorita,
            });

            string nomeArquivo = $"Musica-favoritas-{Nome}.json";

            File.WriteAllText(nomeArquivo, json);

            Console.WriteLine($"Arquivo Json criado com sucesso!{Path.GetFullPath(nomeArquivo)}");

        }   
    }
}
