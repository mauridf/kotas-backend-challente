using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Text;

namespace kotas_backend_challenge.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonController : ControllerBase
{
    private readonly string baseUrl = "https://pokeapi.co/api/v2/";

    [HttpGet("random")]
    public async Task<IActionResult> GetRandomPokemons()
    {
        var random = new Random();
        var pokemonIds = Enumerable.Range(1, 1000).OrderBy(x => random.Next()).Take(10);

        var pokemons = new List<object>();

        foreach (var id in pokemonIds)
        {
            var pokemon = await GetPokemonById(id);
            if (pokemon != null)
            {
                pokemons.Add(pokemon);
            }
        }

        return Ok(pokemons);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetPokemonById(int id)
    {
        var client = new RestClient(baseUrl);
        var request = new RestRequest($"pokemon/{id}", Method.Get);

        var response = await client.ExecuteAsync(request);
        if (!response.IsSuccessful) return NotFound();

        var pokemon = JObject.Parse(response.Content);
        var base64Sprite = Convert.ToBase64String(Encoding.Default.GetBytes(pokemon["sprites"]["front_default"].ToString()));

        return Ok(new
        {
            Id = pokemon["id"],
            Nome = pokemon["name"],
            Evolucoes = pokemon["species"],
            SpriteBase64 = base64Sprite
        });
    }
}
