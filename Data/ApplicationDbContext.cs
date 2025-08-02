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
            
            // Seed data for all team members and their preferences
            
            // Team Members - Replace with actual team member information
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember 
                { 
                    Id = 1, 
                    FullName = "Brandon Roberts", 
                    Birthdate = new DateTime(1989, 4, 24), 
                    CollegeProgram = "IT Certificate", 
                    YearInProgram = "Freshman",
                    Email = "rober2br@mail.uc.edu"
                },
                new TeamMember 
                { 
                    Id = 2, 
                    FullName = "Jared Forsythe", 
                    Birthdate = new DateTime(1992, 1, 30), 
                    CollegeProgram = "Information Technology", 
                    YearInProgram = "Freshman",
                    Email = "forsytjd@mail.uc.edu"
                },
                new TeamMember 
                { 
                    Id = 3, 
                    FullName = "Michael Doster", 
                    Birthdate = new DateTime(1976, 09, 12), 
                    CollegeProgram = "Information Technology", 
                    YearInProgram = "Senior",
                    Email = "dosterma@mail.uc.edu"
                },
                new TeamMember 
                { 
                    Id = 4, 
                    FullName = "Kyler Hayes", 
                    Birthdate = new DateTime(2004, 10, 13), 
                    CollegeProgram = "Information Technology", 
                    YearInProgram = "Sophomore",
                    Email = "hayes2k4@mail.uc.edu"
                }
            );
            
            // Hobbies - Sample data for team members
            modelBuilder.Entity<Hobby>().HasData(
                new Hobby 
                { 
                    Id = 1, 
                    Name = "Gaming", 
                    Description = "Playing games including World of Warcraft, Fallout 76 and Magic the Gathering", 
                    Category = "Creative", 
                    SkillLevel = 4, 
                    IsActive = true 
                },
                new Hobby 
                { 
                    Id = 2, 
                    Name = "Lifting", 
                    Description = "Lifting weights in home gym, targetted towards gaining strength", 
                    Category = "Sports", 
                    SkillLevel = 8, 
                    IsActive = true 
                },
                new Hobby 
                { 
                    Id = 3, 
                    Name = "Traveling", 
                    Description = "Around the world", 
                    Category = "Travel", 
                    SkillLevel = 8, 
                    IsActive = true 
                },
                new Hobby 
                { 
                    Id = 4, 
                    Name = "Gaming", 
                    Description = "Playing various video games across different platforms", 
                    Category = "Indoor", 
                    SkillLevel = 9, 
                    IsActive = true 
                }
            );
            
            // Favorite Games - Sample data for team members
            modelBuilder.Entity<FavoriteGame>().HasData(
                new FavoriteGame 
                { 
                    Id = 1, 
                    Title = "Magic The Gathering", 
                    Platform = "Tabletop Card Game", 
                    Genre = "Trading Card Game", 
                    Rating = 8, 
                    Review = "Fun to play can be very expensive though" 
                },
                new FavoriteGame 
                { 
                    Id = 2, 
                    Title = "NBA2k", 
                    Platform = "Xbox", 
                    Genre = "Sports", 
                    Rating = 8, 
                    Review = "Fun and challenging to play against others." 
                },
                new FavoriteGame 
                { 
                    Id = 3, 
                    Title = "Far Cry 3", 
                    Platform = "Xbox 360", 
                    Genre = "FPS", 
                    Rating = 8, 
                    Review = "Classic" 
                },
                new FavoriteGame 
                { 
                    Id = 4, 
                    Title = "Minecraft", 
                    Platform = "PC", 
                    Genre = "Sandbox", 
                    Rating = 9, 
                    Review = "Endless creativity and fun with friends. Never gets old!" 
                }
            );
            
            // Favorite Music Genres - Sample data for team members
            modelBuilder.Entity<FavoriteMusicGenre>().HasData(
                new FavoriteMusicGenre 
                { 
                    Id = 1, 
                    GenreName = "Metal", 
                    Description = "Heavier beats and dark tones", 
                    FavoriteArtist = "Avenged Sevenfold", 
                    PreferenceLevel = 9, 
                    RecommendedSong = "Nightmare" 
                },
                new FavoriteMusicGenre 
                { 
                    Id = 2, 
                    GenreName = "Pop Punk", 
                    Description = "Fast-paced, energetic sound", 
                    FavoriteArtist = "Fall Out Boy", 
                    PreferenceLevel = 8, 
                    RecommendedSong = "Saturday"  
                },
                new FavoriteMusicGenre 
                { 
                    Id = 3, 
                    GenreName = "ALT", 
                    Description = "New bands and new music styles", 
                    FavoriteArtist = "Matt Maeson", 
                    PreferenceLevel = 9, 
                    RecommendedSong = "Cringe" 
                },
                new FavoriteMusicGenre 
                { 
                    Id = 4, 
                    GenreName = "Indie Rock", 
                    Description = "Alternative rock with independent, creative approach", 
                    FavoriteArtist = "Arctic Monkeys", 
                    PreferenceLevel = 7, 
                    RecommendedSong = "Do I Wanna Know?"
                }
            );
        }
    }
}
