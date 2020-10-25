using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Service.Interface;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Controller
{
    public class MusicaController : IMusicaController
    {
        private readonly IMusicaService _musicaService;
        public MusicaController(IMusicaService musicaService)
        {
            _musicaService = musicaService;
        }
        public List<Musica> PesquisarMusicaPorTitulo(string termoPesquisa)
        {
            return _musicaService.PesquisarMusicaPorTitulo(termoPesquisa);
        }

    }
}
