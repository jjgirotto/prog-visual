using Microsoft.EntityFrameworkCore;
using TUT10_GRUPO_B.Models;

namespace TUT10_GRUPO_B.Data
{
    public class MusicasDbContext : DbContext
    {
        public MusicasDbContext(DbContextOptions<MusicasDbContext> options)
             : base(options) { }

        public DbSet<Musica_B> Fotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Save list of Ids for the Fotos
            List<Guid> MusicasIds = new List<Guid>() { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.Entity<Musica_B>().HasData(
                    new Musica_B(MusicasIds[0], "Pensando Bem", "5 a Seco", 199),
                    new Musica_B(MusicasIds[1], "Quadro Verde", "Rubel", 422),
                    new Musica_B(MusicasIds[2], "Tenta Acreditar", "Anavitória", 234)
            );
        }
    }
}
