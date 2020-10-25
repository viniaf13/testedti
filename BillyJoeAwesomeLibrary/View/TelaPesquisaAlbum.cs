using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
                        Console.Write("\nDigite o titulo do album: ");
                        inputUsuario = Console.ReadLine();
                        PesquisarAlbumPorPropriedade(inputUsuario, "Titulo");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "2":
                        Console.Write("\nDigite o ano de lancamento do album: ");
                        inputUsuario = Console.ReadLine();
                        PesquisarAlbumPorPropriedade(inputUsuario, "AnoLancamento");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "3":
                        Console.Write("\nDigite o nome da banda do album: ");
                        inputUsuario = Console.ReadLine();
                        PesquisarAlbumPorPropriedade(inputUsuario, "Banda");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                    case "4":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("\nOpcao Invalida! Selecione uma das opcoes da lista abaixo: ");
                        inputUsuario = AbrirMenuDeOpcoes();
                        break;
                }
            }
        }
        private void PesquisarAlbumPorPropriedade(string inputUsuario, string propriedade)
        {
            List<Album> albuns = _albumController.PesquisarAlbumPorPropriedade(inputUsuario, propriedade);
            MostrarAlbunsFiltrados(albuns);
        }

        private static void MostrarAlbunsFiltrados(List<Album> albuns)
        {
            if (albuns == null || !albuns.Any())
            {
                Console.WriteLine("\nNao foram encontrados resultados para sua busca! =( ");
            }
            else
            {
                Console.WriteLine("\nForam encontrados os seguintes resultados: \n ");
                foreach (Album album in albuns)
                {
                    Console.WriteLine(
                    "TITULO: " + album.Titulo + "\n" +
                    "BANDA: " + album.Banda + "\n" +
                    "ANO DE LANCAMENTO: " + album.AnoLancamento + "\n" +
                    "MUSICAS: ");
                    int musicCount = 1;
                    foreach (Musica musica in album.Musicas)
                    {
                        string isFavorita = (musica.Favorita ? "♥" : "");
                        Console.WriteLine(
                        $"   {musicCount}. {musica.Titulo} ({musica.DuracaoEmSeg}s) {isFavorita} ");
                        musicCount++;
                    }
                    Console.WriteLine("");
                }
            }
        }

        private string AbrirMenuDeOpcoes()
        {
            Console.WriteLine(
                "------------------------------------" +
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
