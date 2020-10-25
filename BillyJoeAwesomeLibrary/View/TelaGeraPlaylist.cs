using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BillyJoeAwesomeLibrary.View
{
    public class TelaGeraPlaylist
    {
        private readonly IMusicaController _musicaController;
        public TelaGeraPlaylist(IMusicaController musicaController)
        {
            _musicaController = musicaController;
        }

        public void GerarPlaylist()
        {
            List<Musica> novaPlaylist = _musicaController.GerarPlaylist();
            MostrarPlaylist(novaPlaylist);
        }
        private void MostrarPlaylist(List<Musica> playlist)
        {
            if (playlist == null || !playlist.Any())
            {
                Console.WriteLine("\nNao ha musicas para serem adicionadas a playlist! =( ");
            }
            else
            {
                Console.WriteLine("\nVeja essa nova playlist gerada para voce: \n ");
                int musicCount = 1;
                foreach (Musica musica in playlist)
                {
                    string isFavorita = (musica.Favorita ? "♥" : "");
                    Console.WriteLine(
                    $"{musicCount}. {musica.Titulo} - {musica.Banda} ({musica.DuracaoEmSeg}s) {isFavorita} ");
                    musicCount++;
                }
                Console.WriteLine("");
            }
        }


    }
}
