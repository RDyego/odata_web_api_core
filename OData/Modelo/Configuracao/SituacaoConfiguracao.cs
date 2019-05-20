using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class SituacaoConfiguracao : IEntityTypeConfiguration<Situacao>
    {
        public void Configure(EntityTypeBuilder<Situacao> builder)
        {
            builder.HasKey(s => s.Id).HasName("Id");
            //builder.HasOne<Curso>(c => c.Curso).WithOne(ad => ad.Situacao).HasForeignKey<Curso>(ad => ad.SituacaoId);
            builder.Property(s => s.Descricao).HasColumnName("Descricao").HasMaxLength(50);
        }
    }
}
