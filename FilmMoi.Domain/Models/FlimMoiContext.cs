using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using FilmMoi.Domain.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FilmMoi.Domain.Models;

public partial class FlimMoiContext : DbContext
{
    public FlimMoiContext()
    {

    }

    public FlimMoiContext(DbContextOptions<FlimMoiContext> options) : base(options)
    {

    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlServer("Server=SURINRIN\\SQLEXPRESS01;Database=FlimMoi;Trusted_Connection=True;TrustServerCertificate=True");
        //optionsBuilder.UseSqlServer("Server=.;Database=FlimMoi;Trusted_Connection=True;TrustServerCertificate=True");
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        SeedingData(modelBuilder);
    }

    private void SeedingData(ModelBuilder modelBuilder)
    {
        //Role
        var rolesData = new List<Roles>()
       {
            new Roles()
            {
                Id = Guid.Parse("a884280c-dd19-4022-85bd-7105c59b27f9"),
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "f6b25b9e-5ef2-4aaf-9e9b-7ae4fdac2e2b"
            },
            new Roles()
            {
                Id = Guid.Parse("a040eef1-1d71-437e-ac64-e94d0b65c856"),
                Name = "Client",
                NormalizedName = "CLIENT",
                ConcurrencyStamp = "92ed2915-6aa0-4a86-8e7a-8f828d8d9e1f"
            }
        };
        modelBuilder.Entity<Roles>(b => { b.HasData(rolesData); });
        //User
        var usersData = new List<Users>()
      {
            new Users()
            {
                Id = Guid.Parse("E24D664C-E45F-4DDB-8743-04812E1CA9F5"),
                UserName = "dangs",
                NormalizedUserName = "DANGS",
                Email = "dangs3007@gmail.com",
                NormalizedEmail = "DANGS3007@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", // Password: "password"
                SecurityStamp = "XQYOWUD3KZAC3K6A3OJ3M7NJI3J4D7YX",
                ConcurrencyStamp = "f6b25b9e-5ef2-4aaf-9e9b-7ae4fdac2e2b",
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                RoleId = Guid.Parse("a884280c-dd19-4022-85bd-7105c59b27f9")
            },
            new Users()
            {
                Id = Guid.Parse("84F0E463-E887-4143-A994-61CA73C4793C"),
                UserName = "thend",
                NormalizedUserName = "THEND",
                Email = "thend@gmail.com",
                NormalizedEmail = "THEND@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", // Password: "password"
                SecurityStamp = "7S43J6OZ5E3H3Z2M3I2P8X7R7U5W2E7B",
                ConcurrencyStamp = "92ed2915-6aa0-4a86-8e7a-8f828d8d9e1f",
                PhoneNumber = "987654321",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                RoleId = Guid.Parse("a884280c-dd19-4022-85bd-7105c59b27f9")
            },
             new Users()
            {
                Id = Guid.Parse("f69cd789-4c44-401c-a021-5b6742af2279"),
                UserName = "clienttest",
                NormalizedUserName = "CLIENTEST",
                Email = "dangs123@gmail.com",
                NormalizedEmail = "DANGS123@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = "AQAAAAEAACcQAAAAEKY9X1b1Y2X9z8x2C9jzFz2JbYfhLzzKm3Q/7+YpY6XjyONn6m8fJ6iM0Wb8PfFy1A==", // Password: "password"
                SecurityStamp = "4b051b8e-4b64-4a2a-94e6-3f8a3b43b2c7",
                ConcurrencyStamp = "7d1c77f2-9b7e-4f5d-b0e6-3d13c7a4cc09",
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = true,
                TwoFactorEnabled = false,
                LockoutEnabled = true,
                AccessFailedCount = 0,
                RoleId = Guid.Parse("a040eef1-1d71-437e-ac64-e94d0b65c856")

            }
        };
        modelBuilder.Entity<Users>(b => { b.HasData(usersData); });
        //Actor
        var actorData = new List<Actors>()
        {
            new Actors()
            {
                ID = Guid.Parse("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                CreatedTime = DateTimeOffset.Now,
                Image = "actor1.jpg",
                Name = "Kirigaya Kazuto",
                Dob = new DateTime(1997,12,31),
                Nationality = "Japan"

            },
            new Actors()
            {
                ID = Guid.Parse("794b3996-aac6-437e-87c6-197fde46149d"),
                CreatedTime = DateTimeOffset.Now,
                Image = "actor2.jpg",
                Name = "Asuna Yuuki",
                Dob = new DateTime(1998, 6, 7),
                 Nationality = "Japan"
            },
            new Actors()
            {
                ID = Guid.Parse("e7ec9630-52da-4e31-9700-afe4627d672a"),
                CreatedTime = DateTimeOffset.Now,
                Image = "actor3.jpg",
                Name = "Levi Ackerman",
                Dob = new DateTime(1990, 12, 25),
                 Nationality = "Japan"
            },
            new Actors()
            {
                ID = Guid.NewGuid(),
                CreatedTime = DateTimeOffset.Now,
                Image = "actor4.jpg",
                Name = "Hermione Granger",
                Dob = new DateTime(1979, 9, 19),
                 Nationality = "America"
            },
            new Actors()
            {
                ID = Guid.NewGuid(),
                CreatedTime = DateTimeOffset.Now,
                Image = "actor5.jpg",
                Name = "Scarlett Johansson",
                Dob = new DateTime(1984, 11, 22),
                Nationality = "America"
            }

        };
        modelBuilder.Entity<Actors>(b => { b.HasData(actorData); });
        //Film
        var filmData = new List<Films>()
        {
            new Films()
            {
                ID = Guid.Parse("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                CreatedTime = DateTimeOffset.UtcNow,
                Name = "Sword Art Online",
                TotalEpisode = 0,
                AvgDuration = TimeSpan.Zero,
                Image = "film1.jpg",
                Status = Enum.FilmStatus.Released,
                Year = DateTime.Now.Year,
                Director = "Reki Kawahara",
                Description = "Anime cute"
            },
            new Films()
            {
                ID = Guid.Parse("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                CreatedTime = DateTimeOffset.UtcNow,
                Name = "The Shawshank Redemption",
                 TotalEpisode = 0,
                AvgDuration = TimeSpan.Zero,
                Image = "film2.jpg",
                Status = Enum.FilmStatus.Released,
                Year = DateTime.Now.Year,
                Director = "Frank Darabont",
                  Description = "Movie cute"
            },
            new Films()
            {
                ID = Guid.Parse("f5f7a014-9d4e-4c2e-a0b6-9b063f2e8f55"),
                CreatedTime = DateTimeOffset.UtcNow,
                Name = "Inception",
                 TotalEpisode = 0,
                AvgDuration = TimeSpan.Zero,
                Image = "film3.jpg",
                Status = Enum.FilmStatus.Released,
                Year = DateTime.Now.Year,
                Director = "Christopher Nolan",
                 Description = "Movie cute"
            },
            new Films()
            {
                ID = Guid.Parse("7b6c8b8f-70da-4e89-9971-2f1a8e7f9b56"),
                CreatedTime = DateTimeOffset.UtcNow,
                Name = "Pulp Fiction",
              TotalEpisode = 0,
                AvgDuration = TimeSpan.Zero,
                Image = "film4.jpg",
                Status = Enum.FilmStatus.Released,
                Year = DateTime.Now.Year,
                Director = "Quentin Tarantino",
                 Description = "Movie cute"
            },
            new Films()
            {
                ID = Guid.Parse("3d9a9d16-1b45-4a9b-8f7e-e3f0e0d8e3b9"),
                CreatedTime = DateTimeOffset.UtcNow,
                Name = "The Dark Knight",
               TotalEpisode = 0,
                AvgDuration = TimeSpan.Zero,
                Image = "film5.jpg",
                Status = Enum.FilmStatus.Released,
                Year = DateTime.Now.Year,
                Director = "Christopher Nolan",
                 Description = "Movie cute"
            }
        };
        modelBuilder.Entity<Films>(b => { b.HasData(filmData); });
        //genre
        var genresDate = new List<Genres>()
        {
            new Genres()
            {
                ID = Guid.Parse("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                CreatedTime = DateTimeOffset.UtcNow,
                GenreName = "Anime",
                
            },
            new Genres()
            {
                ID = Guid.Parse("088f52ea-8a6d-4bb5-8bb8-2cd647e9b0f4"),
                CreatedTime = DateTimeOffset.UtcNow,
                GenreName = "Chinese"
            },
            new Genres()
            {
                ID = Guid.Parse("52048ea3-02c1-4c1c-81e0-0e5de6b16b07"),
                CreatedTime = DateTimeOffset.UtcNow,
                GenreName = "Korea"
            },
            new Genres()
            {
                ID = Guid.Parse("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                CreatedTime = DateTimeOffset.UtcNow,
                GenreName = "Romantic"
            },  new Genres()
            {
                ID = Guid.Parse("d5c9f4da-131e-47b6-b41f-a91409bb5d3a"),
                CreatedTime = DateTimeOffset.UtcNow,
                GenreName = "Action"
            },
        };
        modelBuilder.Entity<Genres>(b => { b.HasData(genresDate); });
        var ratingsData = new List<Ratings>()
        {
            new Ratings()
            {
                ID_Film = Guid.Parse("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                ID_User = Guid.Parse("f69cd789-4c44-401c-a021-5b6742af2279"),
                Rating = 5,
                CreatedTime = DateTimeOffset.UtcNow,
     


            },new Ratings()
            {
                ID_Film = Guid.Parse("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                ID_User = Guid.Parse("f69cd789-4c44-401c-a021-5b6742af2279"),
                Rating = 5,  
                CreatedTime = DateTimeOffset.UtcNow
            },
        };
        modelBuilder.Entity<Ratings>(b => { b.HasData(ratingsData); });
        var filmsActorData = new List<FilmActors>()
        {
            new FilmActors()
            {
                ID = Guid.NewGuid(),
                CreatedTime = DateTimeOffset.UtcNow,
                ID_ACtor = Guid.Parse("7677bb7f-f9aa-4738-a61d-b52427d9dd62"),
                ID_Film =  Guid.Parse("98236a61-4d91-42fe-b956-fd64fb14ddc5"),


            }, new FilmActors()
            {
                ID = Guid.NewGuid(),
                CreatedTime = DateTimeOffset.UtcNow,
                ID_ACtor = Guid.Parse("794b3996-aac6-437e-87c6-197fde46149d"),
                ID_Film =  Guid.Parse("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
            }
        };
        modelBuilder.Entity<FilmActors>(b => { b.HasData(filmsActorData); });
        var genreFilmsData = new List<GenreFilms>()
        {
            new GenreFilms()
            {
                ID = Guid.NewGuid(),
                ID_Film = Guid.Parse("98236a61-4d91-42fe-b956-fd64fb14ddc5"),
                ID_Genre = Guid.Parse("cd19b97d-2377-41bb-99dc-7db8314ff35e"),
                 CreatedTime = DateTimeOffset.UtcNow,
            },
            new GenreFilms()
            {
                ID = Guid.NewGuid(),
                ID_Film = Guid.Parse("d8a2e1e2-5d8c-4c4c-bf5f-9a7d32de0a2a"),
                ID_Genre = Guid.Parse("836c97c0-2ad2-4cd9-b821-537a8a872354"),
                 CreatedTime = DateTimeOffset.UtcNow,
            }
        };
        modelBuilder.Entity<GenreFilms>(b => { b.HasData(genreFilmsData); });
    }

    #region DbSet
    public DbSet<Genres> Genres { get; set; }

    public DbSet<Films> Films { get; set; }

    public DbSet<GenreFilms> GenreFilms { get; set; }

    public DbSet<Actors> Actors { get; set; }
    public DbSet<Comments> Comments { get; set; }
    public DbSet<Episodes> Episodes { get; set; }
    public DbSet<FilmActors> FilmActors { get; set; }
    public DbSet<Ratings> Ratings { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<Users> Users { get; set; }
    public DbSet<WatchedFilms> WatchedFilms { get; set; }

    #endregion

}
