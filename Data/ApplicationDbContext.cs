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
        public DbSet<FavoriteMusicGenre> FavoriteMusicGenres { get; set; }
        public DbSet<FavoriteGame> FavoriteGames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "John Doe", Birthdate = new DateTime(2000, 5, 15), CollegeProgram = "Computer Science", YearInProgram = "Junior", Email = "john.doe@email.com" },
                new TeamMember { Id = 2, FullName = "Jane Smith", Birthdate = new DateTime(1999, 8, 22), CollegeProgram = "Information Technology", YearInProgram = "Senior", Email = "jane.smith@email.com" }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby { Id = 1, HobbyName = "Programming", CreatedDate = DateTime.Now, IsActive = true },
                new Hobby { Id = 2, HobbyName = "Gaming", CreatedDate = DateTime.Now, IsActive = true },
                new Hobby { Id = 3, HobbyName = "Reading", CreatedDate = DateTime.Now, IsActive = true }
            );

            modelBuilder.Entity<FavoriteMusicGenre>().HasData(
                new FavoriteMusicGenre { Id = 1, MusicGenre = "Rock", CreatedDate = DateTime.Now, IsActive = true },
                new FavoriteMusicGenre { Id = 2, MusicGenre = "Jazz", CreatedDate = DateTime.Now, IsActive = true },
                new FavoriteMusicGenre { Id = 3, MusicGenre = "Classical", CreatedDate = DateTime.Now, IsActive = true }
            );

            modelBuilder.Entity<FavoriteGame>().HasData(
                new FavoriteGame { Id = 1, Game = "The Legend of Zelda", CreatedDate = DateTime.Now, IsActive = true },
                new FavoriteGame { Id = 2, Game = "Minecraft", CreatedDate = DateTime.Now, IsActive = true },
                new FavoriteGame { Id = 3, Game = "Super Mario Bros", CreatedDate = DateTime.Now, IsActive = true }
            );
        }
    }
}