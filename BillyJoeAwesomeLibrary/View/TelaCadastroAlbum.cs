﻿using BillyJoeAwesomeLibrary.Controller.Interface;
using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Models;
using System;
using System.Collections.Generic;

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
            string errorMsg = "\nAno invalido.\nDigite um ano de lancamento valido para o album: ";
            novoAlbum.AnoLancamento = Utils.ValidacaoAnoString(anoString, errorMsg);

            novoAlbum.Musicas = AdicionarMusicas(novoAlbum);

            _albumController.CadastrarAlbum(novoAlbum);

            Console.WriteLine("\nAlbum cadastrado com sucesso!");
        }

        private List<Musica> AdicionarMusicas(Album novoAlbum)
        {
            List<Musica> musicas = new List<Musica>();

            Console.Write("\nAdicione musicas ao album. Quantas musicas o album possui? ");
            string numMusicaString = Console.ReadLine();
            string errorMsg = "\nNumero invalido.\nDigite um numero valido para o numero de musicas: ";
            int musicCount = Int32.Parse(Utils.ValidacaoInteiroMaiorQueZero(numMusicaString, errorMsg));

            for (int i = 0; i < musicCount; i++)
            {
                Musica musicaAtual = new Musica();
                Console.WriteLine("\nMUSICA " + (i + 1));
                Console.Write("\nTitulo da musica: ");
                musicaAtual.Titulo = Console.ReadLine();

                Console.Write("\nDuracao da musica (em segundos): ");
                string duracaoMusicaString = Console.ReadLine();
                errorMsg = "\nNumero invalido.\nDigite um numero valido para a duracao da musica: ";
                musicaAtual.DuracaoEmSeg = Utils.ValidacaoInteiroMaiorQueZero(duracaoMusicaString, errorMsg);

                musicaAtual.Favorita = IsMusicaFavorita();
                musicaAtual.Banda = novoAlbum.Banda;
                musicas.Add(musicaAtual);
            }
            return musicas;
        }

        private bool IsMusicaFavorita()
        {
            Console.Write("\nDigite '1' se a musica eh favorita: ");
            return (Console.ReadLine() == "1") ? true : false;
        }

    }
}
