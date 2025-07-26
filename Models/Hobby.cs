using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Hobby
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string Description { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty; // Indoor, Outdoor, Creative, Sports, etc.
        
        [Range(1, 10)]
        public int SkillLevel { get; set; } // 1-10 scale
        
        public bool IsActive { get; set; } = true;
    }
}