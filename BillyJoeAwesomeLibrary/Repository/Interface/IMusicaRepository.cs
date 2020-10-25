using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Repository.Interface
{
    public interface IMusicaRepository
    {
        List<Musica> PesquisarMusicaPorTitulo(string termoPesquisa);
    }
}
