using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class AlunoConfiguracao : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
            builder.HasKey("Id");
            builder.Property(a => a.Nome).HasColumnName("Nome").HasMaxLength(150).IsRequired();
            builder.Property(a => a.SituacaoId).HasColumnName("SituacaoId").IsRequired();
        }
    }
}
