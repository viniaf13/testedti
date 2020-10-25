using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Repository.Interface
{
    public interface IMusicaRepository
    {
        List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade);
        List<Musica> BuscarTodasMusicas();
    }
}
