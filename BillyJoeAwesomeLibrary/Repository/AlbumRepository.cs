using BillyJoeAwesomeLibrary.Helper;
using BillyJoeAwesomeLibrary.Models;
using BillyJoeAwesomeLibrary.Repository.Interface;
using System.Collections.Generic;
using System.IO;

namespace BillyJoeAwesomeLibrary.Repository
{
    public class AlbumRepository : IAlbumRepository
    {
        public void CadastrarAlbum(Album album)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = new List<Album>();
            if (Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt") != null)
            {
                baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt");
            }
            baseDeDados.Add(album);
            Utils.WriteToJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt", baseDeDados);
        }

        public List<Album> PesquisarAlbumPorPropriedade(string termoPesquisa, string propriedadeAlbum)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + "\\BibliotecaDoBillie.txt");
            List<Album> albunsFiltrados = new List<Album>();
            foreach (Album album in baseDeDados)
            {
                if ((string)Utils.GetPropertyValue(album, propriedadeAlbum) == termoPesquisa)
                {
                    albunsFiltrados.Add(album);
                }
            }
            return albunsFiltrados;
        }
    }
}


