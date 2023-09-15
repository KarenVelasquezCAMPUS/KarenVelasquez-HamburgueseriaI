using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class HamburguesaConfiguration : IEntityTypeConfiguration<Hamburguesa>
    {
        public void Configure(EntityTypeBuilder<Hamburguesa> builder)
        {
            builder.ToTable("Hamburguesa");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
            .IsRequired();

            builder.Property(p => p.Nombre)
           .IsRequired()
           .HasMaxLength(50);

           builder.Property(p => p.Precio)
           .IsRequired()
           .HasMaxLength(30);

           builder.HasOne(p => p.Categoria)
           .WithMany(p => p.Hamburguesas)
           .HasForeignKey(p => p.CategoriaFk);

            builder.HasOne(p => p.Chef)
            .WithMany(p => p.Hamburguesas)
            .HasForeignKey(p => p.ChefFk);

            builder
            .HasMany(p => p.Ingredientes)
            .WithMany(p => p.Hamburguesas)
            .UsingEntity<HamburguesaIngrediente>(
            j => j
            .HasOne(pt => pt.Ingrediente)
            .WithMany(t => t.HamburguesaIngrediente)
            .HasForeignKey(pt => pt.IngredienteId),
            j => j
            .HasOne(pt => pt.Hamburguesa)
            .WithMany(t => t.HamburguesaIngredientes)
            .HasForeignKey(pt => pt.HamburguesaId),
            j => 
            {
                j.HasKey(t => new {t.HamburguesaId, t.IngredienteId});
            });
        }
    }
}