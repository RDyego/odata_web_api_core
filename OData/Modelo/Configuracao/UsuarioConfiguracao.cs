using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class UsuarioConfiguracao : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey("Id");
            builder.Property(u => u.Nome).HasColumnName("Nome").HasMaxLength(150);
            builder.Property(u => u.UsuarioAcesso).HasColumnName("Usuario").HasMaxLength(30);
            builder.Property(u => u.Senha).HasColumnName("Senha").HasMaxLength(50);
        }
    }
}
