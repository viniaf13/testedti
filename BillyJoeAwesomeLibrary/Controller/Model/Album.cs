using System.Collections.Generic;

namespace BillyJoeAwesomeLibrary.Models
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Banda { get; set; }
        public string AnoLancamento { get; set; }
        public List<Musica> Musicas { get; set; }
    }
}
