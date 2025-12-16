using GameStoreApi.Entities;
using Microsoft.EntityFrameworkCore;

// dotnet add package Microsoft.EntityFrameworkCore --version 9.0.3
// dotnet tool install --global dotnet-ef --version 9.0.3
// dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.3

// dotnet ef migrations add InitialCreate --output-dir Data\Migrations
// dotnet ef database update
// dotnet ef migrations add SeedGenres --output-dir Data\Migrations

namespace GameStoreApi.Data;

public class GameStoreContext(DbContextOptions<GameStoreContext> options)
:DbContext(options)
{
    public DbSet<Game> Games => Set<Game>();
    public DbSet<Genre> Genres => Set<Genre>();
    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Genre>().HasData( 
            new { Id = 1, Name = "Fighting" },
            new { Id = 3, Name = "Roleplaying"},
            new { Id = 2, Name = "Action" },
            new { Id = 4, Name = "Sports" },
            new { Id = 5, Name = "Adventure" },
            new { Id = 6, Name = "Strategy" },
            new { Id = 7, Name = "Simulation" },
            new { Id = 8, Name = "Puzzle" },
            new { Id = 9, Name = "MMO" },
            new { Id = 10, Name = "Racing" },
            new { Id = 11, Name = "Shooter" },
            new {Id = 12, Name = "Kids and Family"},
            new { Id = 13, Name = "Board Games" },
            new { Id = 14, Name = "Horror" },
            new { Id = 15, Name = "Other" }
        );
    }
}
