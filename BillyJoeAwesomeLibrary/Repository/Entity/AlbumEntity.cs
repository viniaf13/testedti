using System;
using System.Collections.Generic;
using System.Text;

namespace BillyJoeAwesomeLibrary.Repository.Entity
{
    class AlbumEntity
    {
        public string Titulo { get; set; }
        public string Banda { get; set; }
        public int AnoLancamento { get; set; }
        public List<MusicaEntity> Musicas { get; set; }
    }
}
