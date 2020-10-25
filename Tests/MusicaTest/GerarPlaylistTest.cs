using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.RepositoryMoq;
using BillyJoeAwesomeLibrary.Service;
using BillyJoeAwesomeLibrary.Service.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace Tests.MusicaTest
{
    [TestClass]
    public class GerarPlaylistTest
    {
        private IMusicaService _musicaService;
        private Mock<MusicaRepositoryMoq> _repositoryMoq;

        [TestInitialize]
        public void IniciarTestes()
        {
            _repositoryMoq = new Mock<MusicaRepositoryMoq>();
            _musicaService = new MusicaService(_repositoryMoq.Object);

        }

        [TestMethod]
        public void PlaylistSucesso()
        {
            List<Musica>  playlist = _musicaService.GerarPlaylist();
            Assert.IsNotNull(playlist);
        }
    }
}
