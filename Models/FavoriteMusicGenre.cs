using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class FavoriteMusicGenre
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string MusicGenre { get; set; } = string.Empty;
        
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        
        public DateTime? UpdatedDate { get; set; }
        
        public bool IsActive { get; set; } = true;
    }
}