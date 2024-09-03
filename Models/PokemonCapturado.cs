namespace kotas_backend_challenge.Models;

public class PokemonCapturado
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public DateTime DataCaptura { get; set; }
    public int MestrePokemonId { get; set; }
    public MestrePokemon? MestrePokemon { get; set; }
}