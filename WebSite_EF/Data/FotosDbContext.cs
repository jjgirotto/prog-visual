using Microsoft.EntityFrameworkCore;
using WebSite_EF.Models;

namespace WebSite_EF.Data
{
    public class FotosDbContext : DbContext
    {
        public FotosDbContext(DbContextOptions<FotosDbContext> options) : base(options) { }

        public DbSet<Foto> Fotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Save list of Ids for the Fotos
            List<Guid> FotoIds = new List<Guid>() { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.Entity<Foto>().HasData(
                    new Foto
                    {
                        FotoId = FotoIds[0],
                        Codigo = 123455,
                        Titulo = "Terra",
                        Autor = "Sebastião Salgado",
                        Preco = 500.00M

                    },
                    new Foto
                    {
                        FotoId = FotoIds[1],
                        Codigo = 123466,
                        Titulo = "Lisboa",
                        Autor = "Eduardo Gageiro ",
                        Preco = 100.00M

                    },
                    new Foto
                    {
                        FotoId = FotoIds[2],
                        Codigo = 123477,
                        Titulo = "Lisboa",
                        Autor = "Eduardo Gageiro ",
                        Preco = 100.00M
                    }
            );
        }
    }
}
