using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Service.Interface
{
    public interface IAlbumService
    {
        void CadastrarAlbum(Album album);
        List<Album> PesquisarAlbumPorPropriedade(string termoPesquisa, string propriedadeAlbum);
    }
}
