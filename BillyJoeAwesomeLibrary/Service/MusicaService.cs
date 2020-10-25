using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using BillyJoeAwesomeLibrary.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BillyJoeAwesomeLibrary.Service
{
    public class MusicaService : IMusicaService
    {
        private readonly IMusicaRepository _musicaRepository;
        public MusicaService(IMusicaRepository musicaRepository)
        {
            _musicaRepository = musicaRepository;
        }

        public List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade)
        {
            return _musicaRepository.PesquisarMusicaPorPropriedade(termoPesquisa, propriedade);
        }

        public List<Musica> GerarPlaylist()
        {
            List<Musica> todasMusicas = _musicaRepository.BuscarTodasMusicas();

            List<Musica> musicasFavoritas = new List<Musica>();
            List<Musica> musicasOutras = new List<Musica>();
            List<Musica> playlist = new List<Musica>();
            int duracaoPlaylist = 0;

            musicasFavoritas.AddRange(todasMusicas.Where(musica => musica.Favorita));
            musicasOutras.AddRange(todasMusicas.Where(musica => !musica.Favorita));

            while (musicasFavoritas.Any() || musicasOutras.Any())
            {
                if (musicasFavoritas.Any())
                {
                    AdicionarMusicaNaPlaylist(musicasFavoritas, playlist, ref duracaoPlaylist);
                }                
                if (musicasOutras.Any())
                {
                    AdicionarMusicaNaPlaylist(musicasOutras, playlist, ref duracaoPlaylist);
                }
            }

            playlist = playlist.OrderBy(a => Guid.NewGuid()).ToList();

            return playlist;
        }

        private static void AdicionarMusicaNaPlaylist(List<Musica> listaDeMusicas, List<Musica> playlist, ref int duracaoPlaylist)
        {
            Random randomNum = new Random();
            int musicaIndex = randomNum.Next(0, listaDeMusicas.Count);
            if (Int32.Parse(listaDeMusicas[musicaIndex].DuracaoEmSeg) + duracaoPlaylist < Constants.HORA_EM_SEGUNDOS)
            {
                duracaoPlaylist += Int32.Parse(listaDeMusicas[musicaIndex].DuracaoEmSeg);
                playlist.Add(listaDeMusicas[musicaIndex]);
            }
            listaDeMusicas.RemoveAt(musicaIndex);
        }
    }
}
