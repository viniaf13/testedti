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
            Console.Write("\nDigite o titulo do album: ");
            string inputUsuario = Console.ReadLine();
            List<Album> albuns = _albumController.PesquisarAlbumPorTitulo(inputUsuario);
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
                        $"   {musicCount} - {musica.Titulo} ({musica.DuracaoEmSeg}s) {isFavorita} ");
                        musicCount++;
                    }    
                }
            }
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
