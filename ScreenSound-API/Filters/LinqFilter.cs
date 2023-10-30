using ScreenSound_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_API.Filters
{
    internal class LinqFilter
    {
        public static void FiltrarTodosGeneros(List<Musica> musicas) 
        {
            var generosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

            foreach (var genero in generosMusicais)
            {
                Console.WriteLine($"- {genero}");
            }
        }

        public static void ArtistaGeneroMusical(List<Musica> musicas, string genero)
        {
            var artistasGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).OrderBy(musica => musica.Artista).
                Select(musica => musica.Artista).Distinct().ToList();
            Console.WriteLine($"Exibindo artistas por genero musical ----- {genero}");

            foreach (var artista in artistasGeneroMusical)
            {
                Console.WriteLine($"-> {artista}");
            }
        }

        public static void FiltrarMusicasDeArtistas(List<Musica> musicas, string nomeArtista)
        {
            var musicaDeArtistasFiltrada = musicas.Where(musica => musica.Artista!.Equals(nomeArtista)).ToList().OrderBy(musica => musica.Nome);

            Console.WriteLine(nomeArtista);

            foreach (var musica in musicaDeArtistasFiltrada)
            {
                Console.WriteLine($"-> {musica.Nome}");
            }
        }

        public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
        {
            var musicasPorAnos = musicas.Where(musica => musica.Ano! == ano).ToList().OrderByDescending(musicas => musicas.Ano).Select(musicas => musicas.Nome).Distinct().ToList();

            Console.WriteLine($"Musicas do ano {ano}");

            foreach (var anos in musicasPorAnos)
            {
                Console.WriteLine($"-> {anos}");
            }
        }

    }
}
