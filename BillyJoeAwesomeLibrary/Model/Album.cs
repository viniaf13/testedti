using System;
using System.Collections.Generic;
using System.Text;

namespace BillyJoeAwesomeLibrary.Models
{
    class Album
    {
        public string Titulo { get; set; }
        public string Banda { get; set; }
        public int AnoLancamento { get; set; }
        public List<Musica> Musicas { get; set; }
    }
}
