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

        // GET: api/FavoriteMusicGenres/{id?}
        [HttpGet("{id?}")]
        public async Task<ActionResult<IEnumerable<FavoriteMusicGenre>>> GetFavoriteMusicGenres(int? id = null)
        {
            if (id == null || id == 0)
            {
                return await _context.FavoriteMusicGenres.Take(5).ToListAsync();
            }
            
            var favoriteMusicGenre = await _context.FavoriteMusicGenres.FindAsync(id);
            if (favoriteMusicGenre == null)
            {
                return NotFound();
            }
            
            return new List<FavoriteMusicGenre> { favoriteMusicGenre };
        }

        // POST: api/FavoriteMusicGenres
        [HttpPost]
        public async Task<ActionResult<FavoriteMusicGenre>> PostFavoriteMusicGenre(FavoriteMusicGenre favoriteMusicGenre)
        {
            _context.FavoriteMusicGenres.Add(favoriteMusicGenre);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFavoriteMusicGenres), new { id = favoriteMusicGenre.Id }, favoriteMusicGenre);
        }

        // PUT: api/FavoriteMusicGenres/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFavoriteMusicGenre(int id, FavoriteMusicGenre favoriteMusicGenre)
        {
            if (id != favoriteMusicGenre.Id)
            {
                return BadRequest();
            }

            _context.Entry(favoriteMusicGenre).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FavoriteMusicGenreExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/FavoriteMusicGenres/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFavoriteMusicGenre(int id)
        {
            var favoriteMusicGenre = await _context.FavoriteMusicGenres.FindAsync(id);
            if (favoriteMusicGenre == null)
            {
                return NotFound();
            }

            _context.FavoriteMusicGenres.Remove(favoriteMusicGenre);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FavoriteMusicGenreExists(int id)
        {
            return _context.FavoriteMusicGenres.Any(e => e.Id == id);
        }
    }
}
