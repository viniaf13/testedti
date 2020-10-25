using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Service.Interface;
using System;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Controller
{
    public class AlbumController : IAlbumController
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public void CadastrarAlbum(Album album)
        {
            _albumService.CadastrarAlbum(album);
        }

        public List<Album> PesquisarAlbumPorPropriedade(string termoPesquisa, string propriedadeAlbum)
        {
            List<Album> albuns = _albumService.PesquisarAlbumPorPropriedade(termoPesquisa, propriedadeAlbum);
            return albuns;
        }
    }
}
