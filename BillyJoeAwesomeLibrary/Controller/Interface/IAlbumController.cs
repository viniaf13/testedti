using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Controller.Interface
{
    public interface IAlbumController
    {
        void CadastrarAlbum(Album album);
        List<Album> PesquisarAlbumPorTitulo(string termoPesquisa);
    }
}
