using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class CursoConfiguracao : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("Curso");

            builder.HasKey(c => c.Id).HasName("Id");
            
            builder.Property(c => c.Nome).HasColumnName("Nome").HasMaxLength(255).IsRequired();
            builder.Property(c => c.SituacaoId).HasColumnName("SituacaoId");
        }
    }
}
