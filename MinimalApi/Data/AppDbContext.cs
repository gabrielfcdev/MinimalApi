using Microsoft.EntityFrameworkCore;
using MinimalApi.Estudantes;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace MinimalApi.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Estudante> Estudantes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlite("Data Source=Banco.sqlite")
                .LogTo(Console.WriteLine, LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }


    }
}
