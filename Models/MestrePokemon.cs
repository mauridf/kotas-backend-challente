namespace kotas_backend_challenge.Models;

public class MestrePokemon
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Cpf { get; set; }
    public List<PokemonCapturado>? PokemonsCapturados { get; set; }
}
