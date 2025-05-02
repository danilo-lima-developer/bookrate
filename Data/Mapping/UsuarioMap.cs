using BookRate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookRate.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("USUARIO");

            builder.HasKey(u => u.IdUsuario)
                .HasName("ID_USUARIO");

            builder.Property(u => u.IdUsuario)
                .HasColumnName("ID_USUARIO");
            builder.Property(u => u.Cpf)
                .HasColumnName("CPF")
                .IsRequired()
                .HasMaxLength(11);
            builder.Property(u => u.Nome)
                   .HasColumnName("NOME")
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}
