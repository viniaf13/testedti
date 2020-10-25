using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using BillyJoeAwesomeLibrary.Service.Interface;
using System.Collections.Generic;

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

    }
}
