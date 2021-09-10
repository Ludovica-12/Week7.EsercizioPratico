using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;
using Week7.EsercizioPratico.RepositoryEF.Configuration;

namespace Week7.EsercizioPratico.RepositoryEF
{
    public class Context : DbContext
    {
        public DbSet<Contatto> Contatti { get; set; }
        public DbSet<Indirizzo> Indirizzi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb; Database = ContattiIndirizzi; Trusted_Connection = True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Contatto>(new ContattoConfiguration());
            modelBuilder.ApplyConfiguration<Indirizzo>(new IndirizzoConfiguration());
        }

    }
}
