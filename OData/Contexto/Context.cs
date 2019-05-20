using Microsoft.EntityFrameworkCore;
using OData.Modelo;
using OData.Modelo.Configuracao;

namespace OData.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Situacao> Situacao { get; set; }
        public DbSet<Curso> Curso { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoConfiguracao());
            modelBuilder.ApplyConfiguration(new SituacaoConfiguracao());
        }
    }
}
