using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class CadeirasConfiguracao : IEntityTypeConfiguration<Cadeiras>
    {
        public void Configure(EntityTypeBuilder<Cadeiras> builder)
        {
            builder.ToTable("Cadeiras");
            builder.HasKey("Id");
            builder.Property(c => c.Descricao).HasColumnName("Descricao").HasMaxLength(150);
            builder.Property(c => c.MatriculaId).HasColumnName("MatriculaId").IsRequired();
        }
    }
}
