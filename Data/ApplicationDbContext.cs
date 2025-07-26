using Microsoft.EntityFrameworkCore;
using FinalProject.Models;

namespace FinalProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<FavoriteGame> FavoriteGames { get; set; }
        public DbSet<FavoriteMusicGenre> FavoriteMusicGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Seed data for demonstration
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember 
                { 
                    Id = 1, 
                    FullName = "John Smith", 
                    Birthdate = new DateTime(2001, 5, 15), 
                    CollegeProgram = "Computer Science", 
                    YearInProgram = "Junior",
                    Email = "john.smith@email.com"
                }
            );
            
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby 
                { 
                    Id = 1, 
                    Name = "Programming", 
                    Description = "Building software applications", 
                    Category = "Creative", 
                    SkillLevel = 7, 
                    IsActive = true 
                }
            );
            
            modelBuilder.Entity<FavoriteGame>().HasData(
                new FavoriteGame 
                { 
                    Id = 1, 
                    Title = "The Legend of Zelda: Breath of the Wild", 
                    Platform = "Nintendo Switch", 
                    Genre = "Action-Adventure", 
                    Rating = 10, 
                    Review = "Absolutely incredible open-world experience!" 
                }
            );
            
            modelBuilder.Entity<FavoriteMusicGenre>().HasData(
                new FavoriteMusicGenre 
                { 
                    Id = 1, 
                    GenreName = "Progressive Rock", 
                    Description = "Complex compositions with artistic expression", 
                    FavoriteArtist = "Pink Floyd", 
                    PreferenceLevel = 9, 
                    RecommendedSong = "Comfortably Numb" 
                }
            );
        }
    }
}
