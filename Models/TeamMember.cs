using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;
        
        [Required]
        public DateTime Birthdate { get; set; }
        
        [Required]
        [StringLength(100)]
        public string CollegeProgram { get; set; } = string.Empty;
        
        [Required]
        [StringLength(20)]
        public string YearInProgram { get; set; } = string.Empty; // Freshman, Sophomore, Junior, Senior, Graduate
        
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
    }
}