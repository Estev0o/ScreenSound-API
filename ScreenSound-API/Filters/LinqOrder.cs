using ScreenSound_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_API.Filters
{
    internal class LinqOrder
    {
        public static void ListaArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
            Console.WriteLine("Lista de Artistas ordenados");

            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"-> {artista}");
            }
        }
    }
}
