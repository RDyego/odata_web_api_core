using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OData.Modelo.Configuracao
{
    public class MatriculaConfiguracao : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder)
        {
            builder.ToTable("Matricula");
            builder.HasKey("Id");
            builder.Property(m => m.AlunoId).HasColumnName("AlunoId").IsRequired();
            builder.Property(m => m.CursoId).HasColumnName("CursoId").IsRequired();
            builder.Property(m => m.SituacaoId).HasColumnName("SituacaoId").IsRequired();
            builder.Property(m => m.DtInicio).HasColumnName("DtPeriodoInicio");
            builder.Property(m => m.DtFim).HasColumnName("DtPeriodoFim");
        }
    }
}
