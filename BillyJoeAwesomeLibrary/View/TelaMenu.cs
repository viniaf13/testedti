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
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "2":
                        TelaPesquisaAlbum telaPesquisaAlbum = new TelaPesquisaAlbum(_albumController);
                        telaPesquisaAlbum.PesquisarAlbum();
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "3":
                        Console.WriteLine("\nPesquisou Musica");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "4":
                        Console.WriteLine("\nGerou Playlist");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "5":
                        Console.WriteLine("\nSaiu");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\nOpcao Invalida! Selecione uma das opções da lista abaixo: ");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                }
            }
        }  
        private string AbrirMenuDeOpcoes()
        {
            Console.WriteLine(
                "------------------------------------" +
                "\nMENU DE OPERACOES\n" +
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
