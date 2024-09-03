using Microsoft.EntityFrameworkCore;
using kotas_backend_challenge.Models;

namespace kotas_backend_challenge.Data;

public class PokemonContext : DbContext
{
    public PokemonContext(DbContextOptions<PokemonContext> options) : base(options) { }

    public DbSet<MestrePokemon> MestresPokemon { get; set; }
    public DbSet<PokemonCapturado> PokemonsCapturados { get; set; }
}