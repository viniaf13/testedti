using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Service.Interface;
using System;

namespace BillyJoeAwesomeLibrary.Controller
{
    public class AlbumController : IAlbumController
    {
        private readonly IAlbumService _albumService;
        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public void CadastrarAlbum(Album album)
        {
            _albumService.CadastrarAlbum(album);
        }
    }
}
