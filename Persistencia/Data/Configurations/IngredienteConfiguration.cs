using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class IngredienteConfiguration : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingrediente");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();
             
            builder.Property(p => p.Nombre)
           .IsRequired()
           .HasMaxLength(50);

           builder.Property(p => p.Descripcion)
          .IsRequired()
          .HasMaxLength(100);

          builder.Property(p => p.Precio)
          .IsRequired()
          .HasMaxLength(30);

          builder.Property(p => p.Stock)
          .IsRequired()
          .HasMaxLength(100);
        }
    }
}