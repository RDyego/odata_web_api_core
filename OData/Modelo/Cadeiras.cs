namespace OData.Modelo
{
    public class Cadeiras
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int MatriculaId { get; set; }
        public Matricula Matricula { get; set; }
    }
}
