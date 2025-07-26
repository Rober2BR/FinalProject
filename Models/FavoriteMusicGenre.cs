using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class FavoriteMusicGenre
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(50)]
        public string GenreName { get; set; } = string.Empty; // Rock, Hip-Hop, Classical, etc.
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        [StringLength(100)]
        public string FavoriteArtist { get; set; } = string.Empty;
        
        [Range(1, 10)]
        public int PreferenceLevel { get; set; } // 1-10 how much you like this genre
        
        [StringLength(200)]
        public string RecommendedSong { get; set; } = string.Empty;
    }
}