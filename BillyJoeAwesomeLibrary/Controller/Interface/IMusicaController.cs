using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Controller.Interface
{
    public interface IMusicaController
    {
        List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade);
        List<Musica> GerarPlaylist();
    }
}
