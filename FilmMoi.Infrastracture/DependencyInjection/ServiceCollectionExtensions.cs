﻿﻿using FilmMoi.Application.DataTransferObj.Actors;
using FilmMoi.Application.DataTransferObj.Comments;
using FilmMoi.Application.DataTransferObj.Episodes;
using FilmMoi.Application.DataTransferObj.Genres;
using FilmMoi.Application.DataTransferObj.Ratings;
using FilmMoi.Application.DataTransferObj.Users;

using FilmMoi.Application.DataTransferObj.WatchedFilms;

using FilmMoi.Application.DataTransferObj.Users;

using FilmMoi.Application.Interface.ReadOnly;
using FilmMoi.Application.Interface.ReadWrite;
using FilmMoi.Application.Interface.Utilities;
using FilmMoi.Domain.Models;
using FilmMoi.Domain.Models.Entities;
using FilmMoi.Infrastracture.Implement.Repository.ReadOnly;
using FilmMoi.Infrastracture.Implement.Repository.ReadWrite;
using FilmMoi.Infrastracture.Implement.Repository.Utilities;
using FilmMoi.Infrastructure.Implement.Repository.ReadOnly;
using FilmMoi.Infrastructure.Implement.Repository.ReadWrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FilmMoi.Infrastracture.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddEventBus(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FilmMoiContext>(options =>
            {
                // Configure your DbContext options here
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddTransient<ILocalizationService, LocalizationService>();
            //services.AddTransient<IUserReadOnlyRepoisitory, UserReadOnlyRepoisitory>();
            //services.AddTransient<IUserReadWriteRepoisitory, UserReadWriteRepoisitory>();
            //services.AddTransient<IExampleReadOnlyRepository, ExampleReadOnlyRepository>();
            //services.AddTransient<IExampleReadWriteRepository, ExampleReadWriteRepository>();
            services.AddTransient<IReadOnlyNPRepository<GenreDto>, GenresReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Genres>, GenresReadWriteRepository>();//required
            services.AddTransient<IReadOnlyWPRepository<ActorDto, ActorWithPaginationRequest>, ActorsROWPRepository>();//required
            services.AddTransient<IReadWriteRepository<Actors>, ActorsReadWriteRepository>();//required
            services.AddTransient<IReadOnlyWPRepository<CommentDto, CommentWithPaginationRequest>, CommentROWPRepository>();//required
            services.AddTransient<IReadWriteRepository<Comments>, CommentReadWriteRepository>();//required
            services.AddTransient<IReadWriteRepository<FilmActors>, FilmActorsReadWriteRepository>();//required
            services.AddTransient<IReadWriteRepository<GenreFilms>, GenreFilmsReadWriteRepository>();//required
            services.AddTransient<IReadOnlyNPRepository<RatingDto>, RatingReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Ratings>, RatingReadWriteRepository>();//required
            services.AddTransient<IReadOnlyWPRepository<EpisodesDto,EpisodesWithPaginationRequest>, EpisodesReadOnlyRepository>();//required
            services.AddTransient<IReadOnlyWPRepository<UserDto,UsersWithPaginationRequest>, UserReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<Users>, UserReadWriteRepository>();//required
            services.AddTransient<IReadWriteRepository<Episodes>, EpisodesReadWriteRepository>();//required

            services.AddTransient<IReadOnlyNPRepository<WatchedFilmDto>, WatchedFilmsReadOnlyRepository>();//required
            services.AddTransient<IReadWriteRepository<WatchedFilms>, WatchedFilmsReadWriteRepository>();//required

            services.AddTransient<IUsersUtilitiesRepository, UsersUtilitiesRepository>();//required


            return services;
        }
    }
}
