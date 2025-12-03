using PrePaidCard_B.Models;

namespace PrePaidCard_B.Data
{
    public static class SeedCards_B
    {
        public static List<PrePaidCard_BA> Seed() => new()
        {
            new PrePaidCard_BA("Bruno Teixeira", 1000m),
            new PrePaidCard_BA("José Cordeiro", 1500m),
            new PrePaidCard_BA("Vitor Xavier", 2000.50m)
        };
    }
}
