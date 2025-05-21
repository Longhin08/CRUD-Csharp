namespace CRUD.Rotas
{
    public static class PessoaRotas
    {
        public static void MapPessoaRotas (this WebApplication app)
        {
            app.MapGet("/hello-World", () => new { Nome = "João" });
        }
    }
}
