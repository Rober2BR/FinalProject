using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FavoriteMusicGenresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FavoriteMusicGenresController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/FavoriteMusicGenres
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FavoriteMusicGenre>>> GetFavoriteMusicGenres(int? id = null)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteMusicGenres.Take(5).ToListAsync();
            }

            var genre = await _context.FavoriteMusicGenres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            return Ok(new List<FavoriteMusicGenre> { genre });
        }

        // POST: api/FavoriteMusicGenres
        [HttpPost]
        public async Task<ActionResult<FavoriteMusicGenre>> CreateFavoriteMusicGenre(FavoriteMusicGenre genre)
        {
            _context.FavoriteMusicGenres.Add(genre);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavoriteMusicGenres), new { id = genre.Id }, genre);
        }

        // PUT: api/FavoriteMusicGenres/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFavoriteMusicGenre(int id, FavoriteMusicGenre genre)
        {
            if (id != genre.Id)
            {
                return BadRequest();
            }

            _context.Entry(genre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await FavoriteMusicGenreExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/FavoriteMusicGenres/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteMusicGenre(int id)
        {
            var genre = await _context.FavoriteMusicGenres.FindAsync(id);
            if (genre == null)
            {
                return NotFound();
            }

            _context.FavoriteMusicGenres.Remove(genre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private async Task<bool> FavoriteMusicGenreExists(int id)
        {
            return await _context.FavoriteMusicGenres.AnyAsync(e => e.Id == id);
        }
    }
}