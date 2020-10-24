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

        public int ValidacaoAnoAlbum(string anoString)
        {
            bool isAnoValido = Utils.IsStringInteiroMaiorQueZero(anoString);
            while (!isAnoValido)
            {
                Console.Write("\nAno invalido.\nDigite um ano de lancamento valido para o album: ", anoString);
                anoString = Console.ReadLine();
                isAnoValido = Utils.IsStringInteiroMaiorQueZero(anoString);
            }
            return Int32.Parse(anoString);
        }

        public void CadastrarAlbum(Album album)
        {
            _albumService.CadastrarAlbum(album);
        }
    }
}
