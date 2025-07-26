using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class FavoriteGame
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Platform { get; set; } = string.Empty; // PC, PlayStation, Xbox, Nintendo, Mobile
        
        [Required]
        [StringLength(50)]
        public string Genre { get; set; } = string.Empty; // Action, RPG, Strategy, etc.
        
        [Range(1, 10)]
        public int Rating { get; set; } // 1-10 rating
        
        [StringLength(500)]
        public string Review { get; set; } = string.Empty;
    }
}