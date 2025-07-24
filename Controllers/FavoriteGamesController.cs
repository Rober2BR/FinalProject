using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteGamesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteGamesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteGames
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteGame>>> GetFavoriteGames(int? id = null)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteGames.Take(5).ToListAsync();
            }

            var game = await _context.FavoriteGames.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            return Ok(new List<FavoriteGame> { game });
        }

        // POST: api/FavoriteGames
        [HttpPost]
        public async Task<ActionResult<FavoriteGame>> CreateFavoriteGame(FavoriteGame game)
        {
            _context.FavoriteGames.Add(game);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavoriteGames), new { id = game.Id }, game);
        }

        // PUT: api/FavoriteGames/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFavoriteGame(int id, FavoriteGame game)
        {
            if (id != game.Id)
            {
                return BadRequest();
            }

            _context.Entry(game).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FavoriteGameExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/FavoriteGames/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteGame(int id)
        {
            var game = await _context.FavoriteGames.FindAsync(id);
            if (game == null)
            {
                return NotFound();
            }

            _context.FavoriteGames.Remove(game);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<bool> FavoriteGameExists(int id)
        {
            return await _context.FavoriteGames.AnyAsync(e => e.Id == id);
        }
    }
}