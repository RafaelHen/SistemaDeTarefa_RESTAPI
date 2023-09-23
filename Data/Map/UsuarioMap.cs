using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaDeTarefa.Models;

namespace SistemaDeTarefa.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.email).HasMaxLength(150);
        }
    }
}
