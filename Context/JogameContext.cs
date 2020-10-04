using Jogame.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Context
{
    public class JogameContext : DbContext
    {
        public DbSet<Jogador> Jogador { get; set; }
        public DbSet<Jogo> Jogo { get; set; }
        public DbSet<JogosJogadores> JogosJogadores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=VINICIUS\SQLEXPRESS;Initial Catalog=Jogame;User ID=sa;Password=sa132");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
