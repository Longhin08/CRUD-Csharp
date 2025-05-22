namespace CRUD.Models
{
    public class Pessoa
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public string Instrumento { get; set; }

        public Pessoa(Guid id, string nome, string instrumento)
        {
            Id = id;
            Nome = nome;
            Instrumento = instrumento;
        }
        
    }
}
