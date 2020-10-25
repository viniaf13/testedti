using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Repository.Interface
{
    public interface IAlbumRepository
    {
        void CadastrarAlbum(Album album);
        List<Album> PesquisarAlbumPorTitulo(string termoPesquisa);
    }
}
