using BillyJoeAwesomeLibrary.Controller.Interface;
using System;

namespace BillyJoeAwesomeLibrary.View
{
    public class TelaMenu 
    {
        private readonly IAlbumController _albumController;
        public TelaMenu(IAlbumController albumController)
        {
            _albumController = albumController;
        }

        public void InicializarVisual()
        {
            bool loop = true;
            string inputUsuario = AbrirMenuDeOpcoes();
            while (loop)
            {
                switch (inputUsuario)
                {
                    case "1":

                        TelaCadastroAlbum telaCadastroAlbum = new TelaCadastroAlbum(_albumController);
                        telaCadastroAlbum.CadastrarAlbum();
                        loop = false;
                        break;
                    case "2":
                        Console.WriteLine("\nPesquisou Album");
                        loop = false;
                        break;
                    case "3":
                        Console.WriteLine("\nPesquisou Musica");
                        loop = false;
                        break;
                    case "4":
                        Console.WriteLine("\nGerou Playlist");
                        loop = false;
                        break;
                    case "5":
                        Console.WriteLine("\nSaiu");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\nOpcao Invalida! Selecione uma das opções da lista abaixo:\n");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                }
            }
        }  
        private string AbrirMenuDeOpcoes()
        {
            Console.WriteLine(
                "MENU DE OPERACOES\n" +
                "1 - Cadastrar Album\n" +
                "2 - Pesquisar Album\n" +
                "3 - Pesquisar Musica\n" +
                "4 - Gerar Playlist\n" +
                "5 - Sair"
                );
            Console.Write("\r\nSelecione uma operacao e aperte ENTER: ");
            return Console.ReadLine();
        }

    }
}
