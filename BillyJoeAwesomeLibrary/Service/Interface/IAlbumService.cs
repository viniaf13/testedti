using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Service.Interface
{
    public interface IAlbumService
    {
        void CadastrarAlbum(Album album);
        List<Album> PesquisarAlbumPorTitulo(string termoPesquisa);
    }
}
