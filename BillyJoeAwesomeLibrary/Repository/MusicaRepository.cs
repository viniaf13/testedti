using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BillyJoeAwesomeLibrary.Repository
{
    public class MusicaRepository : IMusicaRepository
    {
        public List<Musica> PesquisarMusicaPorBanda(string termoPesquisa)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt");
            List<Musica> musicasFiltradas = new List<Musica>();
            foreach (Album album in baseDeDados)
            {
                if (album.Banda == termoPesquisa)
                {
                    foreach(Musica musica in album.Musicas)
                    {
                        musicasFiltradas.Add(musica);
                    }
                }
            } 
            return musicasFiltradas;
        }

        public List<Musica> PesquisarMusicaPorTitulo(string termoPesquisa)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt");

            List<Musica> musicasFiltradas = new List<Musica>();
            foreach (Album album in baseDeDados)
            {
                musicasFiltradas.AddRange((album.Musicas.Where(musica => musica.Titulo == termoPesquisa)));
            }
            return musicasFiltradas;
        }


    }
}
