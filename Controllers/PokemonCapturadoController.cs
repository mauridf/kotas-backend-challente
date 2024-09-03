using Microsoft.AspNetCore.Mvc;
using kotas_backend_challenge.Data;
using kotas_backend_challenge.Models;
using System.Data.Entity;

namespace kotas_backend_challenge.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PokemonCapturadoController : ControllerBase
{
    private readonly PokemonContext _context;

    public PokemonCapturadoController(PokemonContext context)
    {
        _context = context;
    }

    [HttpPost("capturar")]
    public async Task<IActionResult> CapturarPokemon(PokemonCapturado pokemon)
    {
        _context.PokemonsCapturados.Add(pokemon);
        await _context.SaveChangesAsync();
        return Ok(pokemon);
    }

    [HttpGet("capturados")]
    public async Task<IActionResult> GetPokemonsCapturados()
    {
        var pokemons = await _context.PokemonsCapturados.ToListAsync();
        return Ok(pokemons);
    }
}
