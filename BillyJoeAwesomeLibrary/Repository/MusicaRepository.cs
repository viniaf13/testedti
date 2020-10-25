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
        public List<Musica> PesquisarMusicaPorPropriedade(string termoPesquisa, string propriedade)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt");

            List<Musica> musicasFiltradas = new List<Musica>();
            foreach (Album album in baseDeDados)
            {
                musicasFiltradas.AddRange((album.Musicas.Where(musica => (string)Utils.GetPropertyValue(musica, propriedade) == termoPesquisa)));
            }
            return musicasFiltradas;
        }
    }
}
