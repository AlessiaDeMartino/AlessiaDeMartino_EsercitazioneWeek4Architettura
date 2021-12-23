using EserWeek4.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EseWeek4.RepositoryEF.Configuration
{
    internal class SpesaConfiguration : IEntityTypeConfiguration<Spesa>
    {
        public void Configure(EntityTypeBuilder<Spesa> builder)
        {
            builder.ToTable("Spesa");
            builder.HasKey(s=> s.Id);
            builder.Property(s=>s.DataSpesa).IsRequired();
            builder.Property(s=> s.Utente).IsRequired();
            builder.Property(s => s.Importo).IsRequired();

            //Relazione Spesa:Categorie 1:n
            builder.HasOne(s => s.Categoria).WithMany(c => c.spese).HasForeignKey(s=>s.CategoriaId);
            
        }       
    }
}
