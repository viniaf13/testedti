using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using Moq;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.RepositoryMoq
{
    public class MusicaRepositoryMoq : IMusicaRepository
    {
        public readonly Mock<IMusicaRepository> _mock;

        private readonly List<Musica> _listaMusicaFiltrada = new List<Musica>
        {
            new Musica
            {
                Titulo = "American Idiot", 
                DuracaoEmSeg = "100",
                Favorita = true,
                Banda = "Green Day"
            },
            new Musica
            {
                Titulo = "Holiday",
                DuracaoEmSeg = "1200",
                Favorita = true,
                Banda = "Green Day"
            }
        };

        private readonly List<Musica> _todasMusicas = new List<Musica>
        {
            new Musica
            {
                Titulo = "American Idiot",
                DuracaoEmSeg = "100",
                Favorita = true,
                Banda = "Green Day"
            },
            new Musica
            {
                Titulo = "Holiday",
                DuracaoEmSeg = "1200",
                Favorita = true,
                Banda = "Green Day"
            },
            new Musica
            {
                Titulo = "Jesus of Suburbia",
                DuracaoEmSeg = "1200",
                Favorita = true,
                Banda = "Green Day"
            },
            new Musica
            {
                Titulo = "BYOB",
                DuracaoEmSeg = "1200",
                Favorita = true,
                Banda = "Systm Of A Down"
            }
        };

        public MusicaRepositoryMoq()
        {
            _mock = new Mock<IMusicaRepository>();
            _mock.Setup(m => m.PesquisarMusicaPorPropriedade(It.IsAny<string>(), It.IsAny<string>()))
                .Returns((string termoPesquisa, string propriedade) => _listaMusicaFiltrada);
            _mock.Setup(m => m.BuscarTodasMusicas()).Returns(()=> _todasMusicas);
        }

        public List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade)
        {
            return _mock.Object.PesquisarMusicaPorPropriedade(termoPesquisa, propriedade);
        }

        public List<Musica> BuscarTodasMusicas()
        {
            return _mock.Object.BuscarTodasMusicas();
        }
    }
}
