namespace OData.Modelo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int SituacaoId { get; set; }
        public Situacao Situacao { get; set; }
    }
}
