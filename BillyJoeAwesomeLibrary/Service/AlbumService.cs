using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using BillyJoeAwesomeLibrary.Service.Interface;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Service
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _albumRepository;
        public AlbumService(IAlbumRepository albumRepository)
        {
            _albumRepository = albumRepository;
        }
        public void CadastrarAlbum(Album album)
        {
            _albumRepository.CadastrarAlbum(album);
        }

        public List<Album> PesquisarAlbumPorTitulo(string termoPesquisa)
        {
            List<Album> albuns = new List<Album>();
            albuns = _albumRepository.PesquisarAlbumPorTitulo(termoPesquisa);
            return albuns;
        }
    }
}
