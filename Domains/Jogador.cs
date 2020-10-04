using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class Jogador : BaseDomains
    {
        public string Name { get; set; }
        private string  Passoword { get; set; }
        public DateTime DateBirth { get; set; }

        public List<JogosJogadores> JogosJogadores { get; set; }

    }
}
