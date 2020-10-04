using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class Jogo : BaseDomains
    {
        
        public  string Name { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }

        public List<JogosJogadores> JogosJogadores { get; set; }

    }

}
