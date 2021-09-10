using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.EsercizioPratico.Core.Entites;

namespace Week7.EsercizioPratico.RepositoryEF.Configuration
{
    internal class ContattoConfiguration : IEntityTypeConfiguration<Contatto>
    {
        public void Configure(EntityTypeBuilder<Contatto> modelBuilder)
        {
            modelBuilder.ToTable("Contatti");
            modelBuilder.HasKey(c => c.ContattoID);
            modelBuilder.Property(c => c.Nome);
            modelBuilder.Property(c => c.Cognome);

            //Relazione Contatto 1 -> Indirizzi n
            modelBuilder.HasMany(i => i.Indirizzi).WithOne(c => c.Contatto).HasForeignKey(c => c.ContattoID);

        }
    }
}
