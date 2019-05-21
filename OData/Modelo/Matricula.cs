using System;

namespace OData.Modelo
{
    public class Matricula
    {
        public int Id { get; set; }
        public int AlunoId { get; set; }
        public int CursoId { get; set; }
        public int SituacaoId { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public Aluno Aluno { get; set; }
        public Curso Curso { get; set; }
        public Situacao Situacao { get; set; }
    }
}
