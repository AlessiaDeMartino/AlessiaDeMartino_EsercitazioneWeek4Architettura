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
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeCategoria).IsRequired();

            //Relazione Spesa:Categorie 1:n
            builder.HasMany(c => c.spese).WithOne(s => s.Categoria).HasForeignKey(s=>s.CategoriaId);
        }
    }
}
