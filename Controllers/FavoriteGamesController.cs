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

        // GET: api/FavoriteGames/{id?}
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<FavoriteGame>>> GetFavoriteGames(int? id = null)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteGames.Take(5).ToListAsync();
            }
            
            var favoriteGame = await _context.FavoriteGames.FindAsync(id);
            if (favoriteGame == null)
            {
                return NotFound();
            }
            
            return new List<FavoriteGame> { favoriteGame };
        }

        // POST: api/FavoriteGames
        [HttpPost]
        public async Task<ActionResult<FavoriteGame>> PostFavoriteGame(FavoriteGame favoriteGame)
        {
            _context.FavoriteGames.Add(favoriteGame);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavoriteGames), new { id = favoriteGame.Id }, favoriteGame);
        }

        // PUT: api/FavoriteGames/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteGame(int id, FavoriteGame favoriteGame)
        {
            if (id != favoriteGame.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteGame).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteGameExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/FavoriteGames/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteGame(int id)
        {
            var favoriteGame = await _context.FavoriteGames.FindAsync(id);
            if (favoriteGame == null)
            {
                return NotFound();
            }

            _context.FavoriteGames.Remove(favoriteGame);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavoriteGameExists(int id)
        {
            return _context.FavoriteGames.Any(e => e.Id == id);
        }
    }
}
