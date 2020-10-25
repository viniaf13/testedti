using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BillyJoeAwesomeLibrary.View
{
    public class TelaPesquisaMusica
    {
        private readonly IAlbumController _albumController;
        private readonly IMusicaController _musicaController;
        public TelaPesquisaMusica(IAlbumController albumController, IMusicaController musicaController)
        {
            _albumController = albumController;
            _musicaController = musicaController;
        }

        public void PesquisarMusica()
        {
            bool loop = true;
            string inputUsuario = AbrirMenuDeOpcoes();
            while (loop)
            {
                switch (inputUsuario)
                {
                    case "1":
                        Console.Write("\nDigite o titulo do musica: ");
                        inputUsuario = Console.ReadLine();
                        PesquisarMusicaPorPropriedade(inputUsuario, "Musica.Titulo");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "2":
                        Console.Write("\nDigite a banda desejada: ");
                        inputUsuario = Console.ReadLine();
                        PesquisarMusicaPorPropriedade(inputUsuario, "Banda");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "3":
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

        private void PesquisarMusicaPorPropriedade(string inputUsuario, string propriedade)
        {
            List<Album> albuns = _albumController.PesquisarAlbumPorPropriedade(inputUsuario, propriedade);
            //MostrarMusicasFiltrados(albuns);
        }

        private string AbrirMenuDeOpcoes()
        {
            Console.WriteLine(
                "------------------------------------" +
                "\nSelecione o filtro da pesquisa:\n" +
                "1 - Pesquisar por titulo\n" +
                "2 - Pesquisar por banda\n" +
                "3 - Voltar ao Menu Principal"
                );
            Console.Write("\r\nSelecione uma opcao e aperte ENTER: ");
            return Console.ReadLine();
        }
    }
}
