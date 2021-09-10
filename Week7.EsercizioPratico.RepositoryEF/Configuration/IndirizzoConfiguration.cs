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
    internal class IndirizzoConfiguration : IEntityTypeConfiguration<Indirizzo>
    {
        public void Configure(EntityTypeBuilder<Indirizzo> modelBuilder)
        {
            modelBuilder.ToTable("Indirizzi");
            modelBuilder.HasKey(i => i.IndirizzoID);
            modelBuilder.Property(i => i.Tipologia).IsRequired();
            modelBuilder.Property(i => i.Via).IsRequired();
            modelBuilder.Property(i => i.Citta).IsRequired();
            modelBuilder.Property(i => i.CAP).IsRequired();
            modelBuilder.Property(i => i.Provincia).IsRequired();
            modelBuilder.Property(i => i.Nazione).IsRequired();

            //Relazione Contatto 1 -> Indirizzi n
            modelBuilder.HasOne(i => i.Contatto).WithMany(c => c.Indirizzi).HasForeignKey(c => c.ContattoID);

        }
    }
}
