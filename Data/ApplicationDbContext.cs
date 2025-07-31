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
                    FullName = "Team Member 2 - [Replace with actual name]", 
                    Birthdate = new DateTime(2002, 3, 22), 
                    CollegeProgram = "Software Engineering", 
                    YearInProgram = "Sophomore",
                    Email = "member2@email.com"
                },
                new TeamMember 
                { 
                    Id = 3, 
                    FullName = "Team Member 3 - [Replace with actual name]", 
                    Birthdate = new DateTime(2000, 11, 8), 
                    CollegeProgram = "Information Technology", 
                    YearInProgram = "Senior",
                    Email = "member3@email.com"
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
                    Name = "Rock Climbing", 
                    Description = "Indoor and outdoor climbing adventures", 
                    Category = "Outdoor", 
                    SkillLevel = 6, 
                    IsActive = true 
                },
                new Hobby 
                { 
                    Id = 3, 
                    Name = "Photography", 
                    Description = "Capturing moments and landscapes", 
                    Category = "Creative", 
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
                    Title = "Elden Ring", 
                    Platform = "PC", 
                    Genre = "Action RPG", 
                    Rating = 9, 
                    Review = "Challenging and rewarding souls-like with amazing world design." 
                },
                new FavoriteGame 
                { 
                    Id = 3, 
                    Title = "Cyberpunk 2077", 
                    Platform = "PlayStation 5", 
                    Genre = "RPG", 
                    Rating = 8, 
                    Review = "Great story and visuals, much improved after updates." 
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
                    GenreName = "Hip Hop", 
                    Description = "Rhythmic spoken lyrics with strong beats and social commentary", 
                    FavoriteArtist = "Kendrick Lamar", 
                    PreferenceLevel = 8, 
                    RecommendedSong = "HUMBLE." 
                },
                new FavoriteMusicGenre 
                { 
                    Id = 3, 
                    GenreName = "Electronic", 
                    Description = "Digital music with synthesized sounds and electronic beats", 
                    FavoriteArtist = "Daft Punk", 
                    PreferenceLevel = 9, 
                    RecommendedSong = "One More Time" 
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
