using BillyJoeAwesomeLibrary.Models;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Service.Interface
{
    public interface IMusicaService
    {
        List<Musica> PesquisarMusicaPorTitulo(string termoPesquisa);
    }
}
