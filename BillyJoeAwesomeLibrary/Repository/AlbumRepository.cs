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
            if (Utils.ReadFromJsonFile<List<Album>>(path + Constants.FILE_NAME) != null)
            {
                baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + Constants.FILE_NAME);
            }
            baseDeDados.Add(album);
            Utils.WriteToJsonFile<List<Album>>(path + Constants.FILE_NAME, baseDeDados);
        }

        public List<Album> PesquisarAlbumPorPropriedade(string termoPesquisa, string propriedadeAlbum)
        {
            string path = Directory.GetCurrentDirectory();
            List<Album> baseDeDados = Utils.ReadFromJsonFile<List<Album>>(path + Constants.FILE_NAME);
            List<Album> albunsFiltrados = new List<Album>();
            if (baseDeDados != null)
            {
                foreach (Album album in baseDeDados)
                {
                    if ((string)Utils.GetPropertyValue(album, propriedadeAlbum) == termoPesquisa)
                    {
                        albunsFiltrados.Add(album);
                    }
                }
            }
            return albunsFiltrados;
        }
    }
}


