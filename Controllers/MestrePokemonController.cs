using Microsoft.AspNetCore.Mvc;
using kotas_backend_challenge.Data;
using kotas_backend_challenge.Models;

namespace kotas_backend_challenge.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MestrePokemonController : ControllerBase
{
    private readonly PokemonContext _context;

    public MestrePokemonController(PokemonContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> PostMestrePokemon(MestrePokemon mestre)
    {
        _context.MestresPokemon.Add(mestre);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetMestrePokemon), new { id = mestre.Id }, mestre);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetMestrePokemon(int id)
    {
        var mestre = await _context.MestresPokemon.FindAsync(id);
        if (mestre == null)
        {
            return NotFound();
        }
        return Ok(mestre);
    }
}
