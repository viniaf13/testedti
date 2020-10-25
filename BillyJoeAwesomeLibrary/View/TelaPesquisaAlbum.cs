using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using System;
using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.View
{
    public class TelaPesquisaAlbum
    {
        private readonly IAlbumController _albumController;
        public TelaPesquisaAlbum(IAlbumController albumController)
        {
            _albumController = albumController;
        }

        public void PesquisarAlbum()
        {
            bool loop = true;
            string inputUsuario = AbrirMenuDeOpcoes();
            while (loop)
            {
                switch (inputUsuario)
                {
                    case "1":
                        PesquisarAlbumPorTitulo();
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "2":
                        Console.WriteLine("\nPesquisou Musica2");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "3":
                        Console.WriteLine("\nPesquisou Musica3");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "4":
                        Console.WriteLine("\nSaiu");
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\nOpcao Invalida! Selecione uma das opcoes da lista abaixo: ");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                }
            }
        }
        private void PesquisarAlbumPorTitulo()
        {
            List<Album> albuns = new List<Album>();
            albuns = _albumController.PesquisarAlbumPorTitulo("teste");
        } 
        private string AbrirMenuDeOpcoes()
        {
            Console.WriteLine(
                "\nSelecione o filtro da pesquisa:\n" +
                "1 - Pesquisar por titulo\n" +
                "2 - Pesquisar por ano de lancamento\n" +
                "3 - Pesquisar pelo nome da banda\n" +
                "4 - Voltar ao Menu Principal"
                );
            Console.Write("\r\nSelecione uma opcao e aperte ENTER: ");
            return Console.ReadLine();
        }

    }
}
