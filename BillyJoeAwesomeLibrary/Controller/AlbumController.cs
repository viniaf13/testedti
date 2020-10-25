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

        public List<Album> PesquisarAlbumPorTitulo(string termoPesquisa)
        {
            List<Album> albuns = new List<Album>();
            albuns = _albumService.PesquisarAlbumPorTitulo(termoPesquisa);
            return albuns;
        }
    }
}
