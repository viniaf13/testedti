using BillyJoeAwesomeLibrary.Models;

namespace BillyJoeAwesomeLibrary.Controller.Interface
{
    public interface IAlbumController
    {
        int ValidacaoAnoAlbum(string anoString);
        void CadastrarAlbum(Album album);
    }
}
