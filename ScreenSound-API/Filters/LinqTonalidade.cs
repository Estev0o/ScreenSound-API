using ScreenSound_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_API.Filters
{
    internal class LinqTonalidade
    {
        internal static void ExibirMusicasTonalidadeCsharp(List<Musica> musicas)
        {
            var exibirTonalidadeDaMusica = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();

            Console.WriteLine("Lista de musicas com a tonalidade C#");

            foreach (var mt in exibirTonalidadeDaMusica)
            {
                Console.WriteLine($"->: {mt}");
            }
        }
    }
}
