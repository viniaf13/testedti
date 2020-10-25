using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BillyJoeAwesomeLibrary.Repository
{
    public class MusicaRepository : IMusicaRepository
    {
        public List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + Constants.FILE_NAME);

            List<Musica> musicasFiltradas = new List<Musica>();
            if (baseDeDados != null)
            {
                foreach (Album album in baseDeDados)
                {
                    musicasFiltradas.AddRange((album.Musicas.Where(musica => (string)Utils.GetPropertyValue(musica, propriedade) == termoPesquisa)));
                }
            }
            return musicasFiltradas;
        }

        public List<Musica> BuscarTodasMusicas()
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + Constants.FILE_NAME);
            List<Musica> todasMusicas = new List<Musica>();
            if (baseDeDados != null)
            {
                foreach (Album album in baseDeDados)
                {
                    todasMusicas.AddRange(album.Musicas);
                }
            }
            return todasMusicas;
        }
    }
}
