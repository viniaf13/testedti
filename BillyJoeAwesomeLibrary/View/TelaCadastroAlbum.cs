using BillyJoeAwesomeLibrary.Controller;
using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using System;

namespace BillyJoeAwesomeLibrary.View
{
    public class TelaCadastroAlbum
    {
        private readonly IAlbumController _albumController;
        public TelaCadastroAlbum(IAlbumController albumController)
        {
            _albumController = albumController;
        }

        public void CadastrarAlbum()
        {
            Album novoAlbum = new Album();
            Console.Write("\nDigite o titulo do album: ");
            novoAlbum.Titulo = Console.ReadLine();
            Console.Write("\nDigite o nome da banda do album: ");
            novoAlbum.Banda = Console.ReadLine();

            Console.Write("\nDigite o ano de lancamento do album: ");
            string anoString = Console.ReadLine();
            novoAlbum.AnoLancamento = _albumController.ValidacaoAnoAlbum(anoString);

            //enviar para base de dados
            //mensagem sucesso
            //retornar ao menu
        }

        private bool ConfirmarCadastroAlbum(Album novoAlbum)
        {
            Console.WriteLine("\nTitulo: " + novoAlbum.Titulo);
            Console.WriteLine("\nBanda: " + novoAlbum.Banda);
            Console.WriteLine("\nAno de Lancamento: " + novoAlbum.AnoLancamento);

            return true;
        }


    }
}
