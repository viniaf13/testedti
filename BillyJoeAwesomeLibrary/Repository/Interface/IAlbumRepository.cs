using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Repository.Interface
{
    public interface IAlbumRepository
    {
        void CadastrarAlbum(Album album);
        List<Album> PesquisarAlbumPorPropriedade(string termoPesquisa, string propriedadeAlbum);
    }
}
