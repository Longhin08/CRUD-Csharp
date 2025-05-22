using CRUD.Models;


namespace CRUD.Rotas
{
    public static class PessoaRotas
    {
        public static List<Pessoa> Pessoas = new()
        {
            new (id: Guid.NewGuid(), nome: "John Frusciante", instrumento: "Guitarra"  ),
            new (id: Guid.NewGuid(), nome: "Anthony Kiedis", instrumento: "Voz"),
            new (id: Guid.NewGuid(), nome: "Chad Smith", instrumento: "Bateria"),
            new (id: Guid.NewGuid(), nome: "(Flea) Michael Peter", instrumento: "Baixo")

        };
        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapGet("/rhcp", () => Pessoas);

            app.MapGet("/rhcp/{nome}", (string nome) =>
            {
                return Pessoas.Find(x => x.Nome == nome);
            });
        }
    }
}
