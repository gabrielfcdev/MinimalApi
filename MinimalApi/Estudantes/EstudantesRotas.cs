using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using MinimalApi.Data;

namespace MinimalApi.Estudantes
{
    public static class EstudantesRotas
    {

        public static void AddRotasEstudantes(this WebApplication app)
        {

            var rotasEstudantes = app.MapGroup(prefix: "estudantes");

            rotasEstudantes.MapPost(pattern:"", handler:async (AddEstudanteRequest request, AppDbContext context) =>
            {
                var novoEstudante = new Estudante(request.Nome);
                await context.Estudantes.AddAsync(novoEstudante);
                await context.SaveChangesAsync();
            });

        }
    }
}
