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
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Matricula> Matricula { get; set; }
        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Cadeiras> Cadeiras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoConfiguracao());
            modelBuilder.ApplyConfiguration(new SituacaoConfiguracao());
            modelBuilder.ApplyConfiguration(new UsuarioConfiguracao());
            modelBuilder.ApplyConfiguration(new MatriculaConfiguracao());
            modelBuilder.ApplyConfiguration(new AlunoConfiguracao());
            modelBuilder.ApplyConfiguration(new CadeirasConfiguracao());
        }
    }
}
